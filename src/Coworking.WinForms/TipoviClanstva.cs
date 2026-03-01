using Coworking.WinForms.Dialogues;
using Coworking.WinForms.Dialogues.Alter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coworking.WinForms
{
    public partial class TipoviClanstva : Form
    {
        public TipoviClanstva()
        {
            InitializeComponent();
        }

        private void addMembershipButton_Click(object sender, EventArgs e)
        {
            DodajTipClanstva newMembership = new DodajTipClanstva();
            newMembership.ShowDialog(this);
        }

        private void editMembershipButton_Click(object sender, EventArgs e)
        {
            IzmeniTipClanstva editMembership = new IzmeniTipClanstva();
            editMembership.ShowDialog(this);
        }
    }
}
