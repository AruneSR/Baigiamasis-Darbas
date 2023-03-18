using Framework.POM;
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

            UserAccountFormLogin.Login(valueUserEmail, valueUserPassword);
            Wishlist.ClickIconCat();
            Wishlist.ClickProductGuoliai();
            Wishlist.ClickIconHeart();
            Wishlist.ClickIconWishList();

            Assert.IsTrue(Wishlist.CheckIfMarkedHeartProductsCanFindOnWishlist());
        }
    }
}
