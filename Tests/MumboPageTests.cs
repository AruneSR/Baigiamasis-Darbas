using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class MumboPageTests
    {
        [Test]
        public void LoginFormWithValidUser()
        
            Driver.OpenUrl("https://mumbo.lt/");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]"));
            buttonIconUser.Click();

            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";
            System.Threading.Thread.Sleep(2000);

            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            System.Threading.Thread.Sleep(3000);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@action='/loginform']//*[@type='submit']"));
            System.Threading.Thread.Sleep(2000);

            inputUserEmail.SendKeys(valueUserEmail);
            System.Threading.Thread.Sleep(2000);


            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();


            driver.Quit();
        }
    }

    internal class Common
    {
        internal static void OpenUrl(string v)
        {
            throw new NotImplementedException();
        }
    }
}
