using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajTipClanstva : Form
    {
        public DodajTipClanstva()
        {
            InitializeComponent();
        }

        private void conferenceCheckBox_CheckedChanged()
        {
            if (conferenceCheckBox.Checked)
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = true;
            else
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = false;
        }
    }
}
