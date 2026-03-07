using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues;
using System;
using System.Diagnostics;

namespace Coworking.WinForms
{
    public partial class Lokacije : Form
    {
        IDataBase singleton;
        public Lokacije()
        {
            InitializeComponent();
            singleton=DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;
            loadData();
        }

        private void OnDataChanged(DataEntity entity)
        {
            if (entity == DataEntity.Lokacija)
            {
                loadData();
            }
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
            var locations = singleton.PrikaziStatistikuLokacija();

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
            if (locationDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi lokaciju za brisanje.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var locationId = (int)locationDataGridView.SelectedRows[0].Cells[0].Value;
            var confirm = MessageBox.Show(
                "Da li sigurno želiš da obrišeš izabranu lokaciju?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            singleton.obrisiLokaciju(locationId);
            loadData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var text = searchTextBox.textBox.Text;
            var membership = singleton.GetLokacijaByName(text);
            locationDataGridView.DataSource = membership;
        }
    }
}



