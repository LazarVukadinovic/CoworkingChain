using Coworking.Data.Command;
using Coworking.Data.Command.RezervacijaCommand;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniRezervaciju : Form
    {
        private IDataBase _singleton;
        private Rezervacija _rezervacija;

        public IzmeniRezervaciju(Rezervacija rezervacija)
        {
            InitializeComponent();
            _singleton = DataBaseSingleton.vratiInstancu();
            _rezervacija = rezervacija;

            loadResources();
            loadStatuses();
            loadLocations();
            popuniPodatke();
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            //if (currentLocationCheckBox.Checked)
            //{
            //    locationComboBox.Enabled = false;
            //    // TODO:
            //    // prikaz trenutne lokacije u comboBox-u
            //}
            //else
            //{
            //    locationComboBox.Enabled = true;
            //}

            locationComboBox.Enabled = !currentLocationCheckBox.Checked;
        }

        private void loadResources()
        {
            var resources = _singleton.prikaziSveResurse();
            resourceComboBox.Items.Clear();
            resourceComboBox.DisplayMember = "oznaka";
            resourceComboBox.ValueMember = "resursId";
            resourceComboBox.DataSource = resources;
        }

        private void loadStatuses()
        {
            statusComboBox.Items.Clear();
            statusComboBox.Items.AddRange(new object[]
            {
                ReservationStatus.Rezervisana.ToDbString(),
                ReservationStatus.Potvrdjena.ToDbString(),
                ReservationStatus.Otkazana.ToDbString(),
                ReservationStatus.Zavrsena.ToDbString()
            });
        }

        private void loadLocations()
        {
            var locations = _singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;
        }

        private void popuniPodatke()
        {
            var clan = _singleton.prikaziClanove()
                .FirstOrDefault(c => c.clanId == _rezervacija.clanId);
            userNameLabel.Text = clan != null ? $"{clan.ime} {clan.prezime}" : $"Clan #{_rezervacija.clanId}";

            resourceComboBox.SelectedValue = _rezervacija.resursId;
            statusComboBox.SelectedItem = _rezervacija.status.ToDbString();

            if (DateTime.TryParse(_rezervacija.pocetak, out DateTime poc))
            {
                startDateDateTime.Value = poc.Date;
                startTimeDateTime.Value = poc;
            }
            if (DateTime.TryParse(_rezervacija.kraj, out DateTime kraj))
            {
                endDateDateTime.Value = kraj.Date;
                endTimeDateTime.Value = kraj;
            }
        }

        private void editReservationButton_Click(object sender, EventArgs e)
        {
            DateTime pocetak = startDateDateTime.Value.Date + startTimeDateTime.Value.TimeOfDay;
            DateTime kraj = endDateDateTime.Value.Date + endTimeDateTime.Value.TimeOfDay;

            if (pocetak >= kraj)
            {
                MessageBox.Show("Kraj rezervacije mora biti posle početka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (statusComboBox.SelectedItem == null || resourceComboBox.SelectedValue == null)
            {
                MessageBox.Show("Izaberi resurs i status.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var backup = new Rezervacija(_rezervacija);

            _rezervacija.pocetak = pocetak.ToString("yyyy-MM-dd HH:mm:ss");
            _rezervacija.kraj = kraj.ToString("yyyy-MM-dd HH:mm:ss");
            _rezervacija.resursId = (int)resourceComboBox.SelectedValue;
            _rezervacija.status = ReservationStatusTransformator.FromDbString(statusComboBox.SelectedItem.ToString()!);

            var command = new IzmeniRezervacijuCommand(_singleton, _rezervacija, backup);
            var manager = new CommandManager();
            var result = manager.ExecuteCommand(command);

            if (result.isValid)
            {
                MessageBox.Show("Rezervacija uspešno izmenjena!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Vrati backup ako validacija nije prosla
                _rezervacija.pocetak = backup.pocetak;
                _rezervacija.kraj = backup.kraj;
                _rezervacija.resursId = backup.resursId;
                _rezervacija.status = backup.status;

                MessageBox.Show(result.errorMessage, "Greška validacije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
