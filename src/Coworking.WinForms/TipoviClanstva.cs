using Coworking.WinForms.Dialogues;
using System;

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
