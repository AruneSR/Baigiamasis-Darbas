using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class UserAccountFormLogin
    {
        public static void ClickButtonIconUser()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonIconUser);
        }

        public static void ClickButtonLogin()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonLogin);
        }

        public static void ClickButtonUserEmail()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonIconUserEmail);
        }

        public static void ClickButtonUserPassword()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonUserPassword);
        }

        public static void ClickCookiesAllaccept()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonCookiesAllaccept);
        }

        public static void EnterValueUserEmail(string valueUserEmail)
        {
            Common.SendKeys((string)Locators.UserAccountFormLogin.InputEmail,valueUserEmail);  
        }

        public static void EnterValueUserPassword(string valueUserPassword)
        {
           
            Common.SendKeys(Locators.UserAccountFormLogin.InputPassword,valueUserPassword);
            
        }
    }
}
