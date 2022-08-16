using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Gmail
{
    public class YandexLoginPageObject : LoginPageObject
    {
        private readonly By loginField = By.Name("login");
        private readonly By submitLogin = By.Id("passp:sign-in");
        private readonly By passField = By.Name("passwd");
        private readonly By submitPass = By.Id("passp:sign-in");

        public YandexLoginPageObject(IWebDriver driver) : base(driver)
        {
            base.loginfield = loginField;
            base.submitlogin = submitLogin;
            base.passwordfield = passField;
            base.submitPassword = submitPass;
        }
    }
}
