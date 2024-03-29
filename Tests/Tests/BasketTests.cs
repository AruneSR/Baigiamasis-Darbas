﻿using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class BasketTests : BaseTests
    {
        [Test]
        public void AddProductToBasket()
        {
            string expectedText = "Produktas įdėtas į jūsų prekių krepšelį";

            Basket.ClickDogIcon();
            Basket.ClickProductGertuves();
            Common.ScrollByPixels(0, 400);
            Basket.ClicFirstProductFromList();
            Basket.ClickAddToCart();

            Assert.AreEqual(expectedText, Basket.NotificationSuccess());
        }
    }
}
    
    

