using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degrammer.Scheduler
{
    /// <summary>
    /// Author: @degrammer
    /// Description: the purpose of this class it's defining a simple Job or Task to execute.
    /// </summary>
    public abstract class Job
    {
        protected bool isInitialized = false;


        public Job()
        {

        }

        public void RunSingleJob()
        {

            PerformRunJob();
            RecordJobSuccess();

        }

        protected abstract void PerformRunJob();

        protected void RecordJobSuccess()
        {
            //Actualizar el estado del Job
        }
    }
}
