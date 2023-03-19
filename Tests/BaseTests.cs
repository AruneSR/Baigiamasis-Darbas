using Framework;
using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            Home.ClickCookiesAllaccept();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
