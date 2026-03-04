using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using Coworking.WinForms.Dialogues;
using System;

namespace Coworking.WinForms
{
    public partial class Resursi : Form
    {
        IDataBase singleton;
        public Resursi()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            resourceTypeComboBox.SelectedIndex = 0;
            loadData();
            loadLocations();
        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            DodajResurs newResource = new DodajResurs();
            newResource.ShowDialog(this);
        }

        private void editResourceButton_Click(object sender, EventArgs e)
        {
            var selectedRow = (Resurs)resourceDataGridView.SelectedRows[0].DataBoundItem;
            IzmeniResurs editResource = new IzmeniResurs(selectedRow);
            editResource.ShowDialog(this);
        }

        private void resourceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadData()
        {
            var resources = singleton.prikaziSveResurse();
            resourceDataGridView.DataSource = resources;

            resourceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            int? lokacijaId = (locationComboBox.SelectedValue is int locationId && locationId != 0) ? locationId : null;
            string name = resourceTypeComboBox.SelectedItem.ToString();
            name = name == "Svi" ? null : name;

            var resources = singleton.prikaziResursePoLokacijiIPoTipu(lokacijaId, name);

            resourceDataGridView.DataSource = resources;
            resourceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void resourceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadByLocationAndType();
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadByLocationAndType();
        }
    }
}
