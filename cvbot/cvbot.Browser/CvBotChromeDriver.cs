
using cvbot.IBotWebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace cvbot.Browser
{
    public class CvBotChromeDriver : ICvBotWebDriver
    {
        public void launchDriver()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                
                driver.Navigate().GoToUrl("https://www.google.com/ncr");
               
            }
        }
    }
}
