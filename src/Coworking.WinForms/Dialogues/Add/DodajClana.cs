using Coworking.Data.Providers;
using System;
using System.Net;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajClana : Form
    {
        IDataBase dataBase;
        public DodajClana()
        {
            InitializeComponent();
            dataBase = DataBaseSingleton.vratiInstancu();
            loadMemberships();
        }

        private void membershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadMemberships()
        {
            var memberships = dataBase.prikaziSveTipoveClanstva();
            membershipComboBox.DisplayMember = "naziv";
            membershipComboBox.ValueMember = "tipClanstvaId";
            membershipComboBox.DataSource = memberships;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.textBox.Text;
            var surname = lastnameTextBox.textBox.Text;
            var email = emailTextBox.textBox.Text;
            var phone = phoneTextBox.textBox.Text;
            var membershipTypeId = (int)membershipComboBox.SelectedValue;

            var membershipType = membershipComboBox.SelectedValue;
            var result = dataBase.GetTipClanstvaById(membershipTypeId);
            DateTime danas = DateTime.Now;
            double dodatniDani = Convert.ToDouble(result.trajanjeDana ?? 0);

            dataBase.dodajClana(new Coworking.Domain.Entities.Clan
            {
                ime = name,
                prezime = surname,
                mail = email,
                brTelefona = phone,
                tipClanstva = membershipTypeId,
                datumPocetka = danas.ToString("yyyy-MM-dd"),
                // Sada je bezbedno i tipovi se poklapaju
                datumKraja = danas.AddDays(dodatniDani).ToString("yyyy-MM-dd"),
                statusNaloga = "Aktivan",
                kreiran = danas.ToString("yyyy-MM-dd")
            });

        }
    }
}
