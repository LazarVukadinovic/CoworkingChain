using Coworking.Data.Providers;
using Coworking.WinForms.Dialogues;
using System;

namespace Coworking.WinForms
{
    public partial class TipoviClanstva : Form
    {
        IDataBase singleton;
        public TipoviClanstva()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            loadData();
        }

        private void addMembershipButton_Click(object sender, EventArgs e)
        {
            DodajTipClanstva newMembership = new DodajTipClanstva();
            newMembership.ShowDialog(this);
            loadData();
        }

        private void editMembershipButton_Click(object sender, EventArgs e)
        {
            IzmeniTipClanstva editMembership = new IzmeniTipClanstva();
            editMembership.ShowDialog(this);
        }

        private void membershipDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadData()
        {
            var membership = singleton.prikaziSveTipoveClanstva();
            membershipDataGridView.DataSource = membership;
            membershipDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var text = searchTextBox.textBox.Text;
            var membership = singleton.GetTipClanstvaByName(text);
            membershipDataGridView.DataSource = membership;
        }

        private void deleteMembershipButton_Click(object sender, EventArgs e)
        {
            var locationId = (int)membershipDataGridView.SelectedRows[0].Cells[0].Value;
            singleton.DeleteTipClanstva(locationId);
            loadData();
            //observer ovde?
        }
    }
}
