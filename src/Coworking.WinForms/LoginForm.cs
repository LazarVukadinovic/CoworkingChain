using Coworking.Data.Providers;

namespace Coworking.WinForms
{
    public partial class LoginForm : Form
    {
        IDataBase database = DataBaseSingleton.vratiInstancu();
        public LoginForm()
        {
            InitializeComponent();
            headerLabel.Text += " " + database.prikazLanca();
            //database.addAdmin(new Domain.Entities.Admin { KorisnickoIme = "admin5", LozinkaHash = "admin5" });
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Dashboard main = new Dashboard(this);
            main.FormClosed += (s, args) => Application.Exit();

            this.Hide();
            main.Show();
            /*
            string username = usernameTextBox.textBox.Text;
            string password = passwordTextBox.textBox.Text;

            var ulogovaniAdmin = database.getAdminByUsername(username, password);

            if (ulogovaniAdmin == null)
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                AdminSession.Instance.PrijaviAdmina(ulogovaniAdmin);


                Dashboard main = new Dashboard(this);
                main.FormClosed += (s, args) => Application.Exit();

                this.Hide();
                main.Show();
            }
            */
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
