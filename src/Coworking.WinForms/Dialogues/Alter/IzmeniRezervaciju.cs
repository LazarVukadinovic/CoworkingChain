using Coworking.Data.Chain_Of_Responsibility;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniRezervaciju : Form
    {
        private IDataBase _singleton;
        private Rezervacija _selektovanaRezervacija;

        public IzmeniRezervaciju(Rezervacija selektovanaRezervacija)
        {
            InitializeComponent();
            _singleton = DataBaseSingleton.vratiInstancu();
            _selektovanaRezervacija = selektovanaRezervacija;

            loadMember();
            loadResources();
            loadDate();
        }

        private void loadMember()
        {
            var member = _singleton.prikaziClanove()
                .FirstOrDefault(c => c.clanId == _selektovanaRezervacija.clanId);
            userNameLabel.Text = member != null ? $"{member.ime} {member.prezime}" : $"Clan #{_selektovanaRezervacija.clanId}";
        }

        private void loadResources()
        {
            var resources = _singleton.prikaziSveResurse();
            resourceComboBox.Items.Clear();
            resourceComboBox.DisplayMember = "oznaka";
            resourceComboBox.ValueMember = "resursId";
            resourceComboBox.DataSource = resources;

            resourceComboBox.SelectedValue = _selektovanaRezervacija.resursId;
        }

        private void loadDate()
        {
            if (DateTime.TryParse(_selektovanaRezervacija.pocetak, out DateTime poc))
            {
                startDateDateTime.Value = poc.Date;
                startTimeDateTime.Value = poc;
            }
            if (DateTime.TryParse(_selektovanaRezervacija.kraj, out DateTime kraj))
            {
                endDateDateTime.Value = kraj.Date;
                endTimeDateTime.Value = kraj;
            }
        }

        private void loadLocation()
        {
            if (resourceComboBox.SelectedValue != null)
            {
                int resursId = (int)resourceComboBox.SelectedValue;
                locationTextBox.Text = _singleton.getLokacijaByResursId(resursId).naziv;
            }
            else
                locationTextBox.Text = "";
        }
        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLocation();
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

            if (resourceComboBox.SelectedValue == null)
            {
                MessageBox.Show("Izaberi resurs.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var backup = new Rezervacija(_selektovanaRezervacija);

            _selektovanaRezervacija.pocetak = pocetak.ToString("yyyy-MM-dd HH:mm:ss");
            _selektovanaRezervacija.kraj = kraj.ToString("yyyy-MM-dd HH:mm:ss");
            _selektovanaRezervacija.resursId = (int)resourceComboBox.SelectedValue;

            var zauzetostResursaValidator = new ZauzetostResursaValidator(_singleton);
            var limitSatiClanValidator = new LimitSatiClanValidator(_singleton);
            var radnoVremeLokacijeValidator = new RadnoVremeLokacijeValidator(_singleton);
            zauzetostResursaValidator.SetNext(limitSatiClanValidator).SetNext(radnoVremeLokacijeValidator);

            RezervacijaHandler validatorChain = zauzetostResursaValidator;
            var result = validatorChain.Handle(_selektovanaRezervacija);

            if (result.isValid)
            {
                _singleton.izmeniRezervaciju(_selektovanaRezervacija);
                MessageBox.Show("Rezervacija uspešno izmenjena!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Vrati backup ako validacija nije prosla
                _selektovanaRezervacija.pocetak = backup.pocetak;
                _selektovanaRezervacija.kraj = backup.kraj;
                _selektovanaRezervacija.resursId = backup.resursId;
                _selektovanaRezervacija.status = backup.status;

                MessageBox.Show(result.errorMessage, "Greška validacije", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
