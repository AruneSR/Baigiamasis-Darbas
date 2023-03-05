using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@type='submit']"));
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
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();

            string valueinputSearch = "pavadeliai";
            System.Threading.Thread.Sleep(2000);
            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@id,'small-search-box-form')]"));
            inputSearch.SendKeys(valueinputSearch);
            System.Threading.Thread.Sleep(2000);

            driver.Quit();
        }






        [Test]

        public void AddProductToBasket()
        {


            IWebDriver driver = new ChromeDriver();
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
            driver.Url = "https://mumbo.lt/";
            System.Threading.Thread.Sleep(2000);

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')"));
            buttonIconUser.Click();
            System.Threading.Thread.Sleep(2000);
            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";
            
            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            System.Threading.Thread.Sleep(2000);
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@type='submit']"));
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
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
            acceptAll.Click();

            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]"));
            buttonIconUser.Click();

            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";

            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            IWebElement buttonLogin = driver.FindElement(By.XPath("//*[@type='submit']"));

            inputUserEmail.SendKeys(valueUserEmail);

            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();


            IWebElement IconVartotojoPaskyra = driver.FindElement(By.XPath("//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-user')]"));
            IconVartotojoPaskyra.Click();

            IWebElement buttonMyPets = driver.FindElement(By.XPath("//*[@href='/customer/pets']"));
            buttonMyPets.Click();

            IWebElement AddNewPet = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div[2]/div/div[1]/button"));
            AddNewPet.Click();
            driver.Quit();

        }
    }
}       