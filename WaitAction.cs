using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    class WaitAction : Action
    {
        int waitDuration;

        public WaitAction(int WaitInMiliseconds)
        {
            waitDuration = WaitInMiliseconds;
        }

        protected override void action()
        {
            Task.Delay(waitDuration);
            base.action();
        }

    }
}
