using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    class Proceedure
    {
        int CurrentAction = 0;
        List<Action> Actions = new List<Action>();

        public Proceedure() { }
        public Proceedure(List<Action> actions)
        {
            Actions = actions;
        }

        public void AddAction(Action action)
        {
            Actions.Add(action);
        }

        public void RemoveAction(Action action)
        {
            Actions.Remove(action);
        }

        public void Execute()
        {
            CurrentAction = 0;
            ExecuteAction(0);
        }

        public void ExecuteAction(int actionIndex)
        {
            if (actionIndex >= Actions.Count)
                return;

            Actions[actionIndex].Exected += new EventHandler((object sender, EventArgs e) =>
            {
                CurrentAction++;
                ExecuteAction(CurrentAction);
            });

            Actions[actionIndex].Execute();

        }

    }
}
