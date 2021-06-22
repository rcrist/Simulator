using SimpleSimulator;
using System;

namespace BreadboardSimulator.Modules
{
    class ProgramCounter
    {
        public static string RegData = "0000";
        readonly static char pad = '0';

        public static void IncrementCount()
        {
            Binary result;
            string strResult;
            Binary bin1 = ProgramCounter.RegData;
            Binary bin2 = new Binary(1);
            Binary bin0 = new Binary(0);

            result = bin1 + bin2;
            if ((int)result > 15) result = bin0;
            strResult = Convert.ToString((int)result, 2);
            strResult = strResult.PadLeft(4, pad);
            ProgramCounter.RegData = strResult;
        }

        public static void JumpToCount()
        {
            RegData = MainBus.RegData.Substring(4);
        }

        public static void CountToBus()
        {
            string temp = "0000";
            MainBus.RegData = temp + RegData;
        }
    }
}
