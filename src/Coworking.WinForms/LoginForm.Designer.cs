namespace Coworking.WinForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pbLogo = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            pnlHorizLine = new Panel();
            lblSubHeading = new Label();
            lblHeading = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 130, 220);
            panel1.Controls.Add(pbLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 120);
            panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.InitialImage = Properties.Resources.logo;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(599, 117);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(pnlHorizLine);
            panel2.Controls.Add(lblSubHeading);
            panel2.Controls.Add(lblHeading);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 394);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(303, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(271, 48);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Izlaz";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += this.btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(70, 130, 220);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(25, 311);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(271, 48);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Prijava";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightCyan;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(25, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "  Lozinka";
            txtPassword.Size = new Size(549, 30);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Location = new Point(25, 211);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Lozinka:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.LightCyan;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(25, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Korisničko ime";
            txtUsername.Size = new Size(549, 30);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.Location = new Point(25, 132);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(139, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Korisničko ime:";
            // 
            // pnlHorizLine
            // 
            pnlHorizLine.BackColor = Color.Silver;
            pnlHorizLine.Location = new Point(25, 111);
            pnlHorizLine.Name = "pnlHorizLine";
            pnlHorizLine.Size = new Size(549, 2);
            pnlHorizLine.TabIndex = 2;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Segoe UI", 9F);
            lblSubHeading.ForeColor = Color.DimGray;
            lblSubHeading.Location = new Point(204, 79);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(190, 20);
            lblSubHeading.TabIndex = 1;
            lblSubHeading.Text = "Prijavite se kako bi nastavili";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeading.Location = new Point(212, 30);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(175, 41);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Dobrodošli";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(599, 514);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            Shown += LoginForm_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbLogo;
        private Panel panel2;
        private Label lblHeading;
        private Panel pnlHorizLine;
        private Label lblSubHeading;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnCancel;
        private Button btnLogin;
    }
}
