using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;
        public By loginButton;
        public By mailButton;

        public MainPageObject(IWebDriver driver)
        {
            _webDriver = driver;
        }

        public LoginPageObject WantToLogIn()
        {
            _webDriver.FindElement(loginButton).Click();
            return new LoginPageObject(_webDriver);
        }

        public MailPageObject OpenMail()
        {
            _webDriver.FindElement(mailButton).Click();
            return new MailPageObject(_webDriver);
        }
    }
}
