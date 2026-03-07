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

            // Martino
            //MessageBox.Show("Korisničko ime uspešno promenjeno!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //singleton.updateAdminByUsername(AdminSession.Instance.TrenutniAdmin, newName);
            //AdminSession.Instance.PrijaviAdmina(AdminSession.Instance.TrenutniAdmin);

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Korisničko ime ne može biti prazno.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var admin = AdminSession.Instance.TrenutniAdmin;
            singleton.updateAdminByUsername(admin, newName);

            // Ažurira in-memory objekat i sesiju
            admin.KorisnickoIme = newName;
            AdminSession.Instance.PrijaviAdmina(admin);

            MessageBox.Show("Korisničko ime uspešno promenjeno!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
