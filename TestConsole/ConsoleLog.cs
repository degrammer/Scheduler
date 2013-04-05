using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Degrammer.Scheduler;

namespace TestConsole
{
    /// <summary>
    /// Author: @degrammer
    /// Description: writes logs in the Console.
    /// </summary>
    public class ConsoleLog:IConsole
    {
        public void WriteLog(string log)
        {
            
            Console.WriteLine(log);
        }
    }
}
