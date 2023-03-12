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
            string expectedText = "Jūsų augintinis buvo sėkmingai pridėtas";
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
            string selectedSpecies = "Šuo";
            string selectedBirthDay = "3";
            string selectedBirthMonth = "liepa";
            string SelectedBirthYear = "2019";
            UserAccountInfoChanges.SelectOptionInBirthDay(selectedBirthDay);
            UserAccountInfoChanges.SelectOptionInBirthMonth(selectedBirthMonth);
            UserAccountInfoChanges.SelectOptionInBirthYear(SelectedBirthYear);
            UserAccountInfoChanges.SelectOptionInPetsSpecies(selectedSpecies);
            UserAccountInfoChanges.CLickButtonToSave();

            Assert.AreEqual(expectedText, UserAccountInfoChanges.NotificationSucces());

        }
    }  }
