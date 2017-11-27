using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class StateIA : State
    {
        public StateIA(StateMachine sm) : base(sm)
        {
            Name = "IA";
        }

        public override void ProcessInput(InPutEnum input)
        {
            switch (input)
            {
                    case InPutEnum.InPutA:
                    case InPutEnum.InputIA:
                    Console.WriteLine($"Receive A/IA, remain in {Name} state.");
                        break;
                    case InPutEnum.InputB:
                        TransferToAB();
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

        private void TransferToAB()
        {
            sm.SetState(sm.StateInstance.StateAB);
        }

        private void TransferToIB()
        {
            sm.SetState(sm.StateInstance.StateIB);
        }
    }
}
