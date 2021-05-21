using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    class Action
    {

        public event EventHandler Exected;

        public void Execute()
        {
            //await Task.Run(action);
            action();
        }

        protected virtual void action()
        {
            OnExecuted(new EventArgs());
        }

        protected virtual void OnExecuted(EventArgs e)
        {
            if (Exected != null) Exected(this, e);
        }
    }
}
