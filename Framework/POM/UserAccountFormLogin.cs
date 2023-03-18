namespace Framework.POM
{
    public class UserAccountFormLogin
    {
        public static void Login(string email, string password)
        {
            ClickButtonIconUser();
            EnterValueUserEmail(email);
            EnterValueUserPassword(password);
            ClickButtonLogin();
        }

        public static bool CheckIfFieldLogOutIsVisible()
        {
            return Common.GetElementDisplayedStatus(Locators.UserAccountFormLogin.FieldLogOut);
        }

        public static void ClickButtonIconUser()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonIconUser);
            Common.WaitForElementToBeVisible(Locators.UserAccountFormLogin.InputEmail);
        }

        public static void ClickButtonLogin()
        {
            Common.ClickElement(Locators.UserAccountFormLogin.ButtonLogin);
            Common.WaitForElementToBeVisible(Locators.UserAccountFormLogin.IconLogout);
        }

        public static void EnterValueUserEmail(string valueUserEmail)
        {
            Common.SendKeys(Locators.UserAccountFormLogin.InputEmail,valueUserEmail);  
        }

        public static void EnterValueUserPassword(string valueUserPassword)
        {
            Common.SendKeys(Locators.UserAccountFormLogin.InputPassword,valueUserPassword);
        }
    }
}
