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
    internal class SearchFieldProductsTests : BaseTests 
    {

        [Test]
        public void SearchFieldProducts()
        {
            string valueinputSearch = "pavadeliai";
            string valueinputPriceFrom = "1";
            string valueinputPriceTo = "50";
            
            SearchFieldProduct.EntervalidProductNameInSearchField(valueinputSearch);
            SearchFieldProduct.ClickButtonSearch();
            SearchFieldProduct.ClearTheTextBoxFrom();
            SearchFieldProduct.EnterPriceFrom(valueinputPriceFrom);
            SearchFieldProduct.ClearTheTextBoxTo();
            SearchFieldProduct.EnterPriceTo(valueinputPriceTo);

            Assert.IsTrue(SearchFieldProduct.CheckIfappearsTotalListOfProducts());
        }
    }
}
