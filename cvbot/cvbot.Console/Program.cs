using System;

namespace cvbot.console
{
    public class Program
    {
        public Program(ICvBotWebDriver cvBotWebDriver)
        {
            this.cvBotWebDriver = cvBotWebDriver;
        }

        private readonly ICvBotWebDriver cvBotWebDriver;
        static void Main(string[] args)
        {
            Console.WriteLine("Starting browser");
        }
    }
}
