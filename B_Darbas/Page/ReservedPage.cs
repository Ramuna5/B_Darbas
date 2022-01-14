using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Darbas.Page
{
    class ReservedPage : BasePage
    {
        private const string PageAddress = "https://www.reserved.com/lt/lt/";

        private IWebElement _nameInputField => Driver.FindElement(By.Id("login[username]_id")); //id="login[username]_id"
        private IWebElement _passInputField => Driver.FindElement(By.Id("login[password]_id"));




        public ReservedPage(IWebDriver webdriver) : base(webdriver) { }

        public ReservedPage NavigateDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;
        }

        public void FullNameField(string text)
        {
            _nameInputField.Clear();
            _nameInputField.SendKeys(text);
        }
        
        /*public void ClickButton()
        {
            __clickButton.Click();
        }*/

        //public void 
    }
}
