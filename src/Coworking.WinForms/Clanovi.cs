using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues;
using System;
using System.Diagnostics;

namespace Coworking.WinForms
{
    public partial class Clanovi : Form
    {
        IDataBase singleton;
        public Clanovi()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            loadMemberships();
            loadLocations();
            loadData2();
            //ResetComboBox();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            DodajClana newMember = new DodajClana();
            newMember.ShowDialog(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ResetComboBox();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            IzmeniClana editMember = new IzmeniClana();
            editMember.ShowDialog(this);
        }

        private void ResetComboBox()
        {
            membershipComboBox.SelectedIndex =
                locationComboBox.SelectedIndex =
                    statusComboBox.SelectedIndex = 0;
        }

        private void membershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();
            membershipComboBox.DisplayMember = "naziv";
            membershipComboBox.ValueMember = "tipClanstvaId";
            membershipComboBox.DataSource = memberships;
        }

        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;
        }

        private void loadData()
        {
            int? lokacijaId = locationComboBox.SelectedValue is int ? (int)locationComboBox.SelectedValue : null;
            int? clanstvoId = membershipComboBox.SelectedValue is int ? (int)membershipComboBox.SelectedValue : null;

            string status = statusComboBox.SelectedItem?.ToString() ?? null;
            status = status == "Svi" ? null : status;
            var clanovi = singleton.PrikaziClanoveFiltrirano(lokacijaId, clanstvoId, status);

            memberDataGridView.DataSource = null;
            memberDataGridView.DataSource = clanovi;
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void statusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData2()
        {
            var members = singleton.prikaziClanove();
            memberDataGridView.DataSource = members;
        }
    }
}
