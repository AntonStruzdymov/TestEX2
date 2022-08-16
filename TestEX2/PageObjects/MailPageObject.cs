using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects
{
    public class MailPageObject
    {
        private IWebDriver _werDriver;
        public By WriteLetterButton;

        public MailPageObject(IWebDriver driver)
        {
            _werDriver = driver;
        }

        public void WriteLetter()
        {
            _werDriver.FindElement(WriteLetterButton).Click();
        }
    }
}
