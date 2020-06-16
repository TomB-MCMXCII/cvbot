using cvbot.Common;
using System;

namespace cvbot.console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting browser");
            new IoCContainer();
        }
    }
}
