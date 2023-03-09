using Framework;
using Framework.POM;
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
        {
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";

            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            MumboPage.ClickCookiesAllaccept();
            MumboPage.ClickButtonIconUser();
            MumboPage.ClickButtonUserEmail();  
            MumboPage.EnterValueUserEmail(valueUserEmail);  
            MumboPage.ClickButtonUserPassword();
            MumboPage.EnterValueUserPassword(valueUserPassword);
            MumboPage.ClickButtonLogin();
            Driver.QuitDriver();

        }
}   }

  