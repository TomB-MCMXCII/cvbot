
using cvbot.IBotWebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cvbot.Browser
{
    public class CvBotChromeDriver : ICvBotWebDriver
    {
        private IWebDriver driver;

       

        public void Launch()
        {
            driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.cv.lv/darba-sludinajumi/informacijas-tehnologijas?sort=inserted&dir=desc");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var advertisements = driver.FindElements(By.ClassName("cvo_module_offer"));
            ParseAdvertisements(advertisements);
        }
        public void (ReadOnlyCollection<IWebElement> webElements)
        {
           
                var toclick = webElements[5].FindElement(By.ClassName("offer_primary_info"));
                toclick.FindElement(By.TagName("a")).Click();
            
        }
    }
}
