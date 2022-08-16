using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Gmail
{
    public class YandexMainPageObject : MainPageObject
    {
        private readonly By YandexloginButton = By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/div/a[1]");
        private readonly By OpenMail = By.XPath("/html/body/div[1]/div[1]/div/div[1]/div[1]/div[2]/div[1]/a/div[1]");
        public YandexMainPageObject(IWebDriver driver) : base(driver)
        {
            base.loginButton = YandexloginButton;
            base.mailButton = OpenMail;
        }
        

    }
}
