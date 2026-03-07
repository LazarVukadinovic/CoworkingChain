using Coworking.Data.Providers;
using ReaLTaiizor.Controls;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniLokaciju : Form
    {
        IDataBase singleton;
        public IzmeniLokaciju()
        {
            InitializeComponent();
            singleton = DataBaseSingleton.vratiInstancu();
            loadLocations();
        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var membership = singleton.GetLokacijaById((int)foreverComboBox1.SelectedItem);
            //nameTextBox.textBox.Text = membership.naziv;
            //addressTextBox.textBox.Text = membership.adresa;
            //cityTextBox.textBox.Text = membership.grad;
            //workTextBox.textBox.Text = membership.radnoVreme;
            //capacityNumericUpDown.Value = (long)membership.maxKapacitet;
            //capacityNumericUpDown.Refresh();
            //commentRichTextBox.TextButton = membership.opis;

            if (foreverComboBox1.SelectedValue == null) return;

            var lokacija = singleton.GetLokacijaById((int)foreverComboBox1.SelectedValue);
            if (lokacija == null) return;

            membershipID.Text = $"ID lokacije: {lokacija.lokacijaId}";
            nameTextBox.TextButton = lokacija.naziv ?? "";
            addressTextBox.TextButton = lokacija.adresa ?? "";
            cityTextBox.TextButton = lokacija.grad ?? "";
            workTextBox.TextButton = lokacija.radnoVreme ?? "";
            capacityNumericUpDown.Value = (long)(lokacija.maxKapacitet ?? 0);
            commentRichTextBox.TextButton = lokacija.opis ?? "";
        }

        private void loadLocations()
        {
            //var memberships = singleton.prikaziLokacije(false);
            //foreach (var membership in memberships)
            //    foreverComboBox1.Items.Add(membership.lokacijaId);

            var locations = singleton.prikaziLokacije(false);
            foreverComboBox1.DisplayMember = "naziv";
            foreverComboBox1.ValueMember = "lokacijaId";
            foreverComboBox1.DataSource = locations;
        }

        private void editLocationButton_Click(object sender, EventArgs e)
        {
            //var id = foreverComboBox1.SelectedItem.ToString();
            //var membership = singleton.GetLokacijaById(int.Parse(id));
            //membership.naziv = nameTextBox.textBox.Text;
            //membership.adresa = addressTextBox.textBox.Text;
            //membership.grad = cityTextBox.textBox.Text;
            //membership.radnoVreme = workTextBox.textBox.Text;
            //membership.maxKapacitet = Convert.ToInt32(capacityNumericUpDown.Value);
            //membership.opis = commentRichTextBox.TextButton;

            //singleton.izmeniLokaciju(membership);
            //loadLocations();

            if (foreverComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Izaberi lokaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lokacija = singleton.GetLokacijaById((int)foreverComboBox1.SelectedValue);
            lokacija.naziv = nameTextBox.TextButton;
            lokacija.adresa = addressTextBox.TextButton;
            lokacija.grad = cityTextBox.TextButton;
            lokacija.radnoVreme = workTextBox.TextButton;
            lokacija.maxKapacitet = Convert.ToInt32(capacityNumericUpDown.Value);
            lokacija.opis = commentRichTextBox.TextButton;

            singleton.izmeniLokaciju(lokacija);

            MessageBox.Show("Lokacija uspešno izmenjena!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
