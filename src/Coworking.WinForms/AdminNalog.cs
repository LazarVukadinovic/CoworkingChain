using Coworking.WinForms.Dialogues.Admin;
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
    }
}
