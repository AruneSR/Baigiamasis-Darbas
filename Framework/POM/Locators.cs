using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    internal class Locators
    {

        internal static class UserAccountFormLogin
        { 
            internal static string ButtonIconUser  = "//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]";
            internal static string ButtonLogin = "//*[@action='/loginform']//*[@type='submit']";
            internal static string ButtonIconUserEmail = "//*[@id='Email']";
            internal static string ButtonUserPassword = "//*[@id='Password']";
            internal static string ButtonCookiesAllaccept = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
            internal static object InputEmail = "//*[@id='Email']";
            internal static string InputPassword = "//*[@id='Password']";
        }

    }
}
