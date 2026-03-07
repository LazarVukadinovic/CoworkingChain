using Coworking.Data.Providers;
using System;
using System.Diagnostics;

namespace Coworking.WinForms.Dialogues.Admin
{
    public partial class PromeniLozinku : Form
    {
        public PromeniLozinku()
        {
            InitializeComponent();
        }

        private void editPasswordButton_Click(object sender, EventArgs e)
        {
            var trenutniAdmin = AdminSession.Instance.TrenutniAdmin;
            var trenutniPasswordIzBoxa = currentPasswordTextBox.TextButton;
            var noviPasswordIzBoxa = newPasswordTextBox.TextButton;

            // Martino
            //Debug.WriteLine(trenutniPasswordIzBoxa.ToString());
            //bool lozinkaTacna = BCrypt.Net.BCrypt.Verify(trenutniPasswordIzBoxa, trenutniAdmin.LozinkaHash);
            //if (trenutniPasswordIzBoxa == null || noviPasswordIzBoxa == null)
            //    MessageBox.Show("Sva polja su obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    if (lozinkaTacna)
            //    {
            //        trenutniAdmin.LozinkaHash = noviPasswordIzBoxa;
            //        AdminSession.Instance.PrijaviAdmina(trenutniAdmin);
            //        DataBaseSingleton.vratiInstancu().updateAdmin(trenutniAdmin);
            //        MessageBox.Show("Lozinka uspešno promenjena!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Trenutna lozinka nije tačna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            // mora prvo da se provere polja dal su prazna
            if (string.IsNullOrEmpty(trenutniPasswordIzBoxa) || string.IsNullOrEmpty(noviPasswordIzBoxa))
            {
                MessageBox.Show("Sva polja su obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool lozinkaTacna = BCrypt.Net.BCrypt.Verify(trenutniPasswordIzBoxa, trenutniAdmin.LozinkaHash);

            if (lozinkaTacna)
            {
                trenutniAdmin.LozinkaHash = noviPasswordIzBoxa;
                DataBaseSingleton.vratiInstancu().updateAdmin(trenutniAdmin);
                AdminSession.Instance.PrijaviAdmina(trenutniAdmin);
                MessageBox.Show("Lozinka uspešno promenjena!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Trenutna lozinka nije tačna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
