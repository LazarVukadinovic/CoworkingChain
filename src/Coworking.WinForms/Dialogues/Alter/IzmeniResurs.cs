using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            changeResource();
        }
        private bool _syncingRadios;


        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);
            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locations;
        }

        private void changeResource()
        {
            nameTextBox.textBox.Text = _selektovanResurs.oznaka;
            locationComboBox.SelectedValue = _selektovanResurs.lokacijaId;
            if (_selektovanResurs.tipResursa == "radno_mesto")
            {
                deskTypeRadioButton.Checked = true;
                conferenceRadioButton.Enabled = false;
                var podTip = singleton.prikaziRadnaMestaPoId(_selektovanResurs.resursId).podtip;
                switch (podTip)
                {
                    case PodtipRadnogMesta.dedicated_desk:
                        deskTypeComboBox.SelectedItem = "Dedicated desk";
                        break;

                    case PodtipRadnogMesta.hot_desk:
                        deskTypeComboBox.SelectedItem = "Hot desk";
                        break;

                    case PodtipRadnogMesta.private_office:
                        deskTypeComboBox.SelectedItem = "Private office";
                        break;
                }
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
            aboutRichTextBox.TextButton = _selektovanResurs.opis;

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

                switch (deskTypeComboBox.SelectedItem.ToString())
                {
                    case "Dedicated desk":
                        newRadnoMesto.podtip = PodtipRadnogMesta.dedicated_desk;
                        break;

                    case "Hot desk":
                        newRadnoMesto.podtip = PodtipRadnogMesta.hot_desk;
                        break;

                    case "Private office":
                        newRadnoMesto.podtip = PodtipRadnogMesta.private_office;
                        break;
                }

                singleton.izmeniRadnoMesto(newRadnoMesto);
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
            }
        }
    }
}
