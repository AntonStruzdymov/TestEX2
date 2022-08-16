using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects
{
    public class LetterPageObject
    {
        private IWebDriver driver;
        public By destination;
        public By subject;
        public By writeField;
        public By send;

        public MailPageObject SendLetter(string address, string subjText, string text)
        {
            driver.FindElement(destination).SendKeys(address);
            driver.FindElement(subject).SendKeys(subjText);
            driver.FindElement(writeField).SendKeys(text);
            driver.FindElement(send).Click();
            return new MailPageObject(driver);
        }
    }
}
