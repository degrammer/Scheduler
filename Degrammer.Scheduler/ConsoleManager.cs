using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degrammer.Scheduler
{
    /// <summary>
    /// Author: @degrammer
    /// Description: A simple Console Mechanism
    /// </summary>
    public static class ConsoleManager
    {
        private static IConsole currentConsole;

        public static IConsole CurrentConsole
        {
            get {
                if (ConsoleManager.currentConsole == null)
                {
                    throw new ApplicationException("Oops! Console does not exist yet");
                }
                return ConsoleManager.currentConsole; }
            set { ConsoleManager.currentConsole = value; }
        }


        public static void WriteLog(string log)
        {
            ConsoleManager.CurrentConsole.WriteLog(log);
        }

    }
}
