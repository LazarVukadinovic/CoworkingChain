using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajRezervaciju : Form
    {
        public DodajRezervaciju()
        {
            InitializeComponent();
            resourceComboBox.SelectedIndex = 0;
            endTimeDateTime.Value = startTimeDateTime.Value + new TimeSpan(1, 0, 0);
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            if (currentLocationCheckBox.Checked)
            {
                locationComboBox.Enabled = false;
                // TODO:
                // prikaz trenutne lokacije u comboBox-u
            }
            else
            {
                locationComboBox.Enabled = true;
            }
        }
    }
}
