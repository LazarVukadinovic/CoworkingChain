using System;

namespace Coworking.WinForms
{
    public partial class Dashboard : Form
    {
        private Form? activeForm;
        private readonly Form  loginForm;
        public Dashboard(Form callingForm)
        {
            InitializeComponent();
            this.loginForm = callingForm;
            this.activeForm = null;
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void korisniciButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Clanovi());
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
