
using cvbot.IBotWebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace cvbot.Browser
{
    public class CvBotChromeDriver : ICvBotWebDriver
    {
        private IWebDriver driver;

        public void Launch()
        {
            driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.cv.lv");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Login();
            FaceBookLogin();
            Thread.Sleep(5000);

            driver.Navigate().GoToUrl("https://www.cv.lv/darba-sludinajumi/informacijas-tehnologijas?sort=inserted&dir=desc");

            var ads = driver.FindElements(By.ClassName("cvo_module_offer"));
            ClickAdvertisements(ads);
        }
        public void ClickAdvertisements(ReadOnlyCollection<IWebElement> ads)
        {
            foreach (var ad in ads)
            {
                var toclick = ad.FindElement(By.ClassName("offer_primary_info"));
                toclick.FindElement(By.TagName("a")).Click();

            }
        }

        public void Login()
        {
            var loginButton = driver.FindElement(By.ClassName("users-login"));
            loginButton.FindElement(By.TagName("a")).Click();
            var socialLogins = driver.FindElement(By.Id("social"));
            socialLogins.FindElement(By.TagName("li")).Click();
        }

        public void FaceBookLogin()
        {
            driver.FindElement(By.Id("email")).SendKeys("25709976");
            driver.FindElement(By.Id("pass")).SendKeys("TBlanks25071992");
            driver.FindElement(By.Id("loginbutton")).Click();
        }

    }
}
