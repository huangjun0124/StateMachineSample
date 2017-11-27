using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class InitialState : State
    {
        public InitialState(StateMachine sm) : base(sm)
        {
            Name = "Initial";
        }

        public override void ProcessInput(InPutEnum input)
        {
            base.ProcessInput(input);
            switch (input)
            {
                    case InPutEnum.InPutA:
                    case InPutEnum.InputIA:
                        TransferToIA();
                        break;
                    case InPutEnum.InputB:
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
