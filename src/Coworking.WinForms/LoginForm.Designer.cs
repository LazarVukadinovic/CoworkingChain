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
            passwordTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            passwordLabel = new ReaLTaiizor.Controls.HeaderLabel();
            usernameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            headerSubLabel = new ReaLTaiizor.Controls.ForeverLabel();
            exitButton = new ReaLTaiizor.Controls.CyberButton();
            loginButton = new ReaLTaiizor.Controls.CyberButton();
            usernameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            pnlHorizLine = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 68);
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
            pbLogo.Size = new Size(599, 120);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 52, 68);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(passwordLabel);
            panel2.Controls.Add(usernameLabel);
            panel2.Controls.Add(headerLabel);
            panel2.Controls.Add(headerSubLabel);
            panel2.Controls.Add(exitButton);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(pnlHorizLine);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 410);
            panel2.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Alpha = 20;
            passwordTextBox.BackColor = Color.Transparent;
            passwordTextBox.Background_WidthPen = 3F;
            passwordTextBox.BackgroundPen = true;
            passwordTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            passwordTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            passwordTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            passwordTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            passwordTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            passwordTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            passwordTextBox.Font = new Font("Arial", 12F);
            passwordTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            passwordTextBox.Lighting = false;
            passwordTextBox.LinearGradientPen = false;
            passwordTextBox.Location = new Point(191, 220);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Password = true;
            passwordTextBox.PenWidth = 15;
            passwordTextBox.RGB = false;
            passwordTextBox.Rounding = true;
            passwordTextBox.RoundingInt = 60;
            passwordTextBox.Size = new Size(383, 50);
            passwordTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            passwordTextBox.TabIndex = 18;
            passwordTextBox.Tag = "Cyber";
            passwordTextBox.TextButton = "";
            passwordTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            passwordTextBox.Timer_RGB = 300;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(255, 255, 255);
            passwordLabel.Location = new Point(25, 230);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(94, 25);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Lozinka:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            usernameLabel.Location = new Point(25, 161);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(160, 25);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Korisničko ime:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(222, 31);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(170, 36);
            headerLabel.TabIndex = 15;
            headerLabel.Text = "Dobrodošli";
            // 
            // headerSubLabel
            // 
            headerSubLabel.AutoSize = true;
            headerSubLabel.BackColor = Color.Transparent;
            headerSubLabel.Font = new Font("Segoe UI", 9F);
            headerSubLabel.ForeColor = Color.LightGray;
            headerSubLabel.Location = new Point(211, 77);
            headerSubLabel.Name = "headerSubLabel";
            headerSubLabel.Size = new Size(190, 20);
            headerSubLabel.TabIndex = 14;
            headerSubLabel.Text = "Prijavite se kako bi nastavili";
            // 
            // exitButton
            // 
            exitButton.Alpha = 20;
            exitButton.BackColor = Color.Transparent;
            exitButton.Background = true;
            exitButton.Background_WidthPen = 4F;
            exitButton.BackgroundPen = true;
            exitButton.ColorBackground = Color.FromArgb(37, 52, 68);
            exitButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            exitButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            exitButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            exitButton.ColorLighting = Color.FromArgb(29, 200, 238);
            exitButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            exitButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            exitButton.Cursor = Cursors.Hand;
            exitButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Default;
            exitButton.Effect_1 = true;
            exitButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            exitButton.Effect_1_Transparency = 25;
            exitButton.Effect_2 = true;
            exitButton.Effect_2_ColorBackground = Color.White;
            exitButton.Effect_2_Transparency = 20;
            exitButton.Font = new Font("Arial", 11F);
            exitButton.ForeColor = Color.FromArgb(245, 245, 245);
            exitButton.Lighting = false;
            exitButton.LinearGradient_Background = false;
            exitButton.LinearGradientPen = false;
            exitButton.Location = new Point(303, 315);
            exitButton.Name = "exitButton";
            exitButton.PenWidth = 15;
            exitButton.Rounding = true;
            exitButton.RoundingInt = 70;
            exitButton.Size = new Size(271, 62);
            exitButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            exitButton.TabIndex = 13;
            exitButton.Tag = "Cyber";
            exitButton.TextButton = "Izlaz";
            exitButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            exitButton.Timer_Effect_1 = 5;
            exitButton.Timer_RGB = 300;
            exitButton.Click += exitButton_Click;
            // 
            // loginButton
            // 
            loginButton.Alpha = 20;
            loginButton.BackColor = Color.Transparent;
            loginButton.Background = true;
            loginButton.Background_WidthPen = 4F;
            loginButton.BackgroundPen = true;
            loginButton.ColorBackground = Color.FromArgb(37, 52, 68);
            loginButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            loginButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            loginButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            loginButton.ColorLighting = Color.FromArgb(29, 200, 238);
            loginButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            loginButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            loginButton.Cursor = Cursors.Hand;
            loginButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Default;
            loginButton.Effect_1 = true;
            loginButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            loginButton.Effect_1_Transparency = 25;
            loginButton.Effect_2 = true;
            loginButton.Effect_2_ColorBackground = Color.White;
            loginButton.Effect_2_Transparency = 20;
            loginButton.Font = new Font("Arial", 11F);
            loginButton.ForeColor = Color.FromArgb(245, 245, 245);
            loginButton.Lighting = false;
            loginButton.LinearGradient_Background = false;
            loginButton.LinearGradientPen = false;
            loginButton.Location = new Point(25, 315);
            loginButton.Name = "loginButton";
            loginButton.PenWidth = 15;
            loginButton.Rounding = true;
            loginButton.RoundingInt = 70;
            loginButton.Size = new Size(272, 62);
            loginButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            loginButton.TabIndex = 12;
            loginButton.Tag = "Cyber";
            loginButton.TextButton = "Prijava";
            loginButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            loginButton.Timer_Effect_1 = 5;
            loginButton.Timer_RGB = 300;
            loginButton.Click += loginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Alpha = 20;
            usernameTextBox.BackColor = Color.Transparent;
            usernameTextBox.Background_WidthPen = 3F;
            usernameTextBox.BackgroundPen = true;
            usernameTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            usernameTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            usernameTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            usernameTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            usernameTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            usernameTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            usernameTextBox.Font = new Font("Arial", 12F);
            usernameTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            usernameTextBox.Lighting = false;
            usernameTextBox.LinearGradientPen = false;
            usernameTextBox.Location = new Point(191, 152);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PenWidth = 15;
            usernameTextBox.RGB = false;
            usernameTextBox.Rounding = true;
            usernameTextBox.RoundingInt = 60;
            usernameTextBox.Size = new Size(383, 50);
            usernameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            usernameTextBox.TabIndex = 11;
            usernameTextBox.Tag = "Cyber";
            usernameTextBox.TextButton = "";
            usernameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            usernameTextBox.Timer_RGB = 300;
            usernameTextBox.Load += usernameTextBox_Load;
            // 
            // pnlHorizLine
            // 
            pnlHorizLine.BackColor = Color.Silver;
            pnlHorizLine.Location = new Point(25, 111);
            pnlHorizLine.Name = "pnlHorizLine";
            pnlHorizLine.Size = new Size(549, 2);
            pnlHorizLine.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(599, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
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
        private Panel pnlHorizLine;
        private ReaLTaiizor.Controls.CyberTextBox usernameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private ReaLTaiizor.Controls.ForeverLabel headerSubLabel;
        private ReaLTaiizor.Controls.CyberButton exitButton;
        private ReaLTaiizor.Controls.CyberButton loginButton;
        private ReaLTaiizor.Controls.CyberTextBox passwordTextBox;
        private ReaLTaiizor.Controls.HeaderLabel passwordLabel;
        private ReaLTaiizor.Controls.HeaderLabel usernameLabel;
    }
}
