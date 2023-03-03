using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas
{
    internal class Mumbo
    {
        [Test]
        public void LoginFormWithValidUser()
        {
            string expectedResult = "changedToUserAccount";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id=\'CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\']"));
            acceptAll.Click();
            

            IWebElement buttonIconUser = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/div/nav/a[1]/div/i"));
            buttonIconUser.Click();

            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";

            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            IWebElement buttonLogin = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div/div/div[1]/form/button"));

            inputUserEmail.SendKeys(valueUserEmail);

            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();

            IWebElement UserAccountIcon = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/div/nav/a[1]/div"));
            string actualResult = UserAccountIcon.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
