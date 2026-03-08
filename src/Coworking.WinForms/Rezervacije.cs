using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Coworking.WinForms.Dialogues;

namespace Coworking.WinForms
{
    public partial class Rezervacije : Form
    {
        private readonly IDataBase singleton;
        private bool _filterAktivan = false;

        public Rezervacije()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;
            //locationComboBox.SelectedIndex = 0;
            loadData();
        }

        private void OnDataChanged(DataEntity entity)
        {
            // Provera da li je forma uopšte živa i da li ima Handle
            if (!this.IsHandleCreated || this.IsDisposed) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDataChanged(entity)));
                return;
            }

            if (entity == DataEntity.Rezervacija && !_filterAktivan)
            {
                RefreshWithSelection(() => ApplyDataSource(singleton.prikaziSveRezervacije()));
            }
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            DodajRezervaciju newReservation = new DodajRezervaciju();
            newReservation.ShowDialog(this);
            loadData();
        }

        private void editReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi rezervaciju za izmenu.", "Izmena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedReservation = (Rezervacija)reservationDataGridView.SelectedRows[0].DataBoundItem;
            IzmeniRezervaciju editReservation = new IzmeniRezervaciju(selectedReservation);
            editReservation.ShowDialog(this);
            loadData();
        }
        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            if(reservationDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi rezervaciju za otkazivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedReservation = (Rezervacija)reservationDataGridView.SelectedRows[0].DataBoundItem;
            if(selectedReservation.status == ReservationStatus.Rezervisana)
            {
                singleton.otkaziRezervaciju(selectedReservation.rezervacijaId);
                loadData();
            }
            else
                MessageBox.Show("Izaberi rezervaciju sa statusom 'rezervisana'.", "Otkazivanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi rezervaciju za brisanje.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedReservation = (Rezervacija)reservationDataGridView.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Da li sigurno �eli� da obri�e� rezervaciju #{selectedReservation.rezervacijaId}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            singleton.obrisiRezervaciju(selectedReservation.rezervacijaId);
            loadData();
        }

        private void loadData()
        {
            // Standardno punjenje bez skakanja
            RefreshWithSelection(() => ApplyDataSource(singleton.prikaziSveRezervacije()));
        }

        // Pomoćna metoda koja vrši promenu podataka bez resetovanja svega
        private void ApplyDataSource(object data)
        {
            // Sprečavamo pucanje ako se podaci menjaju dok se forma gasi
            if (reservationDataGridView.IsDisposed) return;

            reservationDataGridView.DataSource = null;
            if (data != null)
            {
                reservationDataGridView.DataSource = data;
                reservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private bool _syncingRadios;
        private void userRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (!locationDateRadioButton.Checked)
            {
                _filterAktivan = false;
                loadData();
            }

            if (userRadioButton.Checked)
            {
                _syncingRadios = true;
                locationDateRadioButton.Checked = false;
                searchButton.Location = new Point(976, 25);
                _syncingRadios = false;
            }

            UpdateUI();
            loadUsers();
        }

        private void locationDateRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (!locationDateRadioButton.Checked)
            {
                _filterAktivan = false;
                loadData();
            }

            if (locationDateRadioButton.Checked)
            {
                _syncingRadios = true;
                userRadioButton.Checked = false;
                searchButton.Location = new Point(778, 25);
                _syncingRadios = false;
            }

            UpdateUI();
            loadLocations();
        }

        private void UpdateUI()
        {
            // pretraga po korisniku i statusu rezervacije
            userLabel.Visible = userTextBox.Visible = userRadioButton.Checked;

            reservedCheckBox.Visible =
            cancelledCheckBox.Visible =
            doneCheckBox.Visible = userRadioButton.Checked;

            // pretraga po lokaciji i danu
            locationLabel.Visible = locationComboBox.Visible = locationDateRadioButton.Checked;

            dateLabel.Visible = dateDateTime.Visible = locationDateRadioButton.Checked;

            // prikaz dugmeta
            searchButton.Visible = userRadioButton.Checked || locationDateRadioButton.Checked;

            if (!userRadioButton.Checked && !locationDateRadioButton.Checked)
            {
                _filterAktivan = false;
                loadData();
            }
        }

        //private void loadReservations()
        //{
        //    var reservations = singleton.prikaziSveRezervacije();
        //    reservationDataGridView.DataSource = reservations;
        //}

        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DataSource = locations;
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _filterAktivan = true;

            RefreshWithSelection(() => {
                if (locationDateRadioButton.Checked)
                {
                    var locationId = (int)locationComboBox.SelectedValue;
                    var date = dateDateTime.Value.ToString("yyyy-MM-dd");
                    reservationDataGridView.DataSource = singleton.prikaziRezervacijeZaDanILokaciju(date, locationId);
                }
                else
                {
                    List<ReservationStatus> selektovaniStatusi = new List<ReservationStatus>();
                    if (reservedCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Rezervisana);
                    if (cancelledCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Otkazana);
                    if (doneCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Zavrsena);

                    var user = (int)userTextBox.SelectedValue;
                    reservationDataGridView.DataSource = singleton.prikaziRezervacijeSaStatusomZaIzabranogClana(user, selektovaniStatusi);
                }
            });
        }

        private void userTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadUsers()
        {
            var users = singleton.prikaziClanove();
            userTextBox.ValueMember = "clanId";
            userTextBox.DisplayMember = "PunoIme";
            userTextBox.DataSource = users;
        }

        private void RefreshWithSelection(Action updateLogic)
        {
            if (!this.IsHandleCreated || this.IsDisposed)
            {
                updateLogic();
                return;
            }

            int? sačuvaniId = null;
            int? prviVidljiviIndex = null;

            // 1. Sačuvaj trenutno stanje
            if (reservationDataGridView.Rows.Count > 0 && reservationDataGridView.SelectedRows.Count > 0)
            {
                var firstSelectedRow = reservationDataGridView.SelectedRows[0];
                if (firstSelectedRow.Cells[0].Value != null)
                {
                    sačuvaniId = (int)firstSelectedRow.Cells[0].Value;
                    prviVidljiviIndex = reservationDataGridView.FirstDisplayedScrollingRowIndex;
                }
            }

            // 2. Suspenuj layout (sprečava treptanje) ✅
            reservationDataGridView.SuspendLayout();

            try
            {
                // 3. Osveži podatke
                updateLogic();

                // 4. Vrati selekciju
                if (sačuvaniId.HasValue && reservationDataGridView.Rows.Count > 0)
                {
                    reservationDataGridView.ClearSelection();

                    foreach (DataGridViewRow row in reservationDataGridView.Rows)
                    {
                        if (row.Cells[0].Value != null && (int)row.Cells[0].Value == sačuvaniId)
                        {
                            reservationDataGridView.CurrentCell = row.Cells[0];
                            row.Selected = true;

                            if (prviVidljiviIndex.HasValue &&
                                prviVidljiviIndex < reservationDataGridView.RowCount &&
                                prviVidljiviIndex >= 0)
                            {
                                reservationDataGridView.FirstDisplayedScrollingRowIndex = prviVidljiviIndex.Value;
                            }
                            break;
                        }
                    }
                }
            }
            finally
            {
                // 5. Nastavi layout (refresh grid) ✅
                reservationDataGridView.ResumeLayout();
            }
        }
    }
}
