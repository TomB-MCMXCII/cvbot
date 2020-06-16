using cvbot.IBotService;
using System;

namespace cvbot.Controller
{
    public class BotController
    {
        private ICvBotService cvBotService;
        public BotController() { }
        public BotController(ICvBotService cvBotService)
        {
            this.cvBotService = cvBotService;
        }
        public void Start()
        {
            cvBotService.StartBrowser();
        }
    }
}
