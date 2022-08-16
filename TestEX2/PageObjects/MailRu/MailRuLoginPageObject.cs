using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Gmail
{
    public class MailRuLoginPageObject : LoginPageObject
    {
        private readonly By loginField = By.Name("username");
        private readonly By submitLogin = By.CssSelector("button[type='submit']");
        private readonly By passField = By.Name("password");
        private readonly By submitPass = By.CssSelector("button[type='submit']");
        private readonly By frame = By.XPath("//div/iframe");

        public MailRuLoginPageObject(IWebDriver driver) : base(driver)
        {
            base.loginfield = loginField;
            base.submitlogin = submitLogin;
            base.passwordfield = passField;
            base.submitPassword = submitPass;
            
        }
        public override MainPageObject LogIn(string login, string password)
        {
            base.SwitchFrame(frame);
            return base.LogIn(login, password);
        }
    }
}
