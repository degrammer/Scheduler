using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Degrammer.Scheduler;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleManager.CurrentConsole = new ConsoleLog();
            //Job test simply writes the current date to the console, you can create more complex recurrent tasks ;)
            //Run this program, and wait 1 minute
            Scheduler.ScheduleTasks(new JobTest(), 1);
            Console.ReadKey();
        }
    }
}
