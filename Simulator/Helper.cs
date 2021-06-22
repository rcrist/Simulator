using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class Helper
    {
        public static void PrintRegister(string reg)
        {
            Debug.WriteLine("Reg: " + reg);
        }

        // Convert bool[] to byte
        public static byte ConvertBoolArrayToByte(bool[] arr)
        {
            byte val = 0;
            foreach (bool b in arr)
            {
                val <<= 1;
                if (b) val |= 1;
            }
            return val;
        }

        // Convert byte to bool[]
        public static bool[] Byte2boolArray(byte byteNum)
        {
            //Debug.WriteLine("byte2boolArray called");
            char pad = '0';

            // First convert byte to string base 2
            bool[] result = new bool[8] { false, false, false, false, false, false, false, false };
            string binary = Convert.ToString(byteNum, 2);
            binary = binary.PadLeft(8, pad);
            // Debug.WriteLine("binary = " + binary);
            bool[] temp = binary.Select(c => c == '1').ToArray(); // Uses Linq
            for (int i = 0; i < temp.Length; i++)
                result[i] = temp[i];
            return result; // Must return an 8-bit bool array
        }

        // Convert byte to 4-Bit bool[]
        public static bool[] Byte2boolArray4Bit(byte byteNum)
        {
            //Debug.WriteLine("byte2boolArray called");
            char pad = '0';

            // First convert byte to string base 2
            bool[] result = new bool[4] { false, false, false, false };
            string binary = Convert.ToString(byteNum, 2);
            binary = binary.PadLeft(4, pad);
            // Debug.WriteLine("binary = " + binary);
            bool[] temp = binary.Select(c => c == '1').ToArray(); // Uses Linq
            for (int i = 0; i < 4; i++)
                result[i] = temp[i];
            return result; // Must return an 8-bit bool array
        }
    }
}

