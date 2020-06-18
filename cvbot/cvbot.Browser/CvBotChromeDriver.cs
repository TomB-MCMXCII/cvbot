
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
        private string applicationText = "Labdien! Vēlos pieteikties vakancei.2019.gadā izgāju Codelex kursus un pašlaik paralēli mācos tālmācībā par programmētāju.2019.gada beigās sāku strādāt kā programmētājs, diemžēl covid-19 dēl tiku atlaists.Tagad esmu jauna darba meklējumos.Mans GitHub - https://github.com/TomB-MCMXCII";
        private string english = "You have already applied for this position!Save";
        private string latvian = "Jūs jau esat pieteicies šai vakancei!Saglabāt";

        public void Launch()
        {
            driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.cv.lv");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Login();
            FaceBookLogin();
            Thread.Sleep(5000);

            driver.Navigate().GoToUrl("https://www.cv.lv/darba-sludinajumi/informacijas-tehnologijas/q-.Net/q-c/q-javascript/q-typescript?sort=inserted&dir=desc");

            var ads = driver.FindElements(By.ClassName("cvo_module_offer"));
            ClickAdvertisements(ads);
        }
        public void ClickAdvertisements(ReadOnlyCollection<IWebElement> ads)
        {
            foreach (var ad in ads)
            {
                var toclick = ad.FindElement(By.ClassName("offer_primary_info"));
                toclick.FindElement(By.TagName("a")).Click();
                var windowHandles = driver.WindowHandles;
                driver.SwitchTo().Window(windowHandles[1]);
                var gg = driver.FindElement(By.XPath("//*[@id=\"savebuttons\"]")).Text;

                if (driver.FindElement(By.XPath("//*[@id=\"savebuttons\"]")).Text == english || driver.FindElement(By.XPath("//*[@id=\"savebuttons\"]")).Text == latvian)
                {
                    driver.Close();
                    driver.SwitchTo().Window(windowHandles[0]);
                }
                else
                {
                    driver.FindElement(By.XPath("//*[@id=\"savebuttons\"]/button[1]")).Click();
                    driver.FindElement(By.XPath("//*[@id=\"userapplication\"]")).SendKeys(applicationText);
                    driver.FindElement(By.XPath("//*[@id=\"cvselect\"]")).FindElement(By.XPath("//*[@id=\"cvselect\"]/option[2]")).Click();
                    driver.FindElement(By.XPath("//*[@id=\"applyform\"]/form/div[8]/input")).Click();
                    driver.Close();
                    driver.SwitchTo().Window(windowHandles[0]);
                }
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
