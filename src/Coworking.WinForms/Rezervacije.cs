using Coworking.WinForms.Dialogues;
using System;

namespace Coworking.WinForms
{
    public partial class Rezervacije : Form
    {
        public Rezervacije()
        {
            InitializeComponent();
            locationComboBox.SelectedIndex = 0;
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            DodajRezervaciju newReservation = new DodajRezervaciju();
            newReservation.ShowDialog(this);
        }

        private void editReservationButton_Click(object sender, EventArgs e)
        {
            IzmeniRezervaciju editReservation = new IzmeniRezervaciju();
            editReservation.ShowDialog(this);
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            if (currentLocationCheckBox.Checked)
            {
                // zakljucava comboBox na nasu lokaciju
                locationComboBox.Enabled = false;

                // TODO:
                // setovanje locationComboBox-a na trenutnu lokaciju
            }
            else
            {
                locationComboBox.Enabled = true;
            }
        }

        private bool _syncingRadios;
        private void userRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (userRadioButton.Checked)
            {
                _syncingRadios = true;
                locationDateRadioButton.Checked = false;
                searchButton.Location = new Point(976, 25);
                _syncingRadios = false;
            }

            UpdateUI();
        }

        private void locationDateRadioButton_CheckedChanged()
        {
            if (_syncingRadios) return;

            if (locationDateRadioButton.Checked)
            {
                _syncingRadios = true;
                userRadioButton.Checked = false;
                searchButton.Location = new Point(778, 25);
                _syncingRadios = false;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            // pretraga po korisniku i statusu rezervacije
            userLabel.Visible = userTextBox.Visible = userRadioButton.Checked;

            reservedCheckBox.Visible =
            confirmedCheckBox.Visible =
            cancelledCheckBox.Visible =
            doneCheckBox.Visible = userRadioButton.Checked;

            // pretraga po lokaciji i danu
            locationLabel.Visible = locationComboBox.Visible = locationDateRadioButton.Checked;

            dateLabel.Visible = dateDateTime.Visible = locationDateRadioButton.Checked;

            // prikaz dugmeta
            searchButton.Visible = userRadioButton.Checked || locationDateRadioButton.Checked;
        }
    }
}
