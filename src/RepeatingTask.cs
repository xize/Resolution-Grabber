using System;

namespace Resolution_Grabber.src
{
    class RepeatingTask : SchedulerTask
    {

        public override void cancel()
        {
            Scheduler.getScheduler().stopScheduler();
        }

        public override bool isRepeating()
        {
            return true;
        }

        public override void run()
        {
            Console.WriteLine("I'm fired at: " + getTick());
        }

    }
}
