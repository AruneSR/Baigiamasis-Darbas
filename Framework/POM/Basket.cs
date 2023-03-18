﻿namespace Framework.POM
{
    public class Basket
    {
        public static void ClickAddToCart()
        {
            Common.ClickElement(Locators.Basket.ButtonAddToCart);
        }

        public static void ClickDogIcon()
        {
            Common.ClickElement(Locators.Basket.ButtonDogIcon);
        }

        public static void ClicFirstProductFromList()
        {

            Common.ClickElement(Locators.Basket.ButtonFirstProduct);
        }

        public static void ClickProductGertuves()
        {   
            Common.ClickElement(Locators.Basket.ButtonProductGertuves);
        }

        public static string NotificationSuccess()
        {
            return Common.GetElementText(Locators.Basket.NotificationBar);
        }
    }
}
             
