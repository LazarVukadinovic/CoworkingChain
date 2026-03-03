using Coworking.Data.Providers;
using ReaLTaiizor.Controls;
using System;
using System.Diagnostics;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniLokaciju : Form
    {
        IDataBase singleton;
        public IzmeniLokaciju()
        {
            InitializeComponent();
            // TODO
            // sve komponente poraju da se popune podacima iz baze
            singleton = DataBaseSingleton.vratiInstancu();
            loadLocations();
        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var membership = singleton.GetLokacijaById((int)foreverComboBox1.SelectedItem);
            nameTextBox.textBox.Text = membership.naziv;
            addressTextBox.textBox.Text = membership.adresa;
            cityTextBox.textBox.Text = membership.grad;
            workTextBox.textBox.Text = membership.radnoVreme;
            capacityNumericUpDown.Value = (long)membership.maxKapacitet;
            capacityNumericUpDown.Refresh();
            commentRichTextBox.TextButton = membership.opis;
        }

        private void loadLocations()
        {
            var memberships = singleton.prikaziLokacije(false);
            foreach (var membership in memberships)
                foreverComboBox1.Items.Add(membership.lokacijaId);
        }

        private void editLocationButton_Click(object sender, EventArgs e)
        {
            var id = foreverComboBox1.SelectedItem.ToString();
            var membership = singleton.GetLokacijaById(int.Parse(id));
            membership.naziv = nameTextBox.textBox.Text;
            membership.adresa = addressTextBox.textBox.Text;
            membership.grad = cityTextBox.textBox.Text;
            membership.radnoVreme = workTextBox.textBox.Text;
            membership.maxKapacitet = Convert.ToInt32(capacityNumericUpDown.Value);
            membership.opis = commentRichTextBox.TextButton;

            singleton.izmeniLokaciju(membership);
            loadLocations();
        }
    }
}
