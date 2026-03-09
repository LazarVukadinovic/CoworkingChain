using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Coworking.Services.Builders;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajResurs : Form
    {
        private IDataBase singleton;
        public DodajResurs()
        {
            InitializeComponent();
            deskTypeComboBox.SelectedIndex = 0;
            singleton = DataBaseSingleton.vratiInstancu();
            loadLocations();
        }
        private bool _syncingRadios;

        private void deskTypeRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (deskTypeRadioButton.Checked)
            {
                _syncingRadios = true;
                conferenceRadioButton.Checked = false;
                _syncingRadios = false;
            }

            UpdateUI();
        }

        private void conferenceRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (conferenceRadioButton.Checked)
            {
                _syncingRadios = true;
                deskTypeRadioButton.Checked = false;
                _syncingRadios = false;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            deskTypeLabel.Visible = deskTypeComboBox.Visible = deskTypeRadioButton.Checked;

            capacityLabel.Visible =
            capacityNumeric.Visible =
            equipmentGroupBox.Visible = conferenceRadioButton.Checked;
        }
        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;
        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            string oznaka = nameTextBox.textBox.Text;
            int lokacijaId = (int)locationComboBox.SelectedValue;
            string opis = aboutRichTextBox.TextButton;
            string tipResursa = deskTypeRadioButton.Checked ? "radno_mesto" : "sala";

            Resurs newResurs = new Resurs();
            newResurs.oznaka = oznaka;
            newResurs.lokacijaId = lokacijaId;
            newResurs.tipResursa = tipResursa;
            newResurs.opis = opis;
            singleton.dodajResurs(newResurs);

            var director = new ResursDirector();
            int resursId = singleton.giveLastAddedResource().resursId;

            if (deskTypeRadioButton.Checked)
            {
                var podtip = PodtipRadnogMestaTransformator.FromDbString(deskTypeComboBox.SelectedItem.ToString());

                var builder = new RadnoMestoBuilder();
                RadnoMesto newRadnoMesto = director.BuildRadnoMesto(builder, lokacijaId, oznaka, opis, resursId, podtip);

                singleton.dodajRadnoMesto(newRadnoMesto);
            }
            else if (conferenceRadioButton.Checked)
            {
                int kapacitet = Convert.ToInt32(capacityNumeric.Value);
                bool imaOpremuZaOnlineSastanke = onlineCheckBox.Checked;
                bool imaTablu = boardCheckBox.Checked;
                bool imaTv = tvCheckBox.Checked;
                bool imaProjektor = projectorCheckBox.Checked;

                var builder = new SalaZaSastankeBuilder();
                SalaZaSastanke newSalaZaSastanke = director.BuildSala(builder,lokacijaId,oznaka,opis,resursId,kapacitet,imaProjektor,imaTablu,imaTv,imaOpremuZaOnlineSastanke);

                singleton.dodajSaluZaSastanke(newSalaZaSastanke);
            }
        }
    }
}
