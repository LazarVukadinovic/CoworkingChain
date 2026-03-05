using Coworking.Data.Providers;
using System;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajRezervaciju : Form
    {
        IDataBase singleton;
        public DodajRezervaciju()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            loadResources();
            loadMembers();
            loadLocations();
            resourceComboBox.SelectedIndex = 0;
            endTimeDateTime.Value = startTimeDateTime.Value + new TimeSpan(1, 0, 0);
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            if (currentLocationCheckBox.Checked)
            {
                locationComboBox.Enabled = false;
                // TODO:
                // prikaz trenutne lokacije u comboBox-u
            }
            else
            {
                locationComboBox.Enabled = true;
            }
        }

        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadResources()
        {
            var resources = singleton.prikaziSveResurse();
            resourceComboBox.DisplayMember = "oznaka";
            resourceComboBox.ValueMember = "resursId";
            resourceComboBox.DataSource = resources;
        }

        private void loadMembers()
        {
            var members = singleton.prikaziClanove();
            userComboBox.DisplayMember = "PunoIme";
            userComboBox.ValueMember = "clanId";
            userComboBox.DataSource = members;
        }

        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;
        }
    }
}
