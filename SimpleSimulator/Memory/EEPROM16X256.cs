using System;
using System.Diagnostics;

namespace BreadboardSimulator.Memory
{
    // Notional EEPROM with 256 bytes of 16-bits that implements the Program Control Unit logic.
    class EEPROM16X256
    {
        // Define EEPROM data for 16x256 EEPROM = 16 bits x 256 string array
        public static string[] mem = new string[256]; // Model as 256 string array

        public EEPROM16X256()
        {
            // Combinational logic that translates 8-bit address to Program Control Unit signals
            // I/O   0  1  2  3  4  5  6  7     8  9  10 11 12 13 14 15
            //      HLT MI RI RO IO II AI AO    EO SU BI OI CE CO J  BO
            //
            // Address = Instruction (4) + Step (3), Step is a 3-bit counter but count can reset after count = 5

            // Fetch cycle
            mem[0] = "0100000000000100";   // MI CO       // 16388
            mem[1] = "0001010000001000";   // RO II CE    // 5128

            // mem[2] to mem[7] default to 0
            for(int i=2; i<8; i++)
                mem[i] = "0000000000000000";

            // LDA microinstructions
            mem[8]  = "0100000000000100";    // MI CO    // 16388
            mem[9]  = "0001010000001000";    // RO II CE // 5128
            mem[10] = "0100100000000000";    // MI IO    // 18432
            mem[11] = "0001000000000000";    // RO
            mem[12] = "0000001000000000";    // AI

            // mem[13] to mem[15] default to 0
            for (int i = 13; i < 16; i++)
                mem[i] = "0000000000000000";

            // ADD microinstructions
            mem[16] = "0100000000000100";    // MI CO    // 16388
            mem[17] = "0001010000001000";    // RO II CE // 5128
            mem[18] = "0100100000000000";    // MI IO    // 18432
            mem[19] = "0001000000000000";    // RO
            mem[20] = "0000000000100000";    // BI
            mem[21] = "0000000010000000";    // EO
            mem[22] = "0000001000000000";    // AI

            // mem[21] to mem[111] default to 0
            for (int i = 23; i < 112; i++)
                mem[i] = "0000000000000000";

            mem[112] = "0100000000000100";   // MI CO    // 16388
            mem[113] = "0001010000001000";   // RO II CE // 5128
            mem[114] = "0000000100000000";   // AO
            mem[115] = "0000000000010000";   // OI
            mem[116] = "1000000000000000";   // HLT

            // mem[117] to mem[255] default to 0
            for (int i = 117; i < 256; i++)
                mem[i] = "0000000000000000";
        }

        public void SetData(int addr, string value)
        {
            mem[addr] = value;
        }

        public string GetData(int addr)
        {
            string result = mem[addr];
            //Debug.WriteLine("EEPROM Addr: " + addr + "  EEPROM Data: " + result);
            return result;
        }
    }
}
