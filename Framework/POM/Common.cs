
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.POM
{
    public class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            return Driver.GetDriver().FindElement(By.XPath(locator));

        }
        internal static void ClickElement(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            GetElement(locator).Click();

        }

        internal static void SendKeys(string locator, string keys)
        {
            System.Threading.Thread.Sleep(2000);
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys);

        }
        internal static void SelectOptionBytext (string locator, string text)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }
        internal static string GetSelectedOptionText(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
            return selectElement.SelectedOption.Text;
        }

        internal static string GetElementText(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            return GetElement(locator).Text;
            
        }
    }  }
