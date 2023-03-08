using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        public static IWebDriver driver;
     
       
        public static void SetupDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        public static void QuitDriver()
        {
            driver.Quit();
        }

      
       

    }
}
