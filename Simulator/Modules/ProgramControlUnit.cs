using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Modules
{
    class ProgramControlUnit
    {
        public delegate void ChangeEvent(bool bit); // Change event delegate

        // Publish AI change event
        public static event ChangeEvent AIchangeEvent;  // AI change event variable
        public bool AI = false;

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
        public bool AO = false;

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
        public bool BI = false;

        public void ToggleBI()
        {
            BI = !BI;
            BIChanged();
        }

        private void BIChanged()
        {
            BIchangeEvent?.Invoke(BI);
        }

        // Publish SUB change event
        public static event ChangeEvent SUBchangeEvent;  // AI change event variable
        public bool SUB = false;

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
        public bool EO = false;

        public void ToggleEO()
        {
            EO = !EO;
            EOChanged();
        }

        private void EOChanged()
        {
            EOchangeEvent?.Invoke(EO);
        }
    }
}
