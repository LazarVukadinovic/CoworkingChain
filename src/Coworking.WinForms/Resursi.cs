using Coworking.WinForms.Dialogues;
using System;

namespace Coworking.WinForms
{
    public partial class Resursi : Form
    {
        public Resursi()
        {
            InitializeComponent();
            resourceTypeComboBox.SelectedIndex = locationComboBox.SelectedIndex = 0;
        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            DodajResurs newResource = new DodajResurs();
            newResource.ShowDialog(this);
        }

        private void editResourceButton_Click(object sender, EventArgs e)
        {
            IzmeniResurs editResource = new IzmeniResurs();
            editResource.ShowDialog(this);
        }
    }
}
