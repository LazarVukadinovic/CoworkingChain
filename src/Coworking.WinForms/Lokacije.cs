using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues;
using System;
using System.Diagnostics;

namespace Coworking.WinForms
{
    public partial class Lokacije : Form
    {
        public Lokacije()
        {
            InitializeComponent();
            loadData();
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            DodajLokaciju newLocation = new DodajLokaciju();
            newLocation.ShowDialog(this);
        }

        private void editLocationButton_Click(object sender, EventArgs e)
        {
            IzmeniLokaciju editLocation = new IzmeniLokaciju();
            editLocation.ShowDialog(this);
        }

        private void loadData()
        {
            bool check = currentLocationCheckBox.Checked;
            var locations = DataBaseSingleton.vratiInstancu().prikaziLokacije(check);

            locationDataGridView.DataSource = null;
            locationDataGridView.DataSource = locations;

            locationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void currentLocationCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void currentLocationCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void currentLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            loadData();
        }

        private void deleteLocationButton_Click(object sender, EventArgs e)
        {
            loadData();
            var membershipId = (int)locationDataGridView.SelectedRows[0].Cells[0].Value;
            DataBaseSingleton.vratiInstancu().obrisiLokaciju(membershipId);
            loadData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var text = searchTextBox.textBox.Text;
            var membership = DataBaseSingleton.vratiInstancu().GetLokacijaByName(text);
            locationDataGridView.DataSource = membership;
        }
    }
}
