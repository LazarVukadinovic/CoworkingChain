using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniTipClanstva : Form
    {
        IDataBase singleton;
        public IzmeniTipClanstva()
        {
            InitializeComponent();
            // TODO
            // popunjavanje komponenti podacima iz baze
            singleton = DataBaseSingleton.vratiInstancu();
            loadMemberships();
        }

        private void conferenceCheckBox_CheckedChanged()
        {
            if (conferenceCheckBox.Checked)
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = true;
            else
                conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = false;
        }

        private void editMembershipButton_Click(object sender, EventArgs e)
        {
            var id = nameTextBox.SelectedItem.ToString();
            var membership = singleton.GetTipClanstvaById(int.Parse(id));
            membership.naziv = cyberTextBox1.textBox.Text;
            membership.cena = float.Parse(priceTextBox.textBox.Text, CultureInfo.InvariantCulture);
            membership.maxSatiRezervacijeMesecno = (int)monthlyNumeric1.Value;
            membership.trajanjeDana = (int)durationNumeric.Value;
            if (conferenceCheckBox.Checked == false)
            {
                membership.dozvoljenaSala = false;
                membership.satiSaleMesecno = 0;
            }
            else
            {
                membership.dozvoljenaSala = true;
                membership.satiSaleMesecno = (int)conferenceTimeNumeric.Value;
            }

            singleton.updateTipClanstva(membership);

        }

        private void membershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var membership = singleton.GetTipClanstvaById((int)nameTextBox.SelectedItem);
            cyberTextBox1.textBox.Text = membership.naziv;
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();
            foreach (var membership in memberships)
                nameTextBox.Items.Add(membership.tipClanstvaId);
        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
