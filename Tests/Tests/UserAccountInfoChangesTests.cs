using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class UserAccountInfoChangesTests : BaseTests
    {
        [Test]
        public void AddNewDogToMyPetsInfo()
        {
            string expectedText = "Jūsų augintinis buvo sėkmingai pridėtas";
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            string valuePetsName = "Amigo";
            string valuePetsBreed = "Vilkas";
            string selectedSpecies = "Šuo";
            string selectedBirthDay = "3";
            string selectedBirthMonth = "liepa";
            string SelectedBirthYear = "2019";

            UserAccountFormLogin.Login(valueUserEmail, valueUserPassword);
            UserAccountInfoChanges.ClickIconUserAccount();
            UserAccountInfoChanges.ClickMyPets();
            UserAccountInfoChanges.ClickAddNewPet();
            UserAccountInfoChanges.EnterValuePetsName(valuePetsName);
            UserAccountInfoChanges.EneterValuePetsBreed(valuePetsBreed);
            UserAccountInfoChanges.SelectOptionInBirthDay(selectedBirthDay);
            UserAccountInfoChanges.SelectOptionInBirthMonth(selectedBirthMonth);
            UserAccountInfoChanges.SelectOptionInBirthYear(SelectedBirthYear);
            UserAccountInfoChanges.SelectOptionInPetsSpecies(selectedSpecies);
            UserAccountInfoChanges.CLickButtonToSave();

            Assert.AreEqual(expectedText, UserAccountInfoChanges.NotificationSuccess());
        }
    }  
}
