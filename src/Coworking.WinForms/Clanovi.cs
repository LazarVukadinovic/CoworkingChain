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
    public partial class Clanovi : Form
    {
        public Clanovi()
        {
            InitializeComponent();
            ResetComboBox();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            DodajClana newMember = new DodajClana();
            newMember.ShowDialog(this);
        }

        private void ResetComboBox()
        {
            membershipComboBox.SelectedIndex =
                locationComboBox.SelectedIndex =
                    statusComboBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ResetComboBox();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            IzmeniClana editMember = new IzmeniClana();
            editMember.ShowDialog(this);
        }
    }
}
