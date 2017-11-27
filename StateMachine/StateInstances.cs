using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateInstances
    {
        public StateInstances(StateMachine sm)
        {
            StateIB = new StateIB(sm);
            StateBA = new StateBA(sm);
            StateAB = new StateAB(sm);
            StateIA = new StateIA(sm);
            StateIni = new InitialState(sm);
        }

        public State StateBA { get; private set; }
        public State StateIB { get; private set; }
        public State StateAB { get; private set; }
        public State StateIA { get; private set; }
        public State StateIni { get; private set; }

    }
}
