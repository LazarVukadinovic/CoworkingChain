using System;

namespace Coworking.WinForms
{
    public partial class Dashboard : Form
    {
        private Form startForm;
        public Dashboard(Form callingForm)
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
