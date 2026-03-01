using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniRezervaciju : Form
    {
        public IzmeniRezervaciju()
        {
            InitializeComponent();
            // TODO
            // mora iz baze da se povuku podaci o rezervaciji i da se prikazu
            userNameLabel.Text = "Dummy";
        }

        private void currentLocationCheckBox_CheckedChanged()
        {
            if (currentLocationCheckBox.Checked)
            {
                locationComboBox.Enabled = false;
                // TODO:
                // prikaz trenutne lokacije u comboBox-u
            }
            else
            {
                locationComboBox.Enabled = true;
            }
        }
    }
}
