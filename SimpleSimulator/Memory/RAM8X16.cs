using System;

namespace BreadboardSimulator.Memory
{
    public class RAM8X16
    {
        // Define string array of 16 rows x 8 bits
        readonly string[] mem = new string[16]; // Model as 16 string array

        public void SetData(int addr, string value)
        {
            mem[addr] = value;
        }

        public string GetData(int addr)
        {
            string result = mem[addr];
            return result;
        }
    }
}
