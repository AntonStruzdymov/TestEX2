using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2.PageObjects.Yandex
{
    public class YandexLetterPageObject : LetterPageObject
    {
        private readonly By address = By.CssSelector("div[title='Кому']");
        private readonly By subj = By.CssSelector("input[name='subject']");
        private readonly By letterText = By.Id("cke_1_contents");
        private readonly By sendButton = By.XPath("//div/div[2]/div/div[1]/div[1]/div[2]/div/div[1]/div[1]/button");

        public YandexLetterPageObject(IWebDriver driver)
        {
            base.destination = address;
            base.subject = subj;
            base.writeField = letterText;
            base.send = sendButton;
        }
    }
}
