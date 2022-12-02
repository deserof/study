using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using UIParser.Extensions;
using UIParser.Uitls;

namespace UIParser
{
    /// <summary>
    /// Требования:
    ///     - Visual Studio 2022
    ///     - .net 6.0
    ///     - Браузер Google Chrome последней версии
    ///
    /// Если парсер падает при запуске, то надо обновить nuget пакет ChromeDriver до последней версии,
    /// также такая версия должна быть в Google Chrome.
    ///
    /// Описание:
    /// Можно парсить почти любой ресурс в каталоге, например, ноутбуки
    /// private const string BaseUrl = "https://catalog.onliner.by/notebook";
    ///
    /// В методе GetPhone можно изменить название свойств на любое, так как тип dynamic
    /// В методах webDriver.GetElementTextFromTable(...) вставить название колонки с сайта, которую хотите прочитать.
    /// 
    /// Пример:
    ///     было на странице телефонов OS = webDriver.GetElementTextFromTable("Операционная система"),
    ///     стало на странице ноутбуков Graphic = webDriver.GetElementTextFromTable("Встроенная в процессор графика"),
    ///
    /// Примечание:
    /// Excel файл находится в папке с проектом UIParser.
    /// Чтобы Excel файл сохранился надо закрыть браузер.
    /// </summary>
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
        private static By PriceElement => By.XPath("//div[@class='offers-description__price-group']//div//a");

        // Main

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var phones = new List<dynamic>();
            var exception = string.Empty;
            var source = string.Empty;
            var stackTrace = string.Empty;

            using var webDriver = new ChromeDriver();

            try
            {
                webDriver.Manage().Window.Maximize();

                webDriver.Navigate().GoToUrl(BaseUrl);
                webDriver.WaitForPageLoad();

                IList<IWebElement> entities = webDriver.FindElements(entityTitleElement);

                for (var i = 0; i < PagesNumber; i++)
                {
                    for (var j = 0; j < entities.Count; j++)
                    {
                        entities = webDriver.FindElements(entityTitleElement);

                        var previousPageUrl = webDriver.Url;

                        webDriver.ScrollTo(entities[j]);
                        Wait.Until(() => entities[j].Enabled && entities[j].Displayed);
                        entities[j].Click();

                        var phone = GetPhone(webDriver);
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

                    var ss = ((ITakesScreenshot)webDriver).GetScreenshot();
                    ss.SaveAsFile("..\\..\\..\\..\\UIParserScr.png", ScreenshotImageFormat.Png);
                }
            }
        }

        private static dynamic GetPhone(WebDriver webDriver)
        {
            dynamic phone = new
            {
                Name = webDriver.GetElement(NameElement),
                Price = webDriver.GetElement(PriceElement).Split(",")[0],
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