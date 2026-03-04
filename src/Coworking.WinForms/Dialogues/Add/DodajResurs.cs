using Coworking.Data.Providers;
using System;

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
    }
}
