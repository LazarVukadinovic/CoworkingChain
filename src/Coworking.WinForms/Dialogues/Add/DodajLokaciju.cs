using Coworking.Data.Providers;

namespace Coworking.WinForms.Dialogues
{
    public partial class DodajLokaciju : Form
    {
        IDataBase database;
        public DodajLokaciju()
        {
            InitializeComponent();
            database = DataBaseSingleton.vratiInstancu();
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            var naziv = nameTextBox.textBox.Text;
            var adresa = addressTextBox.textBox.Text;
            var grad = cityTextBox.textBox.Text;
            var radnoVreme = workTextBox.textBox.Text;
            var maxKapacitet = (int)capacityNumericUpDown.Value;
            var opis = commentRichTextBox.TextButton;

            database.dodajLokaciju(new Coworking.Domain.Entities.Lokacija
            {
                naziv = naziv,
                adresa = adresa,
                grad = grad,
                radnoVreme = radnoVreme,
                maxKapacitet = maxKapacitet,
                opis = opis
            });

            MessageBox.Show("Uspešno dodata lokacija!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
