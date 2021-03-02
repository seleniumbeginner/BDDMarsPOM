using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDMarsPOM.pages
{
   public class LoginPageObject
    {
        private IWebDriver _driver;
        public LoginPageObject(IWebDriver driver )
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtemail { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtpassword { get; set; }


        [FindsBy(How = How.XPath  , Using = "//div[@autocomplete='on']//div//button")]
        public IWebElement btnlogin { get; set; }

        public ProfilePageObject  Login(string email, string password)
        {
            txtemail.SendKeys(email);
            txtpassword.SendKeys(password);
            btnlogin.Click();
            return new ProfilePageObject(_driver);

        }
       

    }
}
