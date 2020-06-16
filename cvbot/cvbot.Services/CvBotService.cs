using cvbot.IBotWebDriver;
using System;

namespace cvbot.Services
{
    public class CvBotService
    {
        public CvBotService(ICvBotWebDriver cvBotWebDriver)
        {
            this.cvBotWebDriver = cvBotWebDriver;
            StartBrowser();
        }

        private readonly ICvBotWebDriver cvBotWebDriver;
        public void StartBrowser()
        {
            cvBotWebDriver.launchDriver();
        }
    }
}
