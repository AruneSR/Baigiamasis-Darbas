using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class UserAccountInfoChanges
    {
        public static double GetSelectedValue { get; set; }

        public static void ClickAddNewPet()
        {
            string locator = "//*[@class='account__content']//*[@type='button']";
            Common.ClickElement(locator);
        }

        public static void ClickIconUserAccount()
        {
            string locator = "//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-user')]";
            Common.ClickElement(locator);
        }

        public static void ClickMyPets()
        {
            string locator = "//*[@href='/customer/pets']";
            Common.ClickElement(locator);
        }

        public static void EneterValuePetsBreed(string valuePetsBreed)
        {
            string locator = "//*[@id='Pet_Breed']";
            Common.SendKeys(valuePetsBreed, locator);

        }

       
        public static void EnterValuePetsName(string valuePetsName)
        {
            string locator = "//*[@name='Pet.Name']";
            Common.SendKeys(valuePetsName, locator);

        }

     

        //public static void GetSelectOptionInPetsSpecies(string optionText)
        //{
        //    string locator = "//*[@id='Pet_PetSpecies']";
        //    Common.GetSelectOptionText(locator, optionText);
        //}

        public static void SelectOptionInPetsSpecies(string optionText)
        {
            string locator = "//*[@id='Pet_PetSpecies']";
            Common.SelectOptionByText(locator,optionText);
        }
    }
}
