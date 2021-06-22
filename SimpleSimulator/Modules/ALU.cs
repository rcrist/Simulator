using System;

namespace BreadboardSimulator.Modules
{
    class ALU
    {
        public static string RegData = "00000000";

        public Binary ALUMath(bool sub)
        {
            Binary result;
            Binary bin1 = A_Register.RegData;
            Binary bin2 = B_Register.RegData;

            if(!sub)
                result = bin1 + bin2;
            else
                result = bin1 - bin2;

            Binary.PrintBinary(result);
            return result;
        }
    }
}
