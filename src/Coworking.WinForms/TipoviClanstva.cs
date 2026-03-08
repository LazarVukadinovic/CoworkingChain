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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDataChanged(entity)));
                return;
            }

            if (entity == DataEntity.TipClanstva)
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
            // 1. Zapamti koji je red bio selektovan pre osvežavanja
            int? sačuvaniId = null;
            if (membershipDataGridView.SelectedRows.Count > 0)
            {
                // Pretpostavljam da je prva kolona ID tipa članstva
                sačuvaniId = (int)membershipDataGridView.SelectedRows[0].Cells[0].Value;
            }

            // 2. Povuci nove podatke
            var membership = singleton.prikaziSveTipoveClanstva();

            // 3. Osveži tabelu
            membershipDataGridView.DataSource = null; // Reset
            membershipDataGridView.DataSource = membership;
            membershipDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 4. VRATI SELEKCIJU tamo gde je bila
            if (sačuvaniId.HasValue)
            {
                foreach (DataGridViewRow row in membershipDataGridView.Rows)
                {
                    if ((int)row.Cells[0].Value == sačuvaniId.Value)
                    {
                        membershipDataGridView.ClearSelection(); // Skloni selekciju sa prvog reda
                        row.Selected = true;

                        // Fokusiraj "ćeliju" da bi i strelica sa strane bila na pravom mestu
                        if (membershipDataGridView.Columns.Count > 0)
                            membershipDataGridView.CurrentCell = row.Cells[0];

                        break;
                    }
                }
            }
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



