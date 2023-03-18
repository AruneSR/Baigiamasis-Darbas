using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.POM
{
    public class Common
    {
        public static void OpenUrl(string url)
        {
            Driver.GetDriver().Url = url;
        }

        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
        internal static void SendKeys(string locator, string keys)
        {
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys);
        }

        internal static void SelectOptionBytext (string locator, string text)
        {
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        internal static string GetSelectedOptionText(string locator)
        {
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
            return selectElement.SelectedOption.Text;
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;      
        }
       
        private static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        public static void ScrollByPixels(int x, int y)
        {
            ExecuteJavaScript($"window.scrollBy({x}, {y})");
        }

        internal static bool GetElementDisplayedStatus(string locator)
        {
            return GetElement(locator).Displayed;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static int GetElementCount(string locator)
        {
            return GetElements(locator).Count;
        }

        internal static void ClearAndSendKeys(string locator, string keys)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.Click(element);
            actions.KeyDown(Keys.Control);
            actions.SendKeys("A");
            actions.KeyUp(Keys.Control);
            actions.SendKeys(element, keys);
            actions.SendKeys(element, Keys.Enter);
            actions.Perform();
        }

        internal static List<string> GetTextOfElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            List<string> texts = new List<string>();

            foreach (IWebElement element in elements)
            {
                texts.Add(element.Text);
            }

            return texts;
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }

        internal static void WaitForElementToBePresent(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(locator)));
        }
    }  
}
