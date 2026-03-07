using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Coworking.WinForms.Dialogues;

namespace Coworking.WinForms
{
    public partial class Rezervacije : Form
    {
        private readonly IDataBase singleton;
        DataBaseProxy proxy;

        public Rezervacije()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            proxy = (DataBaseProxy)singleton;
            proxy.DataChanged += OnDataChanged;
            //locationComboBox.SelectedIndex = 0;
            loadData();
        }

        private void OnDataChanged(DataEntity entity)
        {
            if (entity == DataEntity.Rezervacija) // bilo je DataEntity.Resurs
            {
                loadData();
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
            var reservations = singleton.prikaziSveRezervacije();
            reservationDataGridView.DataSource = null;
            reservationDataGridView.DataSource = reservations;
            reservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool _syncingRadios;
        private void userRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

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
            confirmedCheckBox.Visible =
            cancelledCheckBox.Visible =
            doneCheckBox.Visible = userRadioButton.Checked;

            // pretraga po lokaciji i danu
            locationLabel.Visible = locationComboBox.Visible = locationDateRadioButton.Checked;

            dateLabel.Visible = dateDateTime.Visible = locationDateRadioButton.Checked;

            // prikaz dugmeta
            searchButton.Visible = userRadioButton.Checked || locationDateRadioButton.Checked;
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
            if (locationDateRadioButton.Checked == true)
            {
                var locationId = (int)locationComboBox.SelectedValue;
                var date = dateDateTime.Value.ToString("yyyy-MM-dd"); ;
                var results = singleton.prikaziRezervacijeZaDanILokaciju(date.ToString(), locationId);
                reservationDataGridView.DataSource = results;
            }
            else
            {
                //var user = userTextBox.Text;
                //var statusi = new List<string>();
                //if (reservedCheckBox.Checked) statusi.Add("Reserved");
                //if (confirmedCheckBox.Checked) statusi.Add("Confirmed");
                //if (cancelledCheckBox.Checked) statusi.Add("Cancelled");
                //if (doneCheckBox.Checked) statusi.Add("Done");
                //var results = singleton.prikaziRezervacijeSaStatusomZaIzabranogClana(user, statusi);
                //reservationDataGridView.DataSource = results;

                List<ReservationStatus> selektovaniStatusi = new List<ReservationStatus>();

                if (reservedCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Rezervisana);
                if (confirmedCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Potvrdjena);
                if (cancelledCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Otkazana);
                if (doneCheckBox.Checked) selektovaniStatusi.Add(ReservationStatus.Zavrsena);
                var user = userTextBox.SelectedValue;
                var results = singleton.prikaziRezervacijeSaStatusomZaIzabranogClana((int)user, selektovaniStatusi);
                reservationDataGridView.DataSource = results;
            }
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
    }
}
