using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateIB : State
    {
        public StateIB(StateMachine sm) : base(sm)
        {
            Name = "IB";
        }

        public override void EnterState()
        {
            base.EnterState();
        }

        public override void ExitState()
        {
            base.ExitState();
        }

        public override void ProcessInput(InPutEnum input)
        {
            base.ProcessInput(input);
            switch (input)
            {
                    case InPutEnum.InputE:
                        sm.EndMachine();
                        break;
                    case InPutEnum.InPutA:
                    case InPutEnum.InputIA:
                        TransferToBA();
                        break;
                    case InPutEnum.InputB:
                    case InPutEnum.InputIB:
                        Console.WriteLine($"Receive B/IB, remain in {Name} state.");
                        break;
                default:
                    Console.WriteLine("Input not recgonize, ignore...");
                    break;
            }
        }

        private void TransferToBA()
        {
            sm.SetState(sm.StateInstance.StateBA);
        }
    }
}
