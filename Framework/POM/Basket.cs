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
            Common.ClickElement(Locators.Basket.ButtonAddToCart);
        }

        public static void ClickBasketIcon()
        {
            Common.ClickElement(Locators.Basket.ButtonBasketIcon);
        }

        public static void ClickDogIcon()
        {
            Common.ClickElement(Locators.Basket.ButtonDogIcon);
        }

        public static void ClickHunterGertuve()
        {
            Common.ClickElement(Locators.Basket.ButtonHunterGertuve);
        }

        public static void ClickProductGertuves()
        {
            Common.ClickElement(Locators.Basket.ButtonProductGertuves);
        }
    }




}
             
