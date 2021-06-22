using System;
using System.Diagnostics;
using System.Windows.Forms;
using ctlDigitalLib;
using DmitryBrant.CustomControls;
using BreadboardSimulator.Memory;
using BreadboardSimulator.Modules;
using BreadboardSimulator.UI;
using BreadboardSimulator;

namespace SimpleSimulator
{
    public partial class MainForm : Form
    {
        readonly Clock myClk = new Clock();
        readonly ProgramControlUnit pcu = new ProgramControlUnit();
        readonly ALU alu = new ALU();
        readonly RAM ram = new RAM();
        readonly EEPROM8X16 eep = new EEPROM8X16();

        readonly char pad = '0';
        int aluResult = 0;
        string result = "00000000";
        readonly SevenSegment[] sevSeg;

         public MainForm()
        {
            InitializeComponent();

            lblNotCLK.Text = "C\u035EL\u035EK";

            myClk.SetTimer();
            sevSeg = new SevenSegment[4] { sevSeg0, sevSeg1, sevSeg2, sevSeg3 };

            ProgramControlUnit.AIchangeEvent += AIChanged;
            ProgramControlUnit.AOchangeEvent += AOChanged;
            ProgramControlUnit.BIchangeEvent += BIChanged;
            ProgramControlUnit.SUBchangeEvent += SUBChanged;
            ProgramControlUnit.EOchangeEvent += EOChanged;
            ProgramControlUnit.BUSchangeEvent += BUSChanged;
            ProgramControlUnit.MIchangeEvent += MIChanged;
            ProgramControlUnit.RIchangeEvent += RIChanged;
            ProgramControlUnit.ROchangeEvent += ROChanged;
            ProgramControlUnit.IIchangeEvent += IIChanged;
            ProgramControlUnit.IOchangeEvent += IOChanged;
            ProgramControlUnit.OIchangeEvent += OIChanged;
            ProgramControlUnit.CEchangeEvent += CEChanged;
            ProgramControlUnit.COchangeEvent += COChanged;
            ProgramControlUnit.JMPchangeEvent += JMPChanged;
            ProgramControlUnit.HLTchangeEvent += HLTChanged;

            myClk.ChangeEventCLK += CLKChanged;
            Set4BitRegisterData(LedBarPC, lblPC, ProgramCounter.RegData); // Init PC 4-Bit register so it is yellow

            // Run the bootloader to copy data from program EEPROM to RAM         
            ram.CopyFromEEPROM();

            // Set the CLK to STEP mode
            lblRun.Visible = false;
            lblStep.Visible = true;
            BtnStep.Enabled = true;
            myClk.StopTimer();
        }

        #region Published Event Handlers
        // ************************* Published Event Handlers *************************
        void CLKChanged(bool clk)
        {
            // Change clock LEDs
            CLKled.State = clk;
            NotCLKled.State = !clk;

            // Perform ALU math on every clock cycle
            if(SUBled.State)
                aluResult = (int)alu.ALUMath(true); // false = add, true = subtract
            else
                aluResult = (int)alu.ALUMath(false); // false = add, true = subtract
            result = Convert.ToString(aluResult, 2);
            result = result.PadLeft(8, pad);
            ALU.RegData = result;
            SetRegisterData(LedBarALU, lblALU, ALU.RegData);

            // Process PCU signals on every !clock cycle
            if (NotCLKled.State)
            {
                pcu.ProcessInstruction();
            }

            if (AIled.State && clk)
            {
                A_Register.RegData = MainBus.RegData;
                SetRegisterData(LedBarAreg, lblAreg, A_Register.RegData);
            }
            if (BIled.State && clk)
            {
                B_Register.RegData = MainBus.RegData;
                SetRegisterData(LedBarBreg, lblBreg, B_Register.RegData);
            }
            if (AOled.State && clk)
            {
                MainBus.RegData = A_Register.RegData;
                SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            }
            if (EOled.State && clk)
            {
                MainBus.RegData = ALU.RegData;
                SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            }
            if (CEled.State && clk)
            {
                ProgramCounter.IncrementCount();
                Set4BitRegisterData(LedBarPC, lblPC, ProgramCounter.RegData);
            }
            if (COled.State && clk)
            {
                ProgramCounter.CountToBus();
                SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            }
            if (JMPled.State && clk)
            {
                ProgramCounter.JumpToCount();
                Set4BitRegisterData(LedBarPC, lblPC, ProgramCounter.RegData);
            }
            if (MIled.State && clk)
            {
                MAR.RegData = MainBus.RegData.Substring(4);
                Set4BitRegisterData(LedBarMAR, lblMAR, MAR.RegData);
            }
            if (RIled.State && clk)
            {
                RAM.RegData = MainBus.RegData;
                ram.CopyFromBus();
                SetRegisterData(LedBarRAM, lblRAM, RAM.RegData);
            }
            if (ROled.State && clk)
            {
                ram.CopyToBus();
                SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            }
            if (IIled.State && clk)
            {
                InstRegister.RegData = MainBus.RegData;
                SetInstRegisterData(LedBarIR, lblIR, InstRegister.RegData);
            }
            if (IOled.State && clk)
            {
                MainBus.RegData = InstRegister.RegData;
                SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            }
            if (OIled.State && clk)
            {
                OutRegister.RegData = MainBus.RegData;
                Update7SegmentDisplay();
            }
            if (pcuHLTled.State)
                myClk.StopTimer();
                
        }

        void AIChanged(bool bit)
        {
            AIled.State = bit;
            pcuAIled.State = bit;
        }

        void AOChanged(bool bit)
        {
            AOled.State = bit;
            pcuAOled.State = bit;
        }

        void SUBChanged(bool bit)
        {
            SUBled.State = bit;
            pcuSUBled.State = bit;
        }

        void EOChanged(bool bit)
        {
            EOled.State = bit;
            pcuEOled.State = bit;
        }

        void BIChanged(bool bit)
        {
            BIled.State = bit;
            pcuBIled.State = bit;
        }

        void BUSChanged(bool bit)
        {
            SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
        }

        void MIChanged(bool bit)
        {
            MIled.State = bit;
            pcuMIled.State = bit;
        }

        void RIChanged(bool bit)
        {
            RIled.State = bit;
            pcuRIled.State = bit;
        }

        void ROChanged(bool bit)
        {
            ROled.State = bit;
            pcuROled.State = bit;
        }

        void IIChanged(bool bit)
        {
            IIled.State = bit;
            pcuIIled.State = bit;
        }

        void IOChanged(bool bit)
        {
            IOled.State = bit;
            pcuIOled.State = bit;
        }

        void OIChanged(bool bit)
        {
            OIled.State = bit;
            pcuOIled.State = bit;
        }

        void CEChanged(bool bit)
        {
            CEled.State = bit;
            pcuCEled.State = bit;
        }

        void COChanged(bool bit)
        {
            COled.State = bit;
            pcuCOled.State = bit;
        }

        void JMPChanged(bool bit)
        {
            JMPled.State = bit;
            pcuJMPled.State = bit;
        }

        void HLTChanged(bool bit)
        {
            pcuHLTled.State = bit;
        }
        #endregion Published Event Handlers

        private void BtnLoadBus_Click(object sender, EventArgs e)
        {
            String strFive = "00000101";
            SetBusData(strFive);
        }

        private void BtnClrBus_Click(object sender, EventArgs e)
        {
            String strZero = "00000000";
            SetBusData(strZero);
        }

        private void SetBusData(string str)
        {
            MainBus.RegData = str;
            SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
        }

        private void BtnLoadAreg_Click(object sender, EventArgs e)
        {
            A_Register.RegData = MainBus.RegData;
            SetRegisterData(LedBarAreg, lblAreg, A_Register.RegData);
        }

        private void BtnLoadBreg_Click(object sender, EventArgs e)
        {
            B_Register.RegData = MainBus.RegData;
            SetRegisterData(LedBarBreg, lblBreg, B_Register.RegData);
        }

        private void BtnALU_Click(object sender, EventArgs e)
        {
            ALU.RegData = MainBus.RegData;
            SetRegisterData(LedBarALU, lblALU, ALU.RegData);
        }

        private void SetRegisterData(CtlLedBar8Bit ledbar, Label lbl, string data)
        {
            ledbar.barValue = data;
            ledbar.SetLabelColors();
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new MethodInvoker(delegate { lbl.Text = data; }));
            }
            else
                lbl.Text = data;
        }

        private void SetInstRegisterData(CtlLedBarIR ledbar, Label lbl, string data)
        {
            ledbar.barValue = data;
            ledbar.SetLabelColors();
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new MethodInvoker(delegate { lbl.Text = data; }));
            }
            else
                lbl.Text = data;
        }

        private void Set4BitRegisterData(CtlLedBar4Bit ledbar, Label lbl, string data)
        {
            ledbar.BarValue = data;
            ledbar.SetLabelColors();
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new MethodInvoker(delegate { lbl.Text = data; }));
            }
            else
                lbl.Text = data;
        }

        private void BtnTestPanel_Click(object sender, EventArgs e)
        {
            TestPanel tp = new TestPanel();
            tp.Show();
        }

        private void CtlSlideSwtich1_CheckedChanged(object sender, EventArgs e)
        {
            lblRun.Visible = !lblRun.Visible;
            lblStep.Visible = !lblStep.Visible;
            BtnStep.Enabled = !BtnStep.Enabled;

            if (lblStep.Visible)
                myClk.StopTimer();
            else
                myClk.SetTimer();
        }

        private void BtnStep_Click(object sender, EventArgs e)
        {
            myClk.ToggleCLK();
        }

        void Update7SegmentDisplay()
        {
            if (OutRegister.RegData != "00000000")
            {
                int binary = Convert.ToInt32(OutRegister.RegData, 2); // Convert to decimal
                string temp = binary.ToString();
                char[] rtn = new char[temp.Length];
                char c;
                for (int i=0; i < rtn.Length; i++)
                {
                    c = temp[i];
                    rtn[i] = c;
                }
                Array.Reverse(rtn);
                for (int i = 0; i < rtn.Length; i++)
                    sevSeg[i].Value = rtn[i].ToString();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            A_Register.RegData = "00000000";
            SetRegisterData(LedBarAreg, lblAreg, A_Register.RegData);
            B_Register.RegData = "00000000";
            SetRegisterData(LedBarBreg, lblBreg, B_Register.RegData);
            ALU.RegData = "00000000";
            SetRegisterData(LedBarALU, lblALU, ALU.RegData);
            InstRegister.RegData = "00000000";
            SetInstRegisterData(LedBarIR, lblIR, InstRegister.RegData);
            MainBus.RegData = "00000000";
            SetRegisterData(LedBarBus, lblBus, MainBus.RegData);
            MAR.RegData = "0000";
            Set4BitRegisterData(LedBarMAR, lblMAR, MAR.RegData);
            OutRegister.RegData = "00000000";
            Update7SegmentDisplay();
            ProgramCounter.RegData = "0000";
            Set4BitRegisterData(LedBarPC, lblPC, ProgramCounter.RegData);

            RAM.RegData = "00000000";
            SetRegisterData(LedBarRAM, lblRAM, RAM.RegData);
            for (int i = 0; i < 4; i++)
                sevSeg[i].Value = "0";

            pcu.CountData = "000";
            pcu.InstData = "0000";
            pcu.ResetSignals();
        }
    }
}
