using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.WinForms.Dialogues;
using System;
using System.Diagnostics;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Coworking.WinForms
{
    public partial class Clanovi : Form
    {
        IDataBase singleton;
        Clan _selektovanClan;
        public Clanovi()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;
            loadMemberships();
            loadLocations();
            loadStatuses();
            loadData2();
            //statusComboBox.SelectedIndex = 0;
            //ResetComboBox();

        }

        private void OnDataChanged(DataEntity entity)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDataChanged(entity)));
                return;
            }

            if (entity == DataEntity.Clan)
            {
                if (!string.IsNullOrEmpty(searchTextBox.textBox.Text))
                {
                    loadDataBySearch();
                }
                else if (locationComboBox.SelectedIndex > 0 || membershipComboBox.SelectedIndex > 0 || statusComboBox.SelectedIndex > 0)
                {
                    loadData();
                }
                else
                {
                    loadData2();
                }
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            DodajClana newMember = new DodajClana();
            newMember.ShowDialog(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //ResetComboBox();
            loadDataBySearch();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            _selektovanClan = (Clan)memberDataGridView.SelectedRows[0].DataBoundItem;
            IzmeniClana editMember = new IzmeniClana(_selektovanClan);
            editMember.ShowDialog(this);
        }

        private void ResetComboBox()
        {
            membershipComboBox.SelectedIndex =
                locationComboBox.SelectedIndex =
                    statusComboBox.SelectedIndex = 0;
        }

        private void membershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadMemberships()
        {
            var memberships = singleton.prikaziSveTipoveClanstva();

            var membershipsForCombo = new List<TipClanstva>(memberships);

            membershipsForCombo.Insert(0, new TipClanstva { tipClanstvaId = 0, naziv = "Svi" });

            membershipComboBox.DisplayMember = "naziv";
            membershipComboBox.ValueMember = "tipClanstvaId";
            membershipComboBox.DataSource = membershipsForCombo;
        }

        private void loadLocations()
        {
            var locations = singleton.prikaziLokacije(false);

            var locationsForCombo = new List<Lokacija>(locations);

            locationsForCombo.Insert(0, new Lokacija { lokacijaId = 0, naziv = "Sve" });

            locationComboBox.DisplayMember = "naziv";
            locationComboBox.ValueMember = "lokacijaId";
            locationComboBox.DataSource = locationsForCombo;
        }

        private void loadStatuses()
        {
            var statuses = new List<string> { "Svi", "Aktivan", "Neaktivan", "Suspendovan" };
            statusComboBox.DataSource = statuses;
        }

        private void loadData()
        {
            // 1. Zapamti ID pre nego što sve nestane
            int? sačuvaniId = null;
            if (memberDataGridView.SelectedRows.Count > 0)
            {
                sačuvaniId = ((Clan)memberDataGridView.SelectedRows[0].DataBoundItem).clanId;
            }

            // --- Tvoja logika za filtere ---
            int? lokacijaId = (locationComboBox.SelectedValue is int locId && locId != 0) ? locId : null;
            int? clanstvoId = (membershipComboBox.SelectedValue is int memId && memId != 0) ? memId : null;
            string status = statusComboBox.SelectedItem?.ToString() == "Svi" ? null : statusComboBox.SelectedItem?.ToString();

            var clanovi = singleton.PrikaziClanoveFiltrirano(lokacijaId, clanstvoId, status);

            // 2. Osveži podatke
            memberDataGridView.DataSource = null;
            memberDataGridView.DataSource = clanovi;

            // 3. Forsiraj selekciju nakon što se završi Binding
            if (sačuvaniId.HasValue)
            {
                this.BeginInvoke(new Action(() => {
                    foreach (DataGridViewRow row in memberDataGridView.Rows)
                    {
                        if (((Clan)row.DataBoundItem).clanId == sačuvaniId)
                        {
                            memberDataGridView.ClearSelection();
                            row.Selected = true;
                            if (memberDataGridView.Columns.Count > 0)
                                memberDataGridView.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }));
            }
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void statusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData2()
        {
            var members = singleton.prikaziClanove();
            memberDataGridView.DataSource = members;
        }

        private void deleteMemberButton2_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi clana za brisanje.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selektovanClan = (Clan)memberDataGridView.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Da li sigurno želiš da obrišeš clana '{_selektovanClan.ime} {_selektovanClan.prezime}'?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            singleton.obrisiClana(_selektovanClan.clanId);
            loadData();
        }

        private void loadDataBySearch()
        {
            var searchTerm = searchTextBox.textBox.Text;
            if (string.IsNullOrEmpty(searchTerm))
            {
                loadData2();
                return;
            }
            var clanovi = singleton.vratiClanovePoImenu(searchTerm);
            memberDataGridView.DataSource = null;
            memberDataGridView.DataSource = clanovi;
            memberDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}



