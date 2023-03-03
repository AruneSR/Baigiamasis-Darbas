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

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id=\'CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\']"));
            acceptAll.Click();


            IWebElement buttonIconUser = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/header[2]/div/div/div/div/nav/a[1]"));
            buttonIconUser.Click();

            string valueUserEmail = "missarune@gmail.com";
            string valuePassword = "Mumbo2023";
            
            IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id='Email']"));
            IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            IWebElement buttonLogin = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div/div/div[1]/form/button"));

            inputUserEmail.SendKeys(valueUserEmail);

            inputPassword.SendKeys(valuePassword);
            buttonLogin.Click();

           
            driver.Quit();

           

         }
       


          public void SearchFieldProducts()
          {
            string expectedResult = "gaunamasPavadeliuSarasas";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id=\'CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\']"));
            acceptAll.Click();

            string valueinputSearch = "pavadeliai";

            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@id='small-searchterms']"));
            inputSearch.SendKeys(valueinputSearch);

            IWebElement ButtonSearch = driver.FindElement(By.XPath("//*[@id=\'small-search-box-form\']/button"));
            string actualResult = ButtonSearch.Text;



            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
           }
           [Test]

           public void AddProductToBasket()
           {
            string expectedResult = "productApearInMyBasket";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mumbo.lt/";

            IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id=\'CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\']"));
            acceptAll.Click();

            IWebElement buttonSunys = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/nav/ul[1]/li[1]/a/i"));
            buttonSunys.Click();

            IWebElement buttonGertuves = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/nav/ul[1]/li[1]/a/i"));
            buttonGertuves.Click();

            IWebElement chooseHunterGertuve = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/nav/ul[1]/li[1]/a/i"));
            chooseHunterGertuve.Click();

            IWebElement addToCart = driver.FindElement(By.XPath("//*[@id=\"addToCart\"]"));
            addToCart.Click();

            IWebElement buttonMyBasket = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/div/nav/a[3]/div[2]"));
            string actualResult = buttonMyBasket.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);

           }

             [Test]
             public void AddNewDogToMyPetsInfo()
             {
                string expectedResult = "";

                    IWebDriver driver = new ChromeDriver();
                    driver.Url = "https://mumbo.lt/";

                    IWebElement acceptAll = driver.FindElement(By.XPath("//*[@id=\'CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\']"));
                    acceptAll.Click();

                    IWebElement buttonIconUser = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/div/nav/a[1]/div/i"));
                    buttonIconUser.Click();

                    string valueUserEmail = "missarune@gmail.com";
                    string valuePassword = "Mumbo2023";

                    IWebElement inputUserEmail = driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
                    IWebElement inputPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
                    IWebElement buttonLogin = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div/div/div[1]/form/button"));

                    inputUserEmail.SendKeys(valueUserEmail);

                    inputPassword.SendKeys(valuePassword);
                    buttonLogin.Click();


                    IWebElement IconVartotojoPaskyra = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/header[2]/div/div/div/div/nav/a[1]/div/i"));
                    IconVartotojoPaskyra.Click();

                    IWebElement buttonMyPets = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div[1]/div[1]/a[7]"));
                    buttonMyPets.Click();

                    IWebElement AddNewPet = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div[2]/div/div[1]/button"));
                    AddNewPet.Click();

                    string PetName = "Amigo";
                    string PetBreed = "Vilkas";


                   
                    driver.Quit();

                     
             }
          
            
    }
}