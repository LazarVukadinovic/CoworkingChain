using Coworking.Data.Providers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Coworking.WinForms
{
    public partial class LoginForm : Form
    {
        IDataBase database = DataBaseSingleton.vratiInstancu();
        public LoginForm()
        {
            InitializeComponent();
            //database.addAdmin(new Domain.Entities.Admin { KorisnickoIme = "admin5", LozinkaHash = "admin5" });
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Dashboard main = new Dashboard(this);
            main.FormClosed += (s, e) => Application.Exit();

            string username = usernameTextBox.textBox.Text;
            string password = passwordTextBox.textBox.Text;
            var result = database.getAdminByUsername(username, password);
            Debug.WriteLine(result);
            if (!result)
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                main.Show();
            }
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
