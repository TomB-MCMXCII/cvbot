using cvbot.Common;
using System;

namespace cvbot.console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new IoCContainer();
            var botController = container.botController;
            botController.Start();
            Console.ReadLine();
        }
    }
}
