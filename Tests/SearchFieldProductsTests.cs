using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SearchFieldProductsTests
    {

        [Test]
        public void SearchFieldProducts()
        {
            string valueinputSearch = "pavadeliai";
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            UserAccountFormLogin.ClickCookiesAllaccept();
            SearchFieldProduct.EntervalueinputSearch(valueinputSearch);
            SearchFieldProduct.ClickButtonSearch();
            Driver.QuitDriver();
        }
    }
}
