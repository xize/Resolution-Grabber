using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution_Grabber.src
{
    abstract class SchedulerTask
    {

        private int thick = 0;

        public abstract void run();

        public abstract void cancel();

        public abstract Boolean isRepeating();

        public void setTick(int thick)
        {
            this.thick = thick;
        }

        public int getTick()
        {
            return thick;
        }
    }
}
