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
    internal class WishlistTest : BaseTests
    {
        [Test]
        public void AddProductToWishList()
        {
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
          
            UserAccountFormLogin.ClickButtonIconUser();
            UserAccountFormLogin.ClickButtonUserEmail();
            UserAccountFormLogin.EnterValueUserEmail(valueUserEmail);
            UserAccountFormLogin.ClickButtonUserPassword();
            UserAccountFormLogin.EnterValueUserPassword(valueUserPassword);
            UserAccountFormLogin.ClickButtonLogin();
            Wishlist.ClickIconCat();
            Wishlist.ClickProductGuoliai();
            Wishlist.ClickIconHeart();
            Wishlist.ClickIconWishList();

            Assert.IsTrue(Wishlist.CheckIfMarkedHeartProductsCanFindOnWishlist());

        }

    }
}
