using BreadboardSimulator.Memory;
using BreadboardSimulator.Modules;
using System;
using System.Diagnostics;

namespace BreadboardSimulator
{
    class ProgramControlUnit
    {
        readonly EEPROM16X256 eep = new EEPROM16X256();
        public string CountData = "000";
        public string InstData = "0000";
        public string SignalData = "0000000000000000";

         // PCU signal variables
        public bool AI = false;
        public bool AO = false;
        public bool BI = false;
        public bool BO = false;
        public bool SUB = false;
        public bool EO = false;
        public bool MI = false;
        public bool RI = false;
        public bool RO = false;
        public bool II = false;
        public bool IO = false;
        public bool OI = false;
        public bool CE = false;
        public bool CO = false;
        public bool JMP = false;
        public bool HLT = false;

        public bool BUS = false;

        public delegate void ChangeEvent(bool bit); // Change event delegate

        // Combinational logic that translates 8-bit address to Program Control Unit signals
        // I/O   0  1  2  3  4  5  6  7     8  9  10 11 12 13 14 15
        //      HLT MI RI RO IO II AI AO    EO SU BI OI CE CO J  BO
        //
        // Address = Instruction (4) + Step (3), Step is a 3-bit counter but count can reset after count = 5

        // Main PCU methods for PCU Counter, Read EEPROM, process PCU signals
        public void ProcessInstruction()
        {
            // Assume the PCU count starts at 0
            GetNextInstruction();
            ReadEEPROM();
            ResetSignals();
            SetSignals();
            IncrementCount();
        }

        // Increment PCU 3-Bit
        public void IncrementCount()
        {
            char pad = '0';
            Binary result;
            string strResult;
            Binary bin1 = CountData;
            Binary bin2 = new Binary(1);
            Binary bin0 = new Binary(0);

            result = bin1 + bin2;
            if ((int)result > 6) result = bin0;
            strResult = Convert.ToString((int)result, 2);
            strResult = strResult.PadLeft(3, pad);
            CountData = strResult;
            Debug.WriteLine("PCU Count: " + CountData);
        }

        public void GetNextInstruction()
        {
            // Read the instruction from the instruction register bits 4-7
            InstData = InstRegister.RegData.Substring(0, 4);
            //Debug.WriteLine("InstData: " + InstData);
        }

        public void ReadEEPROM()
        {
            // Create the EEPROM address
            string eepAddr = InstData + CountData;
            int intAddr = Convert.ToInt32(eepAddr, 2);
            SignalData = eep.GetData(intAddr);
            Debug.WriteLine("Addr: " + eepAddr + "  Signal Data: " + SignalData);
        }

        public void ResetSignals()
        {
            // I/O   0  1  2  3  4  5  6  7     8  9  10 11 12 13 14 15
            //      HLT MI RI RO IO II AI AO    EO SU BI OI CE CO J  BO

            if (HLT)
                ToggleHLT();
            if (MI)
                ToggleMI();
            if (RI)
                ToggleRI();
            if (RO)
                ToggleRO();
            if (IO)
                ToggleIO();
            if (II)
                ToggleII();
            if (AI)
                ToggleAI();
            if (AO)
                ToggleAO();

            if (EO)
                ToggleEO();
            if (SUB)
                ToggleSUB();
            if (BI)
                ToggleBI();
            if (OI)
                ToggleOI();
            if (CE)
                ToggleCE();
            if (CO)
                ToggleCO();
            if (JMP)
                ToggleJMP();
            if (BO)
                ToggleBO();
        }

        public void SetSignals()
        {
            // I/O   0  1  2  3  4  5  6  7     8  9  10 11 12 13 14 15
            //      HLT MI RI RO IO II AI AO    EO SU BI OI CE CO J  BO
            Debug.WriteLine("Signals: " + SignalData.Substring(0, 8) + " " + SignalData.Substring(8));

            if (SignalData[0] == '1')
                ToggleHLT();
            if (SignalData[1] == '1')
                ToggleMI();
            if (SignalData[2] == '1')
                ToggleRI();
            if (SignalData[3] == '1')
            {
                ToggleRO();
                Debug.WriteLine("RO event came back");
            }
            if (SignalData[4] == '1')
                ToggleIO();
            if (SignalData[5] == '1')
                ToggleII();
            if (SignalData[6] == '1')
                ToggleAI();
            if (SignalData[7] == '1')
                ToggleAO();

            if (SignalData[8] == '1')
                ToggleEO();
            if (SignalData[9] == '1')
                ToggleSUB();
            if (SignalData[10] == '1')
                ToggleBI();
            if (SignalData[11] == '1')
                ToggleOI();
            if (SignalData[12] == '1')
                ToggleCE();
            if (SignalData[13] == '1')
                ToggleCO();
            if (SignalData[14] == '1')
                ToggleJMP();
            if (SignalData[15] == '1')
                ToggleBO();
        }

        // ************************** Change Event Methods **************************
        // Publish AI change event
        public static event ChangeEvent AIchangeEvent;  // AI change event variable
        public void ToggleAI()
        {
            AI = !AI;
            AIChanged();
        }

        private void AIChanged()
        {
            AIchangeEvent?.Invoke(AI);
        }

        // Publish AO change event
        public static event ChangeEvent AOchangeEvent;  // AI change event variable
        public void ToggleAO()
        {
            AO = !AO;
            AOChanged();
        }

        private void AOChanged()
        {
            AOchangeEvent?.Invoke(AO);
        }

        // Publish BI change event
        public static event ChangeEvent BIchangeEvent;  // AI change event variable
        public void ToggleBI()
        {
            BI = !BI;
            BIChanged();
        }

        private void BIChanged()
        {
            BIchangeEvent?.Invoke(BI);
        }

        // Publish BO change event
        public static event ChangeEvent BOchangeEvent;  // AI change event variable
        public void ToggleBO()
        {
            BO = !BO;
            BOChanged();
        }

        private void BOChanged()
        {
            BOchangeEvent?.Invoke(BO);
        }

        // Publish SUB change event
        public static event ChangeEvent SUBchangeEvent;  // AI change event variable
        public void ToggleSUB()
        {
            SUB = !SUB;
            SUBChanged();
        }

        private void SUBChanged()
        {
            SUBchangeEvent?.Invoke(SUB);
        }

        // Publish EO change event
        public static event ChangeEvent EOchangeEvent;  // AI change event variable
        public void ToggleEO()
        {
            EO = !EO;
            EOChanged();
        }

        private void EOChanged()
        {
            EOchangeEvent?.Invoke(EO);
        }

        // Publish BUS change event
        public static event ChangeEvent BUSchangeEvent;  // AI change event variable
        public void ToggleBUS()
        {
            BUS = !BUS;
            BUSChanged();
        }

        private void BUSChanged()
        {
            BUSchangeEvent?.Invoke(BUS);
        }

        // Publish MI change event
        public static event ChangeEvent MIchangeEvent;  // AI change event variable
        public void ToggleMI()
        {
            MI = !MI;
            MIChanged();
        }

        private void MIChanged()
        {
            MIchangeEvent?.Invoke(MI);
        }

        // Publish RI change event
        public static event ChangeEvent RIchangeEvent;  // AI change event variable
        public void ToggleRI()
        {
            RI = !RI;
            RIChanged();
        }

        private void RIChanged()
        {
            RIchangeEvent?.Invoke(RI);
        }

        // Publish RO change event
        public static event ChangeEvent ROchangeEvent;  // AI change event variable
        public void ToggleRO()
        {
            RO = !RO;
            ROChanged();
        }

        private void ROChanged()
        {
            ROchangeEvent?.Invoke(RO);
        }

        // Publish II change event
        public static event ChangeEvent IIchangeEvent;  // AI change event variable
        public void ToggleII()
        {
            II = !II;
            IIChanged();
        }

        private void IIChanged()
        {
            IIchangeEvent?.Invoke(II);
        }

        // Publish IO change event
        public static event ChangeEvent IOchangeEvent;  // AI change event variable
        public void ToggleIO()
        {
            IO = !IO;
            IOChanged();
        }

        private void IOChanged()
        {
            IOchangeEvent?.Invoke(IO);
        }

        // Publish OI change event
        public static event ChangeEvent OIchangeEvent;  // AI change event variable
        public void ToggleOI()
        {
            OI = !OI;
            OIChanged();
        }

        private void OIChanged()
        {
            OIchangeEvent?.Invoke(OI);
        }

        // Publish CE change event
        public static event ChangeEvent CEchangeEvent;  // AI change event variable
        public void ToggleCE()
        {
            CE = !CE;
            CEChanged();
        }

        private void CEChanged()
        {
            CEchangeEvent?.Invoke(CE);
        }

        // Publish CO change event
        public static event ChangeEvent COchangeEvent;
        public void ToggleCO()
        {
            CO = !CO;
            COChanged();
        }

        private void COChanged()
        {
            COchangeEvent?.Invoke(CO);
        }

        // Publish JMP change event
        public static event ChangeEvent JMPchangeEvent; 
        public void ToggleJMP()
        {
            JMP = !JMP;
            JMPChanged();
        }

        private void JMPChanged()
        {
            JMPchangeEvent?.Invoke(JMP);
        }

        // Publish HLT change event
        public static event ChangeEvent HLTchangeEvent;
        public void ToggleHLT()
        {
            HLT = !HLT;
            HLTChanged();
        }

        private void HLTChanged()
        {
            HLTchangeEvent?.Invoke(HLT);
        }
    }
}
