using Coworking.Data.Providers;
using System;

namespace Coworking.WinForms.Dialogues.Admin
{
    public partial class DodajAdmina : Form
    {
        IDataBase singleton;
        public DodajAdmina()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            singleton.addAdmin(new Domain.Entities.Admin
            {
                KorisnickoIme = nameTextBox.TextButton,
                LozinkaHash = cyberTextBox1.TextButton
            });
        }
    }
}
