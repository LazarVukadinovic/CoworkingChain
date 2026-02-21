using System;

namespace Coworking.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Dashboard main = new Dashboard(this);
            main.FormClosed += (s, e) => Application.Exit();

            this.Hide();
            main.Show();
        }
    }
}
