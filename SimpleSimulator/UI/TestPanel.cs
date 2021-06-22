using BreadboardSimulator.Modules;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BreadboardSimulator.UI
{
    public partial class TestPanel : Form
    {
        readonly ProgramControlUnit pcu = new ProgramControlUnit();

        public TestPanel()
        {
            InitializeComponent();
        }

        private void BtnSetBusData_Click(object sender, EventArgs e)
        {
            String strFive = "11111111";
            MainBus.RegData = strFive;
            pcu.ToggleBUS();
        }

        private void BtnClearBus_Click(object sender, EventArgs e)
        {
            String strZero = "00000000";
            MainBus.RegData = strZero;
            pcu.ToggleBUS();
        }

        private void BtnAI_Click(object sender, EventArgs e)
        {
            pcu.ToggleAI();
        }

        private void BtnAO_Click(object sender, EventArgs e)
        {
            pcu.ToggleAO();
        }

        private void BtnBI_Click(object sender, EventArgs e)
        {
            pcu.ToggleBI();
        }

        private void BtnSUB_Click(object sender, EventArgs e)
        {
            pcu.ToggleSUB();
        }

        private void BtnEO_Click(object sender, EventArgs e)
        {
            pcu.ToggleEO();
        }

        private void BtnMI_Click(object sender, EventArgs e)
        {
            pcu.ToggleMI();
        }

        private void BtnRI_Click(object sender, EventArgs e)
        {
            pcu.ToggleRI();
        }

        private void BtnRO_Click(object sender, EventArgs e)
        {
            pcu.ToggleRO();
        }

        private void BtnII_Click(object sender, EventArgs e)
        {
            pcu.ToggleII();
        }

        private void BtnIO_Click(object sender, EventArgs e)
        {
            pcu.ToggleIO();
        }

        private void BtnOI_Click(object sender, EventArgs e)
        {
            pcu.ToggleOI();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            pcu.ToggleCE();
        }

        private void BtnCO_Click(object sender, EventArgs e)
        {
            pcu.ToggleCO();
        }

        private void BtnJMP_Click(object sender, EventArgs e)
        {
            pcu.ToggleJMP();
        }

        private void BtnROAI_Click(object sender, EventArgs e)
        {
            MAR.RegData = "1110";
            pcu.ToggleRO();
            pcu.ToggleAI();
        }

        private void BtnBus28_Click(object sender, EventArgs e)
        {
            MainBus.RegData = "00011100";
            pcu.ToggleBUS();
        }

        private void BtnBus14_Click(object sender, EventArgs e)
        {
            MainBus.RegData = "00001110";
            pcu.ToggleBUS();
        }
    }
}
