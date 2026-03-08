using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniResurs : Form
    {
        private IDataBase singleton;
        private Resurs _selektovanResurs;
        public IzmeniResurs(Resurs selektovanResurs)
        {
            InitializeComponent();
            this._selektovanResurs = selektovanResurs;
            singleton = DataBaseSingleton.vratiInstancu();
            loadLocations();
            loadResource();
        }
        private bool _syncingRadios;


        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;

            locationComboBox.SelectedValue = _selektovanResurs.lokacijaId;
        }

        private void loadResource()
        {
            nameTextBox.textBox.Text = _selektovanResurs.oznaka;
            
            if (_selektovanResurs.tipResursa == "radno_mesto")
            {
                deskTypeRadioButton.Checked = true;
                conferenceRadioButton.Enabled = false;

                var podTip = singleton.prikaziRadnaMestaPoId(_selektovanResurs.resursId).podtip;
                deskTypeComboBox.SelectedItem = podTip.ToDbString();
            }
            else if (_selektovanResurs.tipResursa == "sala")
            {
                conferenceRadioButton.Checked = true;
                deskTypeRadioButton.Enabled = false;

                var sala = singleton.prikaziSaleZaSastankePoId(_selektovanResurs.resursId);
                capacityNumeric.Value = sala.kapacitet;
                projectorCheckBox.Checked = sala.imaProjektor;
                boardCheckBox.Checked = sala.imaTablu;
                tvCheckBox.Checked = sala.imaTv;
                onlineCheckBox.Checked = sala.imaOpremuZaOnlineSastanke;
            }
            aboutRichTextBox.TextButton = _selektovanResurs.opis ?? "";
        }

        private void UpdateUI()
        {
            deskTypeLabel.Visible = deskTypeComboBox.Visible = deskTypeRadioButton.Checked;

            capacityLabel.Visible =
            capacityNumeric.Visible =
            equipmentGroupBox.Visible = conferenceRadioButton.Checked;
        }
        private void deskTypeRadioButton_CheckedChanged_1()
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

        private void conferenceRadioButton_CheckedChanged_1()
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

        private void editResourceButton_Click(object sender, EventArgs e)
        {
            _selektovanResurs.oznaka = nameTextBox.textBox.Text;
            _selektovanResurs.lokacijaId = (int)locationComboBox.SelectedValue;
            _selektovanResurs.opis = aboutRichTextBox.TextButton;

            singleton.izmeniResurs(_selektovanResurs);

            if (_selektovanResurs.tipResursa == "radno_mesto")
            {
                RadnoMesto newRadnoMesto = singleton.prikaziRadnaMestaPoId(_selektovanResurs.resursId);

                newRadnoMesto.podtip = PodtipRadnogMestaTransformator.FromDbString(deskTypeComboBox.SelectedItem.ToString());
                

                singleton.izmeniRadnoMesto(newRadnoMesto);
                MessageBox.Show("Uspešno izmenjeno radno mesto!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(_selektovanResurs.tipResursa == "sala")
            {
                SalaZaSastanke newSalaZaSastanke = singleton.prikaziSaleZaSastankePoId(_selektovanResurs.resursId);
                newSalaZaSastanke.kapacitet = Convert.ToInt32(capacityNumeric.Value);
                newSalaZaSastanke.imaOpremuZaOnlineSastanke = onlineCheckBox.Checked;
                newSalaZaSastanke.imaTablu = boardCheckBox.Checked;
                newSalaZaSastanke.imaTv = tvCheckBox.Checked;
                newSalaZaSastanke.imaProjektor = projectorCheckBox.Checked;

                singleton.izmeniSaluZaSastanke(newSalaZaSastanke);
                MessageBox.Show("Uspešno izmenjena sala za sastanke!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
