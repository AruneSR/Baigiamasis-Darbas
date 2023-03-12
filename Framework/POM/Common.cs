﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            System.Threading.Thread.Sleep(2000);
            GetElement(locator).Click();

        }

        internal static void SendKeys(string keys, string locator)
        {
            System.Threading.Thread.Sleep(2000);
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(keys);

        }

        internal static SelectElement SelectOptionByText(string locator)
        {

            System.Threading.Thread.Sleep(2000);
            IWebElement element = GetElement(locator);
            return new SelectElement(element);

        }
        internal static void SelectOptionByText(string locator, string Text)
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
           
            selectElement.SelectByText(Text);

        }

        internal static string GetSelectOptionText(string locator)
        {
            IWebElement element = GetElement(locator);
            SelectElement selectElement = new SelectElement(element);
            return selectElement.SelectedOption.Text;
        }

       
       
    }  }
