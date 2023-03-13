using Framework.POM;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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
            Basket.ClickHunterGertuve();
            Basket.ClickAddToCart();
            
            Assert.AreEqual(expectedText, Basket.NotificationSuccess());
        }
    }
}
