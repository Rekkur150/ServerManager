using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    class ProcessInteractionAction : Action
    {

        ApplicationManager app;
        string command;

        public ProcessInteractionAction(ApplicationManager applicationManager, string Command)
        {
            app = applicationManager;
            command = Command;
        }

        public override bool Execute()
        {
            app.Run(command);

            return true;
        }

    }
}
