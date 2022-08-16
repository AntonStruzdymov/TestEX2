using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects
{
    public class LoginPageObject
    {
        private IWebDriver _webDriver;
        public By loginfield;
        public By passwordfield;
        public By submitlogin;
        public By submitPassword;

        public LoginPageObject(IWebDriver driver)
        {
            _webDriver = driver;
        }

        public virtual MainPageObject LogIn(string login, string password)
        {
            _webDriver.FindElement(loginfield).SendKeys(login);
            _webDriver.FindElement(submitlogin).Click();
            _webDriver.FindElement(passwordfield).SendKeys(password);
            _webDriver.FindElement(submitPassword).Click();
            return new MainPageObject(_webDriver);
        }
        public void SwitchFrame(By selector)
        {
            var frame = _webDriver.FindElement(selector);
            _webDriver.SwitchTo().Frame(frame);
        }
    }
}
