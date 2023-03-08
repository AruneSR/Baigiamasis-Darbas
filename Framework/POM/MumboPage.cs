using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class MumboPage
    {
        public static void ClickButtonIconUser()
        {

            string locator = "//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]";
            Common.ClickElement(locator);
           

        }

        public static void ClickButtonLogin()
        {
            string locator = "//*[@action='/loginform']//*[@type='submit']";
            Common.ClickElement(locator);
            

        }

        public static void ClickButtonUserEmail()
        {
            string locator ="//*[@id='Email']";
            Common.ClickElement(locator);
        }

        public static void ClickButtonUserPassword()
        {
            string locator = "//*[@id='Password']";
            Common.ClickElement(locator);
        }

        public static void ClickCookiesAllaccept()
        {

            string locator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
            Common.ClickElement(locator);
           
        }

        public static void EnterValueUserEmail(string valueUserEmail)
        {
           
            string locator = "//*[@id='Email']";
            Common.SendKeys(valueUserEmail, locator);
           
        }

        public static void EnterValueUserPassword(string valueUserPassword)
        {
            string locator = "//*[@id='Password']";
            Common.SendKeys(valueUserPassword, locator);
            
        }
    }
}
