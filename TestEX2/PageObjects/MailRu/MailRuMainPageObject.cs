using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Gmail
{
    public class MailRuMainPageObject : MainPageObject
    {
        private readonly By MailloginButton = By.XPath("//button[contains(text(),'Войти')]");
        public MailRuMainPageObject(IWebDriver driver) : base(driver)
        {
            base.loginButton = MailloginButton;
        }
        

    }
}
