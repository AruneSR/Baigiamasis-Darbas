
using OpenQA.Selenium;
using System;

namespace Framework.POM
{
    public class Common
    {
       

        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
            
        }
        internal static void ClickElement(string locator)
        {
            
            GetElement(locator).Click();
            
        }

        internal static void SendKeys(string locator ,string keys)
        {
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys);
           
        }
    }    




}

