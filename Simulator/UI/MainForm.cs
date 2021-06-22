using Simulator.Modules;
using Simulator.UI;
using System;
using System.Windows.Forms;

namespace Simulator
{
    public partial class MainForm1 : Form
    {
        readonly B_Register breg = new B_Register();
        readonly ArithmeticLogicUnit alu = new ArithmeticLogicUnit();

        string binary;
        readonly char pad = '0';

        public MainForm1()
        {
            InitializeComponent();

            ProgramControlUnit.AIchangeEvent += AIChanged;
            ProgramControlUnit.AOchangeEvent += AOChanged;
            ProgramControlUnit.BIchangeEvent += BIChanged;
            ProgramControlUnit.SUBchangeEvent += SUBChanged;
            ProgramControlUnit.EOchangeEvent += EOChanged;
        }

        void AIChanged(bool bit)
        {
            AIled.State = bit;
            pcuAILed.State = bit;
        }

        void AOChanged(bool bit)
        {
            AOled.State = bit;
            pcuAOLed.State = bit;
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

        private void AIled_Click(object sender, EventArgs e)
        {
            AIled.State = !AIled.State;
        }

        private void AOled_Click(object sender, EventArgs e)
        {
            AOled.State = !AOled.State;
        }

        private void BtnTestPanel_Click(object sender, EventArgs e)
        {
            TestPanel tp = new TestPanel();
            tp.Show();
        }

        private void BtnLoadBus_Click(object sender, EventArgs e)
        {
            bool[] five = new bool[8] { false, false, false, false, false, true, false, true };
            five.CopyTo(MainBus.busData,0);
            this.busLedBar.SetLabelColors();

            byte regByte = Helper.ConvertBoolArrayToByte(five);
            binary = Convert.ToString(regByte, 2);
            this.lblBusBar.Text = binary.PadLeft(8, pad);
        }

        private void BtnBusClear_Click(object sender, EventArgs e)
        {
            bool[] zero = new bool[8] { false, false, false, false, false, false, false, false };
            zero.CopyTo(MainBus.busData, 0);
            this.busLedBar.SetLabelColors();

            byte regByte = Helper.ConvertBoolArrayToByte(MainBus.busData);
            binary = Convert.ToString(regByte, 2);
            this.lblBusBar.Text = binary.PadLeft(8, pad);
        }

        private void BtnBus2Areg_Click(object sender, EventArgs e)
        {
            // bool[] five = new bool[8] { false, false, false, false, false, true, false, true };
            MainBus.busData.CopyTo(A_Register.aregData,0);
            //areg.SetDataValue(MainBus.busData); // (MainBus.busData);
            this.AregLedBar.SetLabelColors();

            byte regByte = Helper.ConvertBoolArrayToByte(A_Register.aregData);
            binary = Convert.ToString(regByte, 2);
            this.lblAregBar.Text = binary.PadLeft(8, pad);
        }

        private void BtnBus2Breg_Click(object sender, EventArgs e)
        {
            //bool[] five = new bool[8] { false, false, false, false, false, true, false, true };
            MainBus.busData.CopyTo(B_Register.bregData, 0);
            breg.SetDataValue(B_Register.bregData); // (MainBus.busData);
            this.BregLedBar.SetLabelColors();

            byte regByte = Helper.ConvertBoolArrayToByte(B_Register.bregData);
            binary = Convert.ToString(regByte, 2);
            this.lblBregBar.Text = binary.PadLeft(8, pad);
        }

        private void BtnBus2ALU_Click(object sender, EventArgs e)
        {
            bool[] five = new bool[8] { false, false, false, false, false, true, false, true };
            alu.SetDataValue(five); // (MainBus.busData);
            this.ALULedBar.SetLabelColors();

            byte regByte = Helper.ConvertBoolArrayToByte(five);
            binary = Convert.ToString(regByte, 2);
            this.lblALUBar.Text = binary.PadLeft(8, pad);
        }
    }
}
