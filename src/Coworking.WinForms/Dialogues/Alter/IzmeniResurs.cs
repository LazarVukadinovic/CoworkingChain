using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniResurs : Form
    {
        public IzmeniResurs()
        {
            InitializeComponent();
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
    }
}
