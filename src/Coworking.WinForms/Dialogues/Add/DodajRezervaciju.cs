using Coworking.Data.Command;
using Coworking.Data.Command.RezervacijaCommand;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

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
            // resourceComboBox.SelectedIndex = 0;
            // endTimeDateTime.Value = startTimeDateTime.Value + new TimeSpan(1, 0, 0);
            endDateDateTime.Value = startDateDateTime.Value;
            endTimeDateTime.Value = startTimeDateTime.Value.AddHours(1);
        }
        private void loadMembers()
        {
            var members = singleton.prikaziClanove();
            userComboBox.DisplayMember = "PunoIme";
            userComboBox.ValueMember = "clanId";
            userComboBox.DataSource = members;
        }

        private void loadResources()
        {
            var resources = singleton.prikaziSveResurse();
            resourceComboBox.DisplayMember = "oznaka";
            resourceComboBox.ValueMember = "resursId";
            resourceComboBox.DataSource = resources;
        }

        private void loadLocation()
        {
            if (resourceComboBox.SelectedValue != null)
            {
                int resursId = (int)resourceComboBox.SelectedValue;
                locationTextBox.Text = singleton.getLokacijaByResursId(resursId).naziv;
            }
            else
                locationTextBox.Text = "";
        }

        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadLocation();
        }
        private void resourceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLocation();
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedValue == null || resourceComboBox.SelectedValue == null)
            {
                MessageBox.Show("Izaberi korisnika i resurs.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PoisonDateTime daje datum, standardni DateTimePicker daje vreme — kombinujemo
            DateTime pocetak = startDateDateTime.Value.Date + startTimeDateTime.Value.TimeOfDay;
            DateTime kraj = endDateDateTime.Value.Date + endTimeDateTime.Value.TimeOfDay;

            if (pocetak >= kraj)
            {
                MessageBox.Show("Kraj rezervacije mora biti posle početka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rezervacija = new Rezervacija
            {
                clanId = (int)userComboBox.SelectedValue,
                resursId = (int)resourceComboBox.SelectedValue,
                pocetak = pocetak.ToString("yyyy-MM-dd HH:mm:ss"),
                kraj = kraj.ToString("yyyy-MM-dd HH:mm:ss"),
                status = ReservationStatus.Rezervisana,
                kreiranoU = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                otkazanoU = null
            };

            var command = new DodajRezervacijuCommand(singleton, rezervacija);
            var manager = new CommandManager();
            var result = manager.ExecuteCommand(command);

            if (result.isValid)
            {
                MessageBox.Show("Rezervacija uspešno dodata!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show(result.errorMessage, "Greška validacije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
