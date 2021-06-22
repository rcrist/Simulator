using System;
using System.Diagnostics;

namespace Assembler
{
    class Assembler
    {
        // Assembler specifications
        // Input program written in OpCodes
        // Output program EEPROM binary data
        // Test against the 8-Bit Breadboard Computer Simulator

        public string[] OpCodes = new string[16];  // Assume eeprom with 16 bytes maximum
        public string[] mem = new string[16];

        static void Main()
        {
            Assembler a = new Assembler();
            a.InitMem();
            a.LoadProgram();
            a.AssembleProgram();
            a.LoadDataMemory();
            a.PrintData();
        }

        void InitMem()
        {
            for (int i = 0; i < 16; i++)
            {
                mem[i] = "00000000";
            }
        }

        void LoadProgram()
        {
            // Program to add two numbers and display the result
            OpCodes[0] = "LDA 14";
            OpCodes[1] = "ADD 15";
            OpCodes[2] = "OUT";
            OpCodes[14] = "00011100"; // 28 dec = 0x1C hex
            OpCodes[15] = "00001111"; // 14 dec = 0x0E hex
        }

        void AssembleProgram()
        {
            for (int i = 0; i < 10; i++) // Loop through program memory (< 10)
            {
                if (OpCodes[i] == null) continue;
                if (OpCodes[i].Substring(0, 3) == "LDA")
                {
                    ProcessLDA(i);
                }
                if (OpCodes[i].Substring(0, 3) == "ADD")
                {
                    ProcessADD(i);
                }
                if (OpCodes[i].Substring(0, 3) == "OUT")
                    ProcessOUT(i);
            }
        }

        void ProcessLDA(int i)
        {
            string oc = "0000";
            int intArg = Convert.ToInt32(OpCodes[i][4..]);
            mem[i] = oc + Convert.ToString(intArg, 2);
        }

        void ProcessADD(int i)
        {
            string oc = "0001";
            int intArg = Convert.ToInt32(OpCodes[i][4..]);
            mem[i] = oc + Convert.ToString(intArg, 2);
        }

        void ProcessOUT(int i)
        {
            mem[i] = "00100000";
        }

        void LoadDataMemory()
        {
            // Load data memory (> 9)
            mem[14] = "00011100"; // 28 dec = 0x1C hex
            mem[15] = "00001111"; // 14 dec = 0x0E hex
        }

        void PrintData()
        {
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine("OpCode[" + i + "]: " + OpCodes[i] + "  mem[" + i + "]: " + mem[i]);
            }
        }
    }
}
