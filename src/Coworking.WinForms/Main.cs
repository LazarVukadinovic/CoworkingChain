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
    public partial class Main : Form
    {
        private Form startForm;
        public Main(Form callingForm)
        {
            InitializeComponent();
            this.startForm = callingForm;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
