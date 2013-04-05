using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Degrammer.Scheduler;

namespace TestConsole
{
    public class JobTest : Job
    {
        public JobTest()
        {
            
            ConsoleManager.CurrentConsole.WriteLog(" . . . starting job");
        }

        protected override void PerformRunJob()
        {
            
            DateTime jobDate = DateTime.Now;
            ConsoleManager.CurrentConsole.WriteLog(string.Format(". . . job done at {0}", jobDate));
        }
    }
}
