using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UIParser.Uitls;

namespace UIParser.Extensions
{
    public static class WebDriverExtensions
    {
        public static object ExecuteJavaScript(this IWebDriver driver, string script, params object[] args)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }

            var javaScriptExecutor = driver as IJavaScriptExecutor;
            object result = javaScriptExecutor!.ExecuteScript(script, args);

            return result;
        }

        public static void WaitForPageLoad(this IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver1 => ExecuteJavaScript(driver, "return document.readyState").Equals("complete"));
        }

        public static string GetElementTextFromTable(this WebDriver webDriver, string text)
        {
            By locator = By.XPath($"//td[contains(text(), '{text}')]/following-sibling::td[1]//span");

            var elements = webDriver.FindElements(locator);

            if (elements.Count == 0)
            {
                return string.Empty;
            }

            webDriver.ScrollTo(elements[0]);
            Wait.Until(() => elements[0].Enabled && elements[0].Displayed);

            if (elements[0].GetAttribute("class") == "i-tip")
            {
                return "есть";
            }

            if (elements[0].GetAttribute("class") == "i-x")
            {
                return "нет";
            }

            return elements[0].Text.Trim();
        }

        public static string GetElement(this WebDriver webDriver, By locator)
        {
            var elements = webDriver.FindElements(locator);

            if (elements.Count == 0)
            {
                return string.Empty;
            }

            webDriver.ScrollTo(elements[0]);
            Wait.Until(() => elements[0].Enabled && elements[0].Displayed);

            return elements[0].Text.Trim();
        }

        public static void ScrollTo(this IWebDriver driver, IWebElement webElement)
        {
            if (driver != null && webElement != null)
            {
                driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", webElement);
            }
        }
    }
}
