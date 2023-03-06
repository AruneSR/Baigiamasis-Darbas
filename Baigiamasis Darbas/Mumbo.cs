using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas
{
    internal class Mumbo
    {
        [Test]
        public void LoginFormWithValidUser()
        {
         

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]"));
            buttonIconUser.Click();

            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";
            System.Threading.Thread.Sleep(2000);

            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            System.Threading.Thread.Sleep(3000);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@action='/loginform']//*[@type='submit']"));
            System.Threading.Thread.Sleep(2000);

            inputUserEmail.SendKeys(valueUserEmail);
            System.Threading.Thread.Sleep(2000);


            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();


            driver.Quit();
        }


        [Test]

        public void SearchFieldProducts() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();

            string valueinputSearch = "pavadeliai";
            System.Threading.Thread.Sleep(2000);
            IWebElement Search = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[@id='small-searchterms']"));
            Search.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@action='/search']//*[@class='search-prediction']")); 
            inputSearch.SendKeys(valueinputSearch);                                           //*[@action='/search']//*[@type='search']
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonSearch = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[@id='small-search-box-form']/button"));
            buttonSearch.Click();

            driver.Quit();
        }






        [Test]

        public void AddProductToBasket()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonIconDog = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-dog')]"));
            buttonIconDog.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonGertuves = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@href,'/gertuves-sunims')]"));
            buttonGertuves.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement chooseHunterGertuve = driver.FindElement(By.XPath("//*[@class='product product-item product-item-1723']"));
            chooseHunterGertuve.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id='addToCart']"));
            addToCart.Click();
            System.Threading.Thread.Sleep(2000);


            driver.Quit();



        }



        [Test]
        public void AddProductToWishList()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]"));
            buttonIconUser.Click();
            System.Threading.Thread.Sleep(2000);
            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";
            
            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@action='/loginform']//*[@type='submit']"));
            System.Threading.Thread.Sleep(2000);
            inputUserEmail.SendKeys(valueUserEmail);
            System.Threading.Thread.Sleep(2000);
            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement buttonIconCat = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-cat')]"));
            buttonIconCat.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonGuoliai = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@href,'/guoliai-guoliai-katems')]"));
            buttonGuoliai.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement buttonIconHeart = driver.FindElement(By.XPath("//*[@class='fas fa-heart']"));
            buttonIconHeart.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement buttonWishList = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-love')]"));
            buttonWishList.Click();

            System.Threading.Thread.Sleep(2000);

            driver.Quit();


        }
        [Test]
        public void AddNewDogToMyPetsInfo()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]"));
            buttonIconUser.Click();
            System.Threading.Thread.Sleep(2000);
            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";

            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@action='/loginform']//*[@type='submit']"));
            System.Threading.Thread.Sleep(2000);

            inputUserEmail.SendKeys(valueUserEmail);

            System.Threading.Thread.Sleep(2000);

            inputPassword.SendKeys(valuePassword);
            System.Threading.Thread.Sleep(2000);

            buttonLogin.Click();


            System.Threading.Thread.Sleep(2000);


            IWebElement IconVartotojoPaskyra = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-user')]"));
            IconVartotojoPaskyra.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement buttonManoAugintiniai = driver.FindElement(By.XPath("//*[@href='/customer/pets']"));
            buttonManoAugintiniai.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement PridetiNaujaAugintini = driver.FindElement(By.XPath("//*[@class='account__content']//*[@type='button']"));
            PridetiNaujaAugintini.Click();
            
            string augintinioVardas = "Amigo";
            string augintinioVeisle = "Vilkas";

            IWebElement inputAugintinioVardas = driver.FindElement(By.XPath("//*[@id='Pet_Name']"));
            System.Threading.Thread.Sleep(2000);
            inputAugintinioVardas.SendKeys(augintinioVardas);
            System.Threading.Thread.Sleep(2000);
            IWebElement inputAugintinioVeisle = driver.FindElement(By.XPath("//*[@id='Pet_Breed']"));
            inputAugintinioVeisle.SendKeys(augintinioVeisle);

            string expectedGimimoDiena = "3";
            string expectedGimimoMenuo = "11";
            string expectedGimimoMetai = "2019";
            string expectedRusis = "Suo";




            SelectElement selectAugintinioGimimoDiena = SelectElement.(By.XPath("//*[@class='date-picker-wrapper']//*[@value='3']"));
            selectAugintinioGimimoDiena.SelectByValue(expectedGimimoDiena);

            IWebElement selectAugintiniorusys = driver.FindElement(By.XPath("//*[@id='Pet_PetSpecies']/option[1]"));









            driver.Quit();





        }
    }
}       