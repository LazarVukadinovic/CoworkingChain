using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniClana : Form
    {
        IDataBase singleton;
        private Clan _selektovanClan;
        public IzmeniClana(Clan selektovanClan)
        {
            InitializeComponent();
            _selektovanClan = selektovanClan;
            singleton = DataBaseSingleton.vratiInstancu();
            loadSelectedMember();
            loadMemberships();
            loadStatus();
            loadDate();
        }

        private void loadSelectedMember()
        {
            fillNameLabel.Text = _selektovanClan.ime;
            fillLastnameLabel.Text = _selektovanClan.prezime;
            emailTextBox.TextButton = _selektovanClan.mail;
            phoneTextBox.TextButton = _selektovanClan.brTelefona;
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();
            membershipComboBox.DisplayMember = "naziv";
            membershipComboBox.ValueMember = "tipClanstvaId";
            membershipComboBox.DataSource = memberships;

            membershipComboBox.SelectedValue = _selektovanClan.tipClanstva;
        }

        private void loadStatus()
        {
            statusComboBox.SelectedItem = _selektovanClan.statusNaloga;
        }

        private void loadDate()
        {
            if (DateTime.TryParse(_selektovanClan.datumPocetka, out DateTime poc))
                startDateDateTime.Value = poc.Date;
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            int membershipTypeId = (int)membershipComboBox.SelectedValue;
            var result = singleton.GetTipClanstvaById(membershipTypeId);
            double dodatniDani = Convert.ToDouble(result.trajanjeDana ?? 0);

            DateTime start = startDateDateTime.Value;

            _selektovanClan.tipClanstva = membershipTypeId;
            _selektovanClan.datumPocetka = start.ToString("yyyy-MM-dd");
            _selektovanClan.datumKraja = start.AddDays(dodatniDani).ToString("yyyy-MM-dd");
            _selektovanClan.brTelefona = phoneTextBox.textBox.Text;
            _selektovanClan.statusNaloga = statusComboBox.SelectedItem.ToString();

            singleton.izmeniClana(_selektovanClan);
        }
    }
}
