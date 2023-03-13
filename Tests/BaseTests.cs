using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp]

        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            UserAccountFormLogin.ClickCookiesAllaccept();
        }

        [TearDown]

        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
   
}
