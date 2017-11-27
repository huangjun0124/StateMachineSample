using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input command:{A, IA, B, IB, E} to run StateMachine...");
                StateMachine sm = new StateMachine();
                while (!sm.Terminated)
                {
                    string read = Console.ReadLine();
                    InPutEnum cmd = EnumEncoder.Encode(read);
                    sm.ProcessInput(cmd);
                }
                PrintElapseTime(sm.StateInstance.StateIni);
                PrintElapseTime(sm.StateInstance.StateBA);
                PrintElapseTime(sm.StateInstance.StateIA);
                PrintElapseTime(sm.StateInstance.StateIB);
                PrintElapseTime(sm.StateInstance.StateAB);

                string readC = Console.ReadLine();
                if (readC == "EXIT")
                    break;
            }
            

        }


        static void PrintElapseTime(State state)
        {
            Console.WriteLine($"Stay in {state.Name} for {Math.Round(state.ElapseTime/1000)} Seconds.");
        }
       
    }
}
