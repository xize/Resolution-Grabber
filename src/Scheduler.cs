using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution_Grabber.src
{
    class Scheduler
    {

        private static Scheduler s;

        private SchedulerTask task;

        private Scheduler(){ }

        public void startScheduler()
        {
            if(task != null && task.isRepeating())
            {
                stopScheduler();
            }
            this.task = new RepeatingTask();
            this.task.setTick(8000);
            doSchedule();
        }

        public void stopScheduler()
        {
            this.task = null;

        }

        private async void doSchedule()
        {
            await Task.Run(() => thick());
        }

        private long thick()
        {
            long index = 0;

            while (task != null)
            {
                if (index == 0)
                {
                    task.run();
                } else if(index == task.getTick())
                {
                    task.run();
                    task.setTick(task.getTick()+index);
                }
                index++;
            }
            return index;
        }

        public static Scheduler getScheduler()
        {
            if(s == null)
            {
                s = new Scheduler();
            }
            return s;
        }
    }
}
