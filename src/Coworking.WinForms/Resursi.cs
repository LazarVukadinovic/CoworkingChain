using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.Domain.Enums;
using Coworking.WinForms.Dialogues;

namespace Coworking.WinForms
{
    public partial class Resursi : Form
    {
        private readonly IDataBase singleton;

        public Resursi()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            singleton.DataChanged += OnDataChanged;

            // Inicijalizacija
            loadLocations();
            resourceTypeComboBox.SelectedIndex = 0;
            loadByLocationAndType();
        }

        private void OnDataChanged(DataEntity entity)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => OnDataChanged(entity)));
                return;
            }

            if (entity == DataEntity.Resurs)
            {
                // Koristimo zaključavanje selekcije prilikom automatskog osvežavanja
                RefreshWithSelection(() => loadByLocationAndType());
            }
        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            DodajResurs newResource = new DodajResurs();
            if (newResource.ShowDialog(this) == DialogResult.OK)
            {
                loadByLocationAndType();
            }
        }

        private void editResourceButton_Click(object sender, EventArgs e)
        {
            if (resourceDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi resurs za izmenu.", "Izmena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (Resurs)resourceDataGridView.SelectedRows[0].DataBoundItem;
            IzmeniResurs editResource = new IzmeniResurs(selectedRow);

            RefreshWithSelection(() => {
                editResource.ShowDialog(this);
                loadByLocationAndType();
            });
        }

        private void deleteResourceButton_Click(object sender, EventArgs e)
        {
            if (resourceDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberi resurs za brisanje.", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = (Resurs)resourceDataGridView.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Da li sigurno želiš da obrišeš resurs '{selectedRow.oznaka}'?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                singleton.obrisiResurs(selectedRow.resursId);
                loadByLocationAndType();
            }
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

        private void loadByLocationAndType()
        {
            int? lokacijaId = (locationComboBox.SelectedValue is int id && id != 0) ? id : null;
            string name = resourceTypeComboBox.SelectedItem?.ToString();
            name = (name == "Svi" || name == null) ? null : name;

            var resources = singleton.prikaziResursePoLokacijiIPoTipu(lokacijaId, name);

            resourceDataGridView.DataSource = null; // Reset da bi Binding uhvatio promene
            resourceDataGridView.DataSource = resources;
            resourceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshWithSelection(Action updateLogic)
        {
            int? sačuvaniId = null;
            int? prviVidljiviIndex = null;

            if (resourceDataGridView.SelectedRows.Count > 0 &&
                resourceDataGridView.SelectedRows[0].DataBoundItem is Resurs r)
            {
                sačuvaniId = r.resursId;
                prviVidljiviIndex = resourceDataGridView.FirstDisplayedScrollingRowIndex;
            }

            // Isključujemo grid privremeno da sprečimo reset fokusa
            resourceDataGridView.Enabled = false;

            updateLogic();

            if (sačuvaniId.HasValue)
            {
                this.BeginInvoke(new Action(() => {
                    try
                    {
                        foreach (DataGridViewRow row in resourceDataGridView.Rows)
                        {
                            if (row.DataBoundItem is Resurs res && res.resursId == sačuvaniId)
                            {
                                resourceDataGridView.ClearSelection();

                                if (prviVidljiviIndex.HasValue && prviVidljiviIndex < resourceDataGridView.RowCount)
                                    resourceDataGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, prviVidljiviIndex.Value);

                                row.Selected = true;
                                if (resourceDataGridView.Columns.Count > 0)
                                    resourceDataGridView.CurrentCell = row.Cells[0];
                                break;
                            }
                        }
                    }
                    finally
                    {
                        resourceDataGridView.Enabled = true;
                    }
                }));
            }
            else
            {
                resourceDataGridView.Enabled = true;
            }
        }

        private void resourceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kada korisnik ručno menja filter, obično ne želimo "zaključavanje" 
            // jer se set podataka drastično menja, ali loadByLocationAndType mora da radi.
            loadByLocationAndType();
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadByLocationAndType();
        }
    }
}