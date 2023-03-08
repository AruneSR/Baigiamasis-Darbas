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
            
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            MumboPage.ClickCookiesAllaccept();
            System.Threading.Thread.Sleep(2000);
            MumboPage.ClickButtonIconUser();
            System.Threading.Thread.Sleep(2000);
           
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            MumboPage.ClickButtonUserEmail();
            System.Threading.Thread.Sleep(2000);
            MumboPage.EnterValueUserEmail(valueUserEmail);
            System.Threading.Thread.Sleep(2000);
            MumboPage.ClickButtonUserPassword();
            System.Threading.Thread.Sleep(2000);
            MumboPage.EnterValueUserPassword(valueUserPassword);
            MumboPage.ClickButtonLogin();
            Driver.QuitDriver();

        }
    }    }

  