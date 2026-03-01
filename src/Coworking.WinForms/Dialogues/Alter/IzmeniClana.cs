using System;

namespace Coworking.WinForms.Dialogues
{
    public partial class IzmeniClana : Form
    {
        public IzmeniClana()
        {
            InitializeComponent();
            // TODO
            // popunjava se iz baze
            fillNameLabel.Text = "Dummy";
            fillLastnameLabel.Text = "Dummy2";
            emailTextBox.TextButton = "dummy@gmail.com";
            endDateDateTime.Value = startDateDateTime.Value.AddDays(30);
        }
    }
}
