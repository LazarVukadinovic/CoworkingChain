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
        }

        private void loadSelectedMember()
        {
            fillNameLabel.Text = _selektovanClan.ime;
            fillLastnameLabel.Text = _selektovanClan.prezime;
            emailTextBox.TextButton = _selektovanClan.mail;
            endDateDateTime.Value = startDateDateTime.Value.AddDays(30);
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();
            membershipComboBox.DisplayMember = "naziv";
            membershipComboBox.ValueMember = "tipClanstvaId";
            membershipComboBox.DataSource = memberships;
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            _selektovanClan.tipClanstva = (int?)membershipComboBox.SelectedValue;
            _selektovanClan.datumPocetka = startDateDateTime.Value.ToString("yyyy-MM-dd");
            _selektovanClan.datumKraja = endDateDateTime.Value.ToString("yyyy-MM-dd");
            _selektovanClan.brTelefona = phoneTextBox.textBox.Text;
            _selektovanClan.statusNaloga = statusComboBox.SelectedItem.ToString();

            singleton.izmeniClana(_selektovanClan);
        }
    }
}
