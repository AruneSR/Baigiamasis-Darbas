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
    internal class WishlistTest
    {
        [Test]
        public void AddProductToWishList()
        {
           

            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            MumboPage.ClickCookiesAllaccept();
            MumboPage.ClickButtonIconUser();
            MumboPage.ClickButtonUserEmail();
            MumboPage.EnterValueUserEmail(valueUserEmail);
            MumboPage.ClickButtonUserPassword();
            MumboPage.EnterValueUserPassword(valueUserPassword);
            MumboPage.ClickButtonLogin();
            Wishlist.ClickIconCat();
            Wishlist.ClickProductGuoliai();
            Wishlist.ClickIconHeart();
            Wishlist.ClickIconWishList();
            Driver.QuitDriver();

        }

    }
}
