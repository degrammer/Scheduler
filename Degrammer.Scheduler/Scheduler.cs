using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Degrammer.Scheduler
{
    /// <summary>
    /// Author: @degrammer
    /// </summary>
    public class Scheduler
    {
        private static Mutex _jobMutex;

        public static Mutex JobMutex
        {
            get
            {
                if (_jobMutex == null)
                {
                    _jobMutex = new Mutex();
                }
                return Scheduler._jobMutex;
            }
            set { Scheduler._jobMutex = value; }
        }



        public static void ScheduleTasks(Job jobToExecute, double interval)
        {

            JobMutex.WaitOne();

            try
            {

                new TimerManager(jobToExecute, interval);

            }
            finally
            {
                JobMutex.ReleaseMutex();
            }

        }
    }
}
