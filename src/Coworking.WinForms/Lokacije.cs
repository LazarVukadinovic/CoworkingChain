using Coworking.WinForms.Dialogues;
using System;

namespace Coworking.WinForms
{
    public partial class Lokacije : Form
    {
        public Lokacije()
        {
            InitializeComponent();
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            DodajLokaciju newLocation = new DodajLokaciju();
            newLocation.ShowDialog(this);
        }

        private void editLocationButton_Click(object sender, EventArgs e)
        {
            IzmeniLokaciju editLocation = new IzmeniLokaciju();
            editLocation.ShowDialog(this);
        }
    }
}
