namespace Coworking.WinForms.Dialogues.Admin
{
    partial class DodajAdmina
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
            addAdminButton = new ReaLTaiizor.Controls.ForeverButton();
            nameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            SuspendLayout();
            // 
            // addAdminButton
            // 
            addAdminButton.BackColor = Color.Transparent;
            addAdminButton.BaseColor = Color.FromArgb(35, 168, 109);
            addAdminButton.Cursor = Cursors.Hand;
            addAdminButton.Font = new Font("Segoe UI", 12F);
            addAdminButton.Location = new Point(185, 302);
            addAdminButton.Name = "addAdminButton";
            addAdminButton.Rounded = true;
            addAdminButton.Size = new Size(225, 45);
            addAdminButton.TabIndex = 22;
            addAdminButton.Text = "Dodaj administratora";
            addAdminButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // nameTextBox
            // 
            nameTextBox.Alpha = 20;
            nameTextBox.BackColor = Color.Transparent;
            nameTextBox.Background_WidthPen = 3F;
            nameTextBox.BackgroundPen = true;
            nameTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            nameTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            nameTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            nameTextBox.Font = new Font("Arial", 12F);
            nameTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            nameTextBox.Lighting = false;
            nameTextBox.LinearGradientPen = false;
            nameTextBox.Location = new Point(12, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PenWidth = 15;
            nameTextBox.RGB = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.Rounding = true;
            nameTextBox.RoundingInt = 60;
            nameTextBox.Size = new Size(554, 50);
            nameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            nameTextBox.TabIndex = 23;
            nameTextBox.Tag = "Cyber";
            nameTextBox.TextButton = "";
            nameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            nameTextBox.Timer_RGB = 300;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(201, 31);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(193, 29);
            userLabel.TabIndex = 24;
            userLabel.Text = "Korisničko ime:";
            // 
            // headerLabel1
            // 
            headerLabel1.AutoSize = true;
            headerLabel1.BackColor = Color.Transparent;
            headerLabel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            headerLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel1.Location = new Point(196, 166);
            headerLabel1.Name = "headerLabel1";
            headerLabel1.Size = new Size(204, 29);
            headerLabel1.TabIndex = 26;
            headerLabel1.Text = "Početna lozinka:";
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 12F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(12, 218);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.RightToLeft = RightToLeft.No;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(554, 50);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 25;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "Kjkszpj1!";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // DodajAdmina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(578, 365);
            Controls.Add(headerLabel1);
            Controls.Add(cyberTextBox1);
            Controls.Add(userLabel);
            Controls.Add(nameTextBox);
            Controls.Add(addAdminButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DodajAdmina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj administratora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverButton addAdminButton;
        private ReaLTaiizor.Controls.CyberTextBox nameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
    }
}