using System.Drawing.Drawing2D;

namespace Coworking.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            ApplyRadius(btnLogin, 10);
            ApplyRadius(btnCancel, 10);
            ApplyRadius(txtUsername, 5);
            ApplyRadius(txtPassword, 5);
        }

        private static void ApplyRadius(Control c, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(c.Width - d, 0, d, d, 270, 90);
            path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            path.AddArc(0, c.Height - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }

    }
}
