using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class Basket
    {
        public static void ClickAddToCart()
        {
            string locator = "//*[@id='addToCart']";
            Common.ClickElement(locator);
        }

        public static void ClickBasketIcon()
        {
            string locator = "//*[@class='user-controls__cart-label']";
            Common.ClickElement(locator);
        }

        public static void ClickDogIcon()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-dog')]";
            Common.ClickElement(locator);

        }

        public static void ClickHunterGertuve()
        {
            string locator = "//*[@class='product product-item product-item-1723']";
            Common.ClickElement(locator);

        }

        public static void ClickProductGertuves()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@href,'/gertuves-sunims')]";
            Common.ClickElement(locator);

        }
    }




}
             
