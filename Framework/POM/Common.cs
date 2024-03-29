﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.POM
{
    public class Common
    {
        public static void OpenUrl(string url)
        {
            Driver.GetDriver().Url = "https://mumbo.lt/";
        }
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
       
        private static void ExecuteJavaScript(string script)
        {
            System.Threading.Thread.Sleep(2000);
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        public static void ScrollByPixels(int x, int y)
        {
            System.Threading.Thread.Sleep(2000);
            ExecuteJavaScript($"window.scrollBy({x}, {y})");
        }

        internal static bool GetElementDisplayedStatus(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            return GetElement(locator).Displayed;
        }

        internal static void GetElementClear(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            GetElement(locator).Clear();
        }
    }  }
