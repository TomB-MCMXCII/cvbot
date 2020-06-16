
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
        public void launchDriver()
        {
            driver = new ChromeDriver();  
            driver.Navigate().GoToUrl("https://www.cv.lv/darba-sludinajumi/informacijas-tehnologijas?sort=inserted&dir=desc");
            var advertisements = driver.FindElement(By.ClassName("cvo_module_offer"));
            GetAdvertisements(advertisements);
        }
        public void GetAdvertisements(IWebElement webElements)
        {
            var t = webElements.Text;
        }
    }
}
