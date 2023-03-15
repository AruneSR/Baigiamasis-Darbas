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
            
            SearchFieldProduct.EntervalidProductNameInSearchField(valueinputSearch);
            SearchFieldProduct.ClickButtonSearch();

            Assert.IsTrue(SearchFieldProduct.CheckIfappearsTotalListOfProducts());
        }
    }
}
