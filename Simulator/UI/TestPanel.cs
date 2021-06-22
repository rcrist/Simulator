using Simulator.Modules;
using System;
using System.Windows.Forms;

namespace Simulator.UI
{
    public partial class TestPanel : Form
    {
        readonly ProgramControlUnit pcu = new ProgramControlUnit();

        public TestPanel()
        {
            InitializeComponent();
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
    }
}
