using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public enum InPutEnum
    {
        InPutA,
        InputIA,
        InputB,
        InputIB,
        InputE,
        Undefined
    }


    class EnumEncoder
    {
        public static InPutEnum Encode(string cmd)
        {
            InPutEnum ret;
            switch (cmd)
            {
                case "IA":
                    ret = InPutEnum.InputIA;
                    break;
                case "A":
                    ret = InPutEnum.InPutA;
                    break;
                case "B":
                    ret = InPutEnum.InputB;
                    break;
                case "E":
                    ret = InPutEnum.InputE;
                    break;
                case "IB":
                    ret = InPutEnum.InputIB;
                    break;
                default:
                    ret = InPutEnum.Undefined;
                    break;
            }
            return ret;
        }
    }
}
