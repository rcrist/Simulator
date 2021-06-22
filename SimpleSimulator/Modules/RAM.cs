using BreadboardSimulator.Memory;
using System;
using System.Diagnostics;

namespace BreadboardSimulator.Modules
{
    class RAM
    {
        public static string RegData = "00000000";
        readonly RAM8X16 ram = new RAM8X16();
        string strAddr;
        int intAddr;

        public void CopyToBus()
        {
            // Set the RAM address from MAR
            strAddr = MAR.RegData;
            intAddr = Convert.ToInt32(strAddr, 2);
            //Debug.WriteLine("strAddr = " + strAddr + " intAddr = " + intAddr);

            RAM.RegData = ram.GetData(intAddr);
            Debug.WriteLine("RAM Addr: " + intAddr + "  RAM Data: " + RAM.RegData);
            MainBus.RegData = RAM.RegData;
        }

        public void CopyFromBus()
        {
            // Set RAM address from MAR
            strAddr = MAR.RegData;
            intAddr = Convert.ToInt32(strAddr, 2);

            // Copy data from the bus to the RAM registers and RAM device
            RAM.RegData = MainBus.RegData;
            ram.SetData(intAddr, RAM.RegData);
        }

        public void CopyFromEEPROM()
        {
            for (int i = 0; i < 16; i++)
            {
                ram.SetData(i, EEPROM8X16.mem[i]);
                //ram.SetData((byte)i, EEPROM8X16.mem[i]);
            }
            //PrintRAMData();
        }

        public void PrintRAMData()
        {
            Debug.WriteLine("RAM data");
            for (int i=0; i<16 ;i++)
            {
                Debug.WriteLine("Addr: " + i + " " + ram.GetData(i));
            }
        }
    }
}
