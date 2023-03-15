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
    internal class UserAccountFormLoginTests : BaseTests
    {
        [Test]
        public void LoginFormWithValidUser()
        {
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            UserAccountFormLogin.ClickButtonIconUser();
            UserAccountFormLogin.ClickButtonUserEmail();  
            UserAccountFormLogin.EnterValueUserEmail(valueUserEmail);  
            UserAccountFormLogin.ClickButtonUserPassword();
            UserAccountFormLogin.EnterValueUserPassword(valueUserPassword);
            UserAccountFormLogin.ClickButtonLogin();

            Assert.IsTrue(UserAccountFormLogin.CheckIfFieldLogOutIsVisible());
        }
}   }

  