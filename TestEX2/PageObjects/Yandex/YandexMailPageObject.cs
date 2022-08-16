using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Yandex
{
    public class YandexMailPageObject : MailPageObject
    {
        private readonly By WriteButton = By.XPath("//a[@title='Написать (w,c)']");

        public YandexMailPageObject(IWebDriver driver) : base(driver)
        {
            base.WriteLetterButton = WriteButton;
        }
        
    }
}
