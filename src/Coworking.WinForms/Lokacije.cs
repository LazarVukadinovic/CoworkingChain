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
            // 1. Zapamti ID selektovane lokacije (ako je ima)
            int? sačuvaniId = null;
            if (locationDataGridView.SelectedRows.Count > 0)
            {
                // Pretpostavljam da je Cells[0] tvoj LokacijaID
                sačuvaniId = (int)locationDataGridView.SelectedRows[0].Cells[0].Value;
            }

            // 2. Tvoja postojeća logika za punjenje podataka
            if (showStatisticsRadioButton.Checked)
            {
                var locations = singleton.PrikaziStatistikuLokacija();
                locationDataGridView.DataSource = null;
                locationDataGridView.DataSource = locations;
            }
            else
            {
                bool check = activeLocationsRadioButton.Checked;
                var locations = singleton.prikaziLokacije(check);
                locationDataGridView.DataSource = null;
                locationDataGridView.DataSource = locations;
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

                        // Nateraj "strelicu" da se pomeri na taj red
                        if (locationDataGridView.Columns.Count > 0)
                            locationDataGridView.CurrentCell = row.Cells[0];

                        break;
                    }
                }
            }
        }
        private void showStatisticsRadioButton_Click(object sender, EventArgs e)
        {
            if (showStatisticsRadioButton.Checked)
                showStatisticsRadioButton.Checked = false;
            else
            {
                showStatisticsRadioButton.Checked = true;
                activeLocationsRadioButton.Checked = false;
            }
            loadData();
        }

        private void activeLocationsRadioButton_Click(object sender, EventArgs e)
        {
            if (activeLocationsRadioButton.Checked)
                activeLocationsRadioButton.Checked = false;
            else
            {
                activeLocationsRadioButton.Checked = true;
                showStatisticsRadioButton.Checked = false;
            }
            loadData();
        }

        private void activeLocationsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Proveravamo samo kada postane 'true' da ne bismo duplo osvežavali
            if (activeLocationsRadioButton.Checked)
            {
                loadData();
            }
        }

        private void showStatisticsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (showStatisticsRadioButton.Checked)
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



