using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class Wishlist
    {
        public static void ClickIconCat()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-cat')]";
            Common.ClickElement(locator);
        }

        public static void ClickIconHeart()
        {

            string locator = "//*[@id='product-container']//*[@class='fas fa-heart']";
            Common.ClickElement(locator);
        }

        public static void ClickIconWishList()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-love')]";
            Common.ClickElement(locator);
        }

        public static void ClickProductGuoliai()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@href,'/guoliai-guoliai-katems')]";
            Common.ClickElement(locator);
        }
    }
}
