using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coworking.WinForms.Dialogues.Alter
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
