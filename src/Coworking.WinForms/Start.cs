namespace Coworking.WinForms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            comboBox_configFile.Items.Add("config1.txt");
            comboBox_configFile.Items.Add("config2.txt");

        }

        private void pokreni_btn_Click(object sender, EventArgs e)
        {
            Main mainPage = new Main(this);
            mainPage.FormClosed += (s, args) => this.Close();

            string configFileName = comboBox_configFile.Text;
            var configFilePath = Path.Combine(AppContext.BaseDirectory, configFileName);

            // TODO: pozivanje DB modela za povezivanje na konekcioni string
            this.Hide();
            mainPage.Show();
        }
    }
}
