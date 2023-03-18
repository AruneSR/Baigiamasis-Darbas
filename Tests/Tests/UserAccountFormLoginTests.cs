using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    internal class UserAccountFormLoginTests : BaseTests
    {
        [Test]
        public void LoginFormWithValidUser()
        {
            string valueUserEmail = "missarune@gmail.com";
            string valueUserPassword = "Mumbo2023";
            
            UserAccountFormLogin.ClickButtonIconUser();
            UserAccountFormLogin.EnterValueUserEmail(valueUserEmail);  
            UserAccountFormLogin.EnterValueUserPassword(valueUserPassword);
            UserAccountFormLogin.ClickButtonLogin();

            Assert.IsTrue(UserAccountFormLogin.CheckIfFieldLogOutIsVisible());
        }
    }   
}
  