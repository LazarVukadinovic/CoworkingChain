using Coworking.Data.Providers;
using Coworking.Domain.Enums;
using Coworking.WinForms.Dialogues;

namespace Coworking.WinForms
{
    public partial class Lokacije : Form
    {
        IDataBase singleton;
        public Lokacije()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;
            viewComboBox.SelectedIndex = 0;
            loadData();
        }

        private void OnDataChanged(DataEntity entity)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDataChanged(entity)));
                return;
            }

            if (entity == DataEntity.Lokacija)
            {
                loadData();
            }
        }
        private void loadData()
        {
            int? sačuvaniId = null;
            if (locationDataGridView.SelectedRows.Count > 0)
            {
                sačuvaniId = (int)locationDataGridView.SelectedRows[0].Cells[0].Value;
            }

            locationDataGridView.DataSource = null;
            switch (viewComboBox.Text)
            {
                case "Sve":
                    locationDataGridView.DataSource = singleton.prikaziLokacije(false);
                    break;

                case "Aktivne lokacije":
                    locationDataGridView.DataSource = singleton.prikaziLokacije(true);
                    break;

                case "Statistika lokacija":
                    locationDataGridView.DataSource = singleton.PrikaziStatistikuLokacija();
                    break;
            }

            locationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (sačuvaniId.HasValue)
            {
                foreach (DataGridViewRow row in locationDataGridView.Rows)
                {
                    if ((int)row.Cells[0].Value == sačuvaniId.Value)
                    {
                        locationDataGridView.ClearSelection();
                        row.Selected = true;

                        if (locationDataGridView.Columns.Count > 0)
                            locationDataGridView.CurrentCell = row.Cells[0];

                        break;
                    }
                }
            }
        }
        private void viewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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



