using Coworking.Data.Providers;
using Coworking.Domain.Enums;
using Coworking.WinForms.Dialogues;

namespace Coworking.WinForms
{
    public partial class TipoviClanstva : Form
    {
        IDataBase singleton;
        public TipoviClanstva()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;
            loadData();
        }

        private void OnDataChanged(DataEntity entity)
        {
            if (entity == DataEntity.TipClanstva) // bilo je DataEntity.Resurs
            {
                loadData();
            }
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
            if (membershipDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi tip clanstva za brisanje.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var membershipId = (int)membershipDataGridView.SelectedRows[0].Cells[0].Value;
            var confirm = MessageBox.Show(
                "Da li sigurno želiš da obrišeš izabrani tip clanstva?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            singleton.DeleteTipClanstva(membershipId);
            loadData();
        }
    }
}



