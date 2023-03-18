using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class SearchFieldProductsTests : BaseTests 
    {
        [Test]
        public void SearchFieldProducts()
        {
            string valueinputSearch = "pavadeliai";
            int valueinputPriceFrom = 20;
            int valueinputPriceTo = 30;
            
            SearchFieldProduct.EnterProductName(valueinputSearch);
            SearchFieldProduct.ClickButtonSearch();
            SearchFieldProduct.EnterPriceFrom(valueinputPriceFrom);
            SearchFieldProduct.EnterPriceTo(valueinputPriceTo);

            Assert.IsTrue(SearchFieldProduct.AllProductPricesAreInRange(1, 50));
        }
    }
}
