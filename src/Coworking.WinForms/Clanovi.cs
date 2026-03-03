using Coworking.WinForms.Dialogues;
using System;

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            ResetComboBox();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            IzmeniClana editMember = new IzmeniClana();
            editMember.ShowDialog(this);
        }

        private void ResetComboBox()
        {
            membershipComboBox.SelectedIndex =
                locationComboBox.SelectedIndex =
                    statusComboBox.SelectedIndex = 0;
        }
    }
}
