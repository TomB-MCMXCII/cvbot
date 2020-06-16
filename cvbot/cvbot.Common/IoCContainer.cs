using cvbot.Browser;
using cvbot.Services;
using System;

namespace cvbot.Common
{
    public class IoCContainer
    {
        private CvBotChromeDriver chromeDriver;
        private CvBotService botService;
        public IoCContainer()
        {
            chromeDriver = new CvBotChromeDriver();
            botService = new CvBotService(chromeDriver);
            new CvBotService(chromeDriver);
        }
    }
}
