using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.WinForms
{
    public partial class Form1 : Form
    {
        IDataBase data;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = DataBaseSingleton.vratiInstancu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            var found = data.getAdminByUsername(username, password);
            textBox1.Text = found.ToString();
        }
    }
}
