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
            Common.ClickElement(Locators.SearchFieldProduct.ButtonSearch);
        }

        public static void EntervalidProductNameInSearchField(string valueinputSearch)
        {
            Common.SendKeys(Locators.SearchFieldProduct.inputvalueProductName,valueinputSearch);
        }            
    }

}
