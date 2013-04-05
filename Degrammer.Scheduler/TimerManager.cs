using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Degrammer.Scheduler
{
    /// <summary>
    /// Author: @degrammer
    /// </summary>
    public class TimerManager
    {
        private double _interval;

        public static bool STOP = false;

        public double Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        private Timer _timerController;

        public Timer TimerController
        {
            get
            {
                if (_timerController == null)
                {
                    _timerController = new Timer();
                    _timerController.AutoReset = true;
                    _timerController.Interval = 60000 * Interval;
                    _timerController.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                }
                return _timerController;
            }
            set { _timerController = value; }
        }

        private Job _jobObject;

        /// <summary>
        /// Create the timer for the job.
        /// </summary>
        /// <param name="jobToExecute">Specific task to execute</param>
        /// <param name="interval">Interval of execution, in minutes</param>
        public TimerManager(Job jobToExecute, double interval)
        {
            this.Interval = interval;
            this._jobObject = jobToExecute;
            this.TimerController.Start();
        }

        public TimerManager()
        { }

        /// <summary>
        /// Executes the task
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void timer_Elapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (STOP == false)
            {
                if (this._jobObject != null)
                {
                    this._jobObject.RunSingleJob();
                }
            }
        }
    }
}
