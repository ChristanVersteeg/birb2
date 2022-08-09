using System;
using System.Collections.Generic;
using System.Text;
using BaseProject.Engine;

namespace BaseProject.Engine
{
    class TimerList : Timer
    {
        //Adds the new Timers.
        public TimerList()
        {
            timer1 = new Timer();
            this.Add(timer1);

            timer2 = new Timer();
            this.Add(timer2);

            timer3 = new Timer();
            this.Add(timer3);

            timer4 = new Timer();
            this.Add(timer4);

            timer5 = new Timer();
            this.Add(timer5);
        }
    }
}
