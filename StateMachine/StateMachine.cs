using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateMachine
    {
        public StateInstances StateInstance;
        public StateMachine()
        {
            StateInstance = new StateInstances(this);
            CurrentState = StateInstance.StateIni;
            CurrentState.EnterState();
        }

        private State CurrentState;

        public bool Terminated { get; private set; }
        public void EndMachine()
        {
            CurrentState.ExitState();
            Console.WriteLine("StateMachine terminated.\n");
            Terminated = true;
        }

        public void ProcessInput(InPutEnum input)
        {
            CurrentState.ProcessInput(input);
        }

        public void SetState(State state)
        {
            CurrentState.ExitState();
            this.CurrentState = state;
            this.CurrentState.EnterState();
        }
    }
}
