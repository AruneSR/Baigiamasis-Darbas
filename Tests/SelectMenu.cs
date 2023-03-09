using Framework.POM;
using System;

namespace Tests
{
    public class SelectMenu
    {
        public static double GetSelectedValue()
        { 
        
        }

        public static void SelectOption(string selectedSpecies)
        {
            Common.Select(Locators.SelectMenu.SelectSpecie)
        }
    }
}