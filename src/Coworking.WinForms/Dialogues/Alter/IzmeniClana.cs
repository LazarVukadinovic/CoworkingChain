using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coworking.WinForms.Dialogues.Alter
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
