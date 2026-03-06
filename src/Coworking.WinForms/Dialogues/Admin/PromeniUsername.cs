using Coworking.Data.Providers;
using System;

namespace Coworking.WinForms.Dialogues.Admin
{
    public partial class PromeniUsername : Form
    {
        IDataBase singleton;
        public PromeniUsername()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            usernameTextBox.TextButton = AdminSession.Instance.TrenutniAdmin.KorisnickoIme;
        }

        private void editUsernameButton_Click(object sender, EventArgs e)
        {
            var newName = usernameTextBox.TextButton;
            MessageBox.Show("Korisničko ime uspešno promenjeno!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            singleton.updateAdminByUsername(AdminSession.Instance.TrenutniAdmin, newName);
            AdminSession.Instance.PrijaviAdmina(AdminSession.Instance.TrenutniAdmin);
        }
    }
}
