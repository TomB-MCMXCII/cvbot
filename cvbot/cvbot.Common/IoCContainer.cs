using cvbot.Browser;
using cvbot.Controller;
using cvbot.Services;
using System;

namespace cvbot.Common
{
    public class IoCContainer
    {
        public CvBotChromeDriver chromeDriver;
        public CvBotService botService;
        public BotController botController;
        public IoCContainer()
        {
            chromeDriver = new CvBotChromeDriver();
            botService = new CvBotService(chromeDriver);
            botController = new BotController(botService);
        }
    }
}
