using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using UIParser.Extensions;
using UIParser.Uitls;

namespace UIParser
{
    public class Program
    {
        private const int PagesNumber = 50;

        // Mobile Page

        private const string BaseUrl = "https://catalog.onliner.by/mobile";
        private static By entityTitleElement => By.XPath("//span[@data-bind='html: product.extended_name || product.full_name']/parent::a");
        private static By paginationElement => By.XPath("//div[@class='schema-pagination__secondary']");
        private static By pageElement => By.XPath("//li[@class='schema-pagination__pages-item']//a");

        // Phone Name

        private static By NameElement => By.XPath("//h1[@class='catalog-masthead__title js-nav-header']");

        // Main

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<dynamic> phones = new List<dynamic>();
            string exception = string.Empty;
            string source = string.Empty;
            string stackTrace = string.Empty;

            using var webDriver = new ChromeDriver();

            try
            {
                webDriver.Manage().Window.Maximize();

                webDriver.Navigate().GoToUrl(BaseUrl);
                webDriver.WaitForPageLoad();

                IList<IWebElement> entities = webDriver.FindElements(entityTitleElement);

                for (int i = 0; i < PagesNumber; i++)
                {
                    for (int j = 0; j < entities.Count; j++)
                    {
                        entities = webDriver.FindElements(entityTitleElement);

                        string previousPageUrl = webDriver.Url;

                        webDriver.ScrollTo(entities[j]);
                        Wait.Until(() => entities[j].Enabled && entities[j].Displayed);
                        entities[j].Click();

                        dynamic phone = GetPhone(webDriver);
                        phones.Add(phone);
                        Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")} -> added {phone.Name}");

                        webDriver.Navigate().GoToUrl(previousPageUrl);
                        webDriver.WaitForPageLoad();

                        // может не успеть прогрузить каталог. написать нормальный вейтер
                        Wait.For(TimeSpan.FromSeconds(5));
                    }

                    if (i == PagesNumber)
                    {
                        break;
                    }

                    var pagination = webDriver.FindElement(paginationElement);
                    webDriver.ScrollTo(pagination);
                    Wait.Until(() => pagination.Enabled && pagination.Displayed);
                    pagination.Click();

                    Wait.For(TimeSpan.FromSeconds(2));
                    IList<IWebElement> pages = webDriver.FindElements(pageElement);
                    // скорее всего поломается на скроле в бок, там где 40+ страница
                    webDriver.ScrollTo(pages[i]);
                    Wait.Until(() => pages[i].Enabled && pages[i].Displayed);
                    pages[i].Click();

                    // может не успеть прогрузить каталог. написать нормальный вейтер
                    Wait.For(TimeSpan.FromSeconds(15));
                }
            }
            catch (Exception e)
            {
                exception = e.Message;
                source = e.Source!;
                stackTrace = e.StackTrace!;
            }
            finally
            {
                ExcelExporter.ExportDataToExcel(phones, "Parsed Phones", "phones");

                if (!string.IsNullOrEmpty(source) ||
                    !string.IsNullOrEmpty(exception) ||
                    !string.IsNullOrEmpty(stackTrace))
                {
                    Console.WriteLine("EXCEPTION!!!");
                    Console.WriteLine($"{nameof(source)} {source}");
                    Console.WriteLine(new string('-', 15));
                    Console.WriteLine($"{nameof(exception)} {exception}");
                    Console.WriteLine(new string('-', 15));
                    Console.WriteLine($"{nameof(stackTrace)} {stackTrace}");

                    Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
                    ss.SaveAsFile("C:\\UIParserScr.png", ScreenshotImageFormat.Png);
                }
            }
        }

        private static dynamic GetPhone(WebDriver webDriver)
        {
            dynamic phone = new
            {
                Name = webDriver.GetElement(NameElement),
                OS = webDriver.GetElementTextFromTable("Операционная система"),
                ScreenTechnology = webDriver.GetElementTextFromTable("Технология экрана"),
                ScreenRefreshRate = webDriver.GetElementTextFromTable("Частота обновления экрана"),
                NumberOfMatrixPoints = webDriver.GetElementTextFromTable("Количество точек матрицы"),
                CameraSpecifications = webDriver.GetElementTextFromTable("Характеристики камеры"),
                MaximumVideoResolution = webDriver.GetElementTextFromTable("Максимальное разрешение видео"),
                NumberOfSIMCards = webDriver.GetElementTextFromTable("Количество SIM-карт"),
                ScreenResolution = webDriver.GetElementTextFromTable("Разрешение экрана"),
                RAM = webDriver.GetElementTextFromTable("Оперативная память"),
                Memory = webDriver.GetElementTextFromTable("Встроенная память"),
                Processor = webDriver.GetElementTextFromTable("Процессор"),
                ProcessorClockSpeed = webDriver.GetElementTextFromTable("Тактовая частота процессора"),
                ProcessTechnology = webDriver.GetElementTextFromTable("Техпроцесс"),
                Material = webDriver.GetElementTextFromTable("Материал корпуса"),
                SimFormat = webDriver.GetElementTextFromTable("Формат SIM-карты"),
                SensorScreen = webDriver.GetElementTextFromTable("Сенсорный экран"),
                ScratchProtection = webDriver.GetElementTextFromTable("Защита от царапин"),
                GPS = webDriver.GetElementTextFromTable("GPS"),
                LTE = webDriver.GetElementTextFromTable("LTE"),
                G5 = webDriver.GetElementTextFromTable("5G"),
                BatteryCapacity = webDriver.GetElementTextFromTable("Емкость аккумулятора"),
            };

            return phone;
        }
    }
}