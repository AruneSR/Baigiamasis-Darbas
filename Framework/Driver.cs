using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Driver
    {
        public static IWebDriver driver;
        private static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        public static void  QuitDriver() 
        {
            driver.Quit();
        }



    }
}
