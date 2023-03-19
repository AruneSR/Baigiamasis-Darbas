using System;
using System.Collections.Generic;

namespace Framework.POM
{
    public class SearchFieldProduct
    {
        public static bool AllProductPricesAreInRange(int priceFrom, int priceTo)
        {
            // Get prices of all products
            List<string> pricesText = Common.GetTextOfElements(Locators.SearchFieldProduct.SpanProductPrice);
            List<double> pricesDouble = new List<double>();

            // Convert prices from text to number value
            for (int i = 0; i < pricesText.Count; i++)
            {
                string priceWithoutEuroSymbol = pricesText[i].Substring(0, 4);
                string priceWithDot = priceWithoutEuroSymbol.Replace(",", ".");
                pricesDouble.Add(Convert.ToDouble(priceWithDot));
            }

            // Check each price if it is in the specified range
            foreach (double price in pricesDouble)
            {
                if (price < priceFrom || price > priceTo)
                {
                    return false;
                }
            }

            return true;
        }

        public static void ClickButtonSearch()
        {
            Common.ClickElement(Locators.SearchFieldProduct.ButtonSearch);
            Common.WaitForElementToBeVisible(Locators.SearchFieldProduct.HeadingSearchResults);
        }

        public static void EnterPriceFrom(int price)
        {
            Common.ClearAndSendKeys(Locators.SearchFieldProduct.InputvaluePriceFrom, price.ToString());
            Home.WaitForPageToFinishLoading();
        }

        public static void EnterPriceTo(int price)
        {
            Common.ClearAndSendKeys(Locators.SearchFieldProduct.InputvaluePriceTo, price.ToString());
            Home.WaitForPageToFinishLoading();
        }

        public static void EnterProductName(string product)
        {
            Common.SendKeys(Locators.SearchFieldProduct.InputvalueProductName, product);
        }            
    }
}
