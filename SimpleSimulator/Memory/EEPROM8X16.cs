using System;

namespace BreadboardSimulator.Memory
{
    class EEPROM8X16
    {
        public static string[] mem = new string[16];  // Model as 16 string array

        public EEPROM8X16()
        {
            // Set program data to add two numbers and outpu sum on 7-segment display
            mem[0] = "00011110";  // LDA 14 // 0001 1110  // Dec 30
            mem[1] = "00101111";  // ADD    // 0001 1111  // Dec 31
            mem[2] = "11100000";  // OUT    // 1110 0000  // Dec 224
            
            // mem[3] to mem[13] default to "00000000" // Dec 0
            for (int i = 3; i < 14; i++)
                mem[i] = "00000000";

            // Set data portion of memory
            mem[14] = "00011100"; // A Register data // Dec 28
            mem[15] = "00001110"; // B Register data // Dec 14
                                  // Note that sum is 28 + 14 = 42 decimal
        }
    }
}