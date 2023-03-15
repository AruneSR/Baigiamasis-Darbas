using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class Wishlist
    {
        public static bool CheckIfMarkedHeartProductsCanFindOnWishlist()
        {
            return Common.GetElementDisplayedStatus(Locators.Wishlist.MarkedHeartProducts);
        }
        public static void ClickIconCat()
        { 
            Common.ClickElement(Locators.Wishlist.ButtonIconCat);
        }

        public static void ClickIconHeart()
        { 
            Common.ClickElement(Locators.Wishlist.ButtonIconHeart);
        }
        public static void ClickIconWishList()
        {
            Common.ClickElement(Locators.Wishlist.ButtonIconWishlist);
        }
        public static void ClickProductGuoliai()
        {
            Common.ClickElement(Locators.Wishlist.ButtonProductGuoliai);
        }
    }
}
