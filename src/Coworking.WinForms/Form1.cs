using Coworking.Data.Providers;

namespace Coworking.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAA");
            var dataFacade = new DataBaseFacade();
            var resursi = dataFacade.PrikaziResursePoTipu(1);
            dataGridView1.DataSource = resursi;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
