using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDMarsPOM.pages
{
   public  class ProfilePageObject
    {
        private IWebDriver _driver;
        public ProfilePageObject(IWebDriver driver )
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
       
        [FindsBy(How = How.TagName, Using = "button")]
        protected IWebElement btnLogout { get; set; }

        [FindsBy(How = How.CssSelector   , Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
        protected IWebElement btnShareSkill{ get; set; }


        public void IsLogOutDisplayed()
        {   if (btnLogout.Displayed)
            { Console.WriteLine("YOU are in Profile Page"); }
            else
            { Console.WriteLine("Unsuccessful login"); }
           }        
        public void presskillshare()
        { btnShareSkill.Click();
        }

    }
}
