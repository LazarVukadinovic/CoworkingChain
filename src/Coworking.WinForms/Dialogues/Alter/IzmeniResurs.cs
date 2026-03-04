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

            // TODO
            // treba popuniti komponente odgovarajucim podacima iz baze
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

        private void changeResource()
        {
            nameTextBox.textBox.Text = _selektovanResurs.oznaka;
            locationComboBox.SelectedValue = _selektovanResurs.lokacijaId;
            if (_selektovanResurs.tipResursa == "radno_mesto")
            {
                deskTypeRadioButton.Checked = true;
                deskTypeComboBox.SelectedItem = _selektovanResurs.opis;
            }
            else if (_selektovanResurs.tipResursa == "sala")
            {
                conferenceRadioButton.Checked = true;
                
            }
            aboutRichTextBox.TextButton = _selektovanResurs.opis;



        }
    }
}
