using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coworking.WinForms
{
    public partial class Resursi : Form
    {
        public Resursi()
        {
            InitializeComponent();
            resourceTypeComboBox.SelectedIndex = locationComboBox.SelectedIndex = 0;
        }

    }
}
