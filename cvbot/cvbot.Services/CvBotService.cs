using cvbot.IBotWebDriver;
using cvbot.IBotService;
using System;

namespace cvbot.Services
{
    public class CvBotService : ICvBotService
    {
        public CvBotService(ICvBotWebDriver cvBotWebDriver)
        {
            this.cvBotWebDriver = cvBotWebDriver;
        }

        private readonly ICvBotWebDriver cvBotWebDriver;
        public void StartBrowser()
        {
            cvBotWebDriver.Launch();
        }
    }
}
