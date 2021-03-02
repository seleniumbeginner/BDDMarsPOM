using BDDMarsPOM.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDMarsPOM.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        IWebDriver _driver;

        
                 
        [Given(@"User press Sign In button and  Navigate to the Login Page")]
        public void GivenUserPressSignInButtonAndNavigateToTheLoginPage()
        {
            _driver = new ChromeDriver();

            _driver.Url = "http://localhost:5000/Home";
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
                //  _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
               _driver.FindElement(By.LinkText("Sign In")).Click();

        }
         
        [When(@"User Login with Email '(.*)' and Password '(.*)'")]
        public void WhenUserLoginWithEmailAndPassword(string email, string password)
        {
           LoginPageObject LpO= new LoginPageObject (_driver);
           LpO .Login(email, password);

        }


        [Then(@"User can see logout button")]
        public void ThenUserCanSeeLogoutButton()
        {
            ProfilePageObject PpO = new ProfilePageObject(_driver);
            PpO.IsLogOutDisplayed();

        }

        //[Given(@"User click the Share skill button")]
        //public void GivenUserClickTheShareSkillButton()
        //{
        //    ProfilePageObject PpO = new ProfilePageObject(_driver);
           
        //    PpO.presskillshare();
        //}


        
        //[Given(@"User should be able to fill all the details")]
        //public void GivenUserShouldBeAbleToFillAllTheDetails()
        //{
            
        //}



        

    }

}
