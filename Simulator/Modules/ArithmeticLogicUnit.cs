using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Modules
{
    class ArithmeticLogicUnit
    {
        public static bool[] aluData = new bool[8] { false, false, false, false, false, false, false, false };

        public void SetDataValue(bool[] data)
        {
            aluData = data;
        }
    }
}
