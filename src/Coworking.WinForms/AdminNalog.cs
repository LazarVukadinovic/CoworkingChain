using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues.Admin;
// Dodaj namespace gde ti se nalazi AdminSession i Admin entitet
// using Coworking.Domain.Entities; 

namespace Coworking.WinForms
{
    public partial class AdminNalog : Form
    {
        public AdminNalog()
        {
            InitializeComponent();
            OsveziPrikazAdmina();
        }

        private void AdminNalog_Load(object sender, EventArgs e)
        {
            
        }

        private void OsveziPrikazAdmina()
        {
            if (AdminSession.Instance.TrenutniAdmin != null)
            {
                usernameLabel.Text = AdminSession.Instance.TrenutniAdmin.KorisnickoIme;


                passwordLabel.Text = "**********";
            }
        }

        private void editUsernameButton_Click(object sender, EventArgs e)
        {
            PromeniUsername newUsername = new PromeniUsername();
            if (newUsername.ShowDialog(this) == DialogResult.OK)
            {
                OsveziPrikazAdmina();
            }
        }

        private void editPasswordButton_Click(object sender, EventArgs e)
        {
            PromeniLozinku newPassword = new PromeniLozinku();
            newPassword.ShowDialog(this);
            // Napomena: Ovde obično ne osvežavamo prikaz jer je lozinka ionako maskirana
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            DodajAdmina newAdmin = new DodajAdmina();
            newAdmin.ShowDialog(this);
        }
    }
}