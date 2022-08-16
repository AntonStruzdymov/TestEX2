using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using TestEX2.PageObjects.Gmail;
using TestEX2.PageObjects.Yandex;

namespace TestEX2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var yandexLogin = "accfortestingas";
            var yandexPassword = "02136954Aa";
            var mailRuLogin = "accfortestingas";
            var mailRuPassword = "02136954Aa";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://yandex.by/");
            YandexMainPageObject YandexMainPage = new YandexMainPageObject(driver);
            YandexMainPage.WantToLogIn();
            YandexLoginPageObject YandexLoginPage = new YandexLoginPageObject(driver);
            YandexLoginPage.LogIn(yandexLogin, yandexPassword);
            YandexMainPage.OpenMail();
            YandexMailPageObject mailList = new YandexMailPageObject(driver);
            mailList.WriteLetter();
            YandexLetterPageObject mailLetter = new YandexLetterPageObject(driver);
            mailLetter.SendLetter("accfortestingas@mail.ru", "test letter", "Hello World!");
            driver.Navigate().GoToUrl("https://mail.ru/");
            MailRuMainPageObject MailRuMainPage = new MailRuMainPageObject(driver);
            MailRuMainPage.WantToLogIn();
            MailRuLoginPageObject MailRuLoginPage = new MailRuLoginPageObject(driver);
            MailRuLoginPage.LogIn(mailRuLogin, mailRuPassword);
            

        }
    }
}