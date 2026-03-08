using Coworking.Data.Providers;
using System.Globalization;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniTipClanstva : Form
    {
        IDataBase singleton;
        public IzmeniTipClanstva()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            loadMemberships();
        }

        private void conferenceCheckBox_CheckedChanged()
        {
            conferenceTimeNumeric.Visible = conferenceTimeLabel.Visible = conferenceCheckBox.Checked;
        }

        private void editMembershipButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.SelectedValue == null)
            {
                MessageBox.Show("Izaberi tip članstva.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(priceTextBox.TextButton, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out float cena))
            {
                MessageBox.Show("Neispravan format cene.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var membership = singleton.GetTipClanstvaById((int)nameTextBox.SelectedValue);
            membership.naziv = cyberTextBox1.TextButton;
            membership.cena = cena;
            membership.maxSatiRezervacijeMesecno = (int)monthlyNumeric1.Value;
            membership.trajanjeDana = (int)durationNumeric.Value;
            membership.dozvoljenaSala = conferenceCheckBox.Checked;
            membership.satiSaleMesecno = conferenceCheckBox.Checked ? (int)conferenceTimeNumeric.Value : 0;

            singleton.updateTipClanstva(membership);

            MessageBox.Show("Tip članstva uspešno izmenjen!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void membershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameTextBox.SelectedValue == null) return;

            var membership = singleton.GetTipClanstvaById((int)nameTextBox.SelectedValue);
            if (membership == null) return;

            membershipID.Text = $"ID paketa: {membership.tipClanstvaId}";
            cyberTextBox1.TextButton = membership.naziv ?? "";
            priceTextBox.TextButton = membership.cena?.ToString(CultureInfo.InvariantCulture) ?? "0";
            monthlyNumeric1.Value = (long)(membership.maxSatiRezervacijeMesecno ?? 1);
            durationNumeric.Value = (long)(membership.trajanjeDana ?? 1);
            conferenceCheckBox.Checked = membership.dozvoljenaSala ?? false;

            if (conferenceCheckBox.Checked)
                conferenceTimeNumeric.Value = (long)(membership.satiSaleMesecno ?? 1);
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();
            nameTextBox.DisplayMember = "naziv";
            nameTextBox.ValueMember = "tipClanstvaId";
            nameTextBox.DataSource = memberships;
        }
    }
}
