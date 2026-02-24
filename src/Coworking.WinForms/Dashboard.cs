using System;

namespace Coworking.WinForms
{
    public partial class Dashboard : Form
    {
        private Form? activeForm;
        private readonly Form loginForm;
        public Dashboard(Form callingForm)
        {
            InitializeComponent();
            this.loginForm = callingForm;
            this.activeForm = null;
        }

        private void openChildForm(Form childForm)
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

        private void resetEnabledComponents()
        {
            korisniciButton.Enabled = true;
            lokacijeButton.Enabled = true;
            tipoviClanstvaButton.Enabled = true;
            resursButton.Enabled = true;
            rezervacijeButton.Enabled = true;
            nalogButton.Enabled = true;
        }

        private void korisniciButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Clanovi());
            resetEnabledComponents();
            korisniciButton.Enabled = false;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lokacijeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Lokacije());
            resetEnabledComponents();
            lokacijeButton.Enabled = false;
        }
    }
}
