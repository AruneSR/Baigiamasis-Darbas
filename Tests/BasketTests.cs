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
    internal class BasketTests
    {
        [Test]
        public void AddProductToBasket()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            UserAccountFormLogin.ClickCookiesAllaccept();
            Basket.ClickDogIcon();
            Basket.ClickProductGertuves();
            Basket.ClickHunterGertuve();
            Basket.ClickAddToCart();
            Basket.ClickBasketIcon();
            Driver.QuitDriver();

        }
    }
}
