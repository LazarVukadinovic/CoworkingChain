using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniTipClanstva : Form
    {
        public IzmeniTipClanstva()
        {
            InitializeComponent();
            // TODO
            // popunjavanje komponenti podacima iz baze
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
