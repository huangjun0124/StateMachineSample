using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
   
    public class State
    {
        protected StateMachine sm;
        protected State(StateMachine m)
        {
            sm = m;
        }

        public string Name { get; protected set; }

        public virtual void ProcessInput(InPutEnum input)
        {
            Console.WriteLine($"State {Name} processing {input}");
        }

        public virtual void EnterState()
        {
            Console.WriteLine($"State {Name} Entred");
            EnterTime = DateTime.Now;
            ExitTime = null;
            ElapseTime = 0;
        }

        public virtual void ExitState()
        {
            Console.WriteLine($"State {Name} Exiting");
            ExitTime = DateTime.Now;
            ElapseTime = ElapseTime +( ExitTime - EnterTime).Value.TotalMilliseconds;
        }

        private DateTime? EnterTime, ExitTime;
        public double ElapseTime = 0;

    }
}
