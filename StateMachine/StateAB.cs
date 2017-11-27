using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateAB : State
    {
        public StateAB(StateMachine sm) : base(sm)
        {
            Name = "AB";
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
                    case InPutEnum.InPutA:
                        TransferToBA();
                        break;
                    case InPutEnum.InputB:
                        Console.WriteLine($"Receive B, remain in {Name} state.");
                        break;
                    case InPutEnum.InputIA:
                        TransferToIA();
                        break;
                    case InPutEnum.InputIB:
                        TransferToIB();
                        break;
                    case InPutEnum.InputE:
                        sm.EndMachine();
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

        private void TransferToIA()
        {
            sm.SetState(sm.StateInstance.StateIA);
        }

        private void TransferToIB()
        {
            sm.SetState(sm.StateInstance.StateIB);
        }
    }
}
