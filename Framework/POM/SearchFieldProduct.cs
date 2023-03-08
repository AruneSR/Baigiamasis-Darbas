using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class SearchFieldProduct
    {
        public static void ClickButtonSearch()
        {
            string locator = "//*[@class='yp-header-desktop']//*[@id='small-search-box-form']/button";
            Common.ClickElement(locator);



        }

        public static void EntervalueinputSearch(string valueinputSearch)
        {
            string locator = "//*[@class='yp-header-desktop']//*[@id='small-searchterms']";
            Common.SendKeys(valueinputSearch, locator);

        }            
    }

}
