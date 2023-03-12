using Framework.POM;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class UserAccountInfoChangesTests
    {
        [Test]
        public void AddNewDogToMyPetsInfo()
        {
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            Driver.SetupDriver();
            Driver.OpenUrl("https://mumbo.lt/");
            UserAccountFormLogin.ClickCookiesAllaccept();
            UserAccountFormLogin.ClickButtonIconUser();
            UserAccountFormLogin.ClickButtonUserEmail();
            UserAccountFormLogin.EnterValueUserEmail(valueUserEmail);
            UserAccountFormLogin.ClickButtonUserPassword();
            UserAccountFormLogin.EnterValueUserPassword(valueUserPassword);
            UserAccountFormLogin.ClickButtonLogin();
            UserAccountInfoChanges.ClickIconUserAccount();
            UserAccountInfoChanges.ClickMyPets();
            UserAccountInfoChanges.ClickAddNewPet();
            string valuePetsName = "Amigo";
            string valuePetsBreed = "Vilkas";
            UserAccountInfoChanges.EnterValuePetsName(valuePetsName);
            UserAccountInfoChanges.EneterValuePetsBreed(valuePetsBreed);
          

            string selectedSpecies = "Dog";
            string expectedGimimoDiena = "3";
            string expectedGimimoMenuo = "11";
            string expectedGimimoMetai = "2019";
            UserAccountInfoChanges.SelectOptionInPetsSpecies(selectedSpecies);

            //Assert.AreEqual(selectedSpecies, UserAccount.GetSelectOptionInPetsSpecies());



            //IWebElement paspaustiAugintionVardoLauka = driver.FindElement(By.XPath("//*[@name='Pet.Name']"));
            //paspaustiAugintionVardoLauka.Click();

            //IWebElement inputAugintinioVardas = driver.FindElement(By.XPath("//*[@name='Pet.Name']"));
            //System.Threading.Thread.Sleep(2000);
            //inputAugintinioVardas.SendKeys(augintinioVardas);
            //System.Threading.Thread.Sleep(2000);

            //IWebElement paspaustiAugintinioVeislesLauka = driver.FindElement(By.XPath("//*[@id='Pet_Breed']"));
            //paspaustiAugintinioVeislesLauka.Click();


            //IWebElement inputAugintinioVeisle = driver.FindElement(By.XPath("//*[@id='Pet_Breed']"));
            //inputAugintinioVeisle.SendKeys(augintinioVeisle);




            ////IWebElement element = driver.FindElement(...).
            ////SelectElement tipo elementą: SelectElement selectElement = new SelectElement(element).

            ////IWebElement fieldAugintinioRusis = driver.FindElement(By.XPath("//*[@id='Pet_PetSpecies']"));
            ////fieldAugintinioRusis.Click();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement fieldAugintinioRusis = driver.FindElement(By.XPath("//*[@id='Pet_PetSpecies']//*[@value='Dog']"));
            //SelectElement selectRusis = new SelectElement(fieldAugintinioRusis);
            //selectRusis.SelectByValue("Dog");


        }
    }  }
