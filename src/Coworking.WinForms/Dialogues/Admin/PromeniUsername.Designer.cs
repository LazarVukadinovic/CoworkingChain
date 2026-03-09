namespace Coworking.WinForms.Dialogues.Admin
{
    partial class PromeniUsername
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromeniUsername));
            usernameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            usernameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            editUsernameButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
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
            usernameTextBox.Location = new Point(12, 82);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PenWidth = 15;
            usernameTextBox.RGB = false;
            usernameTextBox.RightToLeft = RightToLeft.No;
            usernameTextBox.Rounding = true;
            usernameTextBox.RoundingInt = 60;
            usernameTextBox.Size = new Size(554, 50);
            usernameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            usernameTextBox.TabIndex = 21;
            usernameTextBox.Tag = "Cyber";
            usernameTextBox.TextButton = "";
            usernameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            usernameTextBox.Timer_RGB = 300;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            usernameLabel.Location = new Point(201, 35);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(193, 29);
            usernameLabel.TabIndex = 22;
            usernameLabel.Text = "Korisničko ime:";
            // 
            // editUsernameButton
            // 
            editUsernameButton.BackColor = Color.Transparent;
            editUsernameButton.BaseColor = Color.FromArgb(56, 95, 235);
            editUsernameButton.Font = new Font("Segoe UI", 12F);
            editUsernameButton.Location = new Point(185, 150);
            editUsernameButton.Name = "editUsernameButton";
            editUsernameButton.Rounded = true;
            editUsernameButton.Size = new Size(225, 45);
            editUsernameButton.TabIndex = 23;
            editUsernameButton.Text = "Izmeni korisničko ime";
            editUsernameButton.TextColor = Color.FromArgb(243, 243, 243);
            editUsernameButton.Click += editUsernameButton_Click;
            // 
            // PromeniUsername
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(578, 229);
            Controls.Add(editUsernameButton);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PromeniUsername";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promeni korisničko ime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CyberTextBox usernameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel usernameLabel;
        private ReaLTaiizor.Controls.ForeverButton editUsernameButton;
    }
}