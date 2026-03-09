using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues.Admin;

namespace Coworking.WinForms
{
    public partial class AdminNalog : Form
    {
        public AdminNalog()
        {
            InitializeComponent();
            OsveziPrikazAdmina();
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
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            DodajAdmina newAdmin = new DodajAdmina();
            newAdmin.ShowDialog(this);
        }
    }
}