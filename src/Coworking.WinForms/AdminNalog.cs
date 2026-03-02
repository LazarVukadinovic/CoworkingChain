using Coworking.WinForms.Dialogues.Admin;
using System;

namespace Coworking.WinForms
{
    public partial class AdminNalog : Form
    {
        public AdminNalog()
        {
            InitializeComponent();
            // TODO
            // ucitavanje podataka o adminu u komponente
            usernameLabel.Text = "Dummy";
        }

        private void editUsernameButton_Click(object sender, EventArgs e)
        {
            PromeniUsername newUsername = new PromeniUsername();
            newUsername.ShowDialog(this);
        }

        private void editPasswordButton_Click(object sender, EventArgs e)
        {
            PromeniLozinku newPassword = new PromeniLozinku();
            newPassword.ShowDialog(this);
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            DodajAdmina newAdmin = new DodajAdmina();
            newAdmin.ShowDialog(this);
        }
    }
}
