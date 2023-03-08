
using OpenQA.Selenium;
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

        internal static void SendKeys(string keys,string locator)
        {
            System.Threading.Thread.Sleep(2000);
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys);
           
        }
    }    




}

