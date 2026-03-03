using Coworking.Data.Providers;
using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniLokaciju : Form
    {
        IDataBase singleton;
        public IzmeniLokaciju()
        {
            InitializeComponent();
            // TODO
            // sve komponente poraju da se popune podacima iz baze
            singleton = DataBaseSingleton.vratiInstancu();
        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadLocations()
        {
            var memberships = singleton.prikaziLokacije(false);
            foreach (var membership in memberships)
                foreverComboBox1.Items.Add(membership.lokacijaId);
        }
    }
}
