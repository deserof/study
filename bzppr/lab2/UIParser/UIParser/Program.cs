using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UIParser.Extensions;
using UIParser.Models;
using UIParser.Uitls;

namespace UIParser
{
    public class Program
    {
        private const int PagesNumber = 2;

        // Mobile Page

        private const string BaseUrl = "https://catalog.onliner.by/mobile";
        private static By entityTitleElement => By.XPath("//span[@data-bind='html: product.extended_name || product.full_name']/parent::a");
        private static By paginationElement => By.XPath("//div[@class='schema-pagination__secondary']");
        private static By pageElement => By.XPath("//li[@class='schema-pagination__pages-item']//a");

        // Phone selectors

        private static By NameElement => By.XPath("//h1[@class='catalog-masthead__title js-nav-header']");
        private static By ScreenResolutionElement => By.XPath("//td[contains(text(), 'Разрешение экрана')]/following-sibling::td[1]");
        private static By RAMElement => By.XPath("//td[contains(text(), 'Оперативная память')]/following-sibling::td[1]");
        private static By MemoryElement => By.XPath("//td[contains(text(), 'Встроенная память')]/following-sibling::td[1]");
        private static By GPSElement => By.XPath("//td[contains(text(), 'GPS')]/following-sibling::td[1]");
        private static By LTEElement => By.XPath("//td[contains(text(), 'LTE')]/following-sibling::td[1]");
        private static By G5Element => By.XPath("//td[contains(text(), '5G')]/following-sibling::td[1]");

        // Main

        static void Main(string[] args)
        {
            using var webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl(BaseUrl);
            webDriver.WaitForPageLoad();

            IList<IWebElement> entities = webDriver.FindElements(entityTitleElement);

            List<Phone> phones = new List<Phone>
            {
                new Phone {G5 = "wer", LTE = "ye", Name = "ph"},
                new Phone {Memory = "355", LTE = "ye", Name = "ph"}
            };

            for (int i = 0; i < PagesNumber; i++)
            {
                for (int j = 0; j < entities.Count; j++)
                {
                    string previousPageUrl = webDriver.Url;

                    webDriver.ScrollTo(entities[j]);
                    Wait.Until(() => entities[j].Enabled && entities[j].Displayed);
                    entities[j].Click();

                    phones.Add(GetPhone(webDriver));

                    webDriver.Navigate().GoToUrl(previousPageUrl);
                    webDriver.WaitForPageLoad();

                    entities = webDriver.FindElements(entityTitleElement);
                }

                if (i == PagesNumber - 1)
                {
                    break;
                }

                var pagination = webDriver.FindElement(paginationElement);
                webDriver.ScrollTo(pagination);
                Wait.Until(() => pagination.Enabled && pagination.Displayed);
                pagination.Click();

                Wait.For(TimeSpan.FromSeconds(1));
                IList<IWebElement> pages = webDriver.FindElements(pageElement);
                webDriver.ScrollTo(pages[i]);
                Wait.Until(() => pages[i].Enabled && pages[i].Displayed);
                pages[i].Click();
            }

            ExcelExporter<Phone>.ExportDataToExcel(phones, "Parsed Phones", "phones");
        }

        private static Phone GetPhone(WebDriver webDriver)
        {
            Phone phone = new()
            {
                Name = webDriver.GetElementTextFromTable(NameElement),
                ScreenResolution = webDriver.GetElementTextFromTable(ScreenResolutionElement),
                RAM = webDriver.GetElementTextFromTable(RAMElement),
                Memory = webDriver.GetElementTextFromTable(MemoryElement),
                GPS = webDriver.GetElementTextFromTable(G5Element),
                LTE = webDriver.GetElementTextFromTable(LTEElement),
                G5 = webDriver.GetElementTextFromTable(G5Element)
            };

            return phone;
        }
    }
}