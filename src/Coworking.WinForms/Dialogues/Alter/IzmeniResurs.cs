using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Diagnostics;

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
                deskTypeComboBox.SelectedItem = singleton.prikaziRadnaMestaPoId(_selektovanResurs.resursId)[0].podtip;
            }
            else if (_selektovanResurs.tipResursa == "sala")
            {
                conferenceRadioButton.Checked = true;
                deskTypeRadioButton.Enabled = false;
                var sala = singleton.prikaziSaleZaSastankePoId(_selektovanResurs.resursId)[0];
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
    }
}
