namespace Coworking.WinForms.Dialogues.Admin
{
    partial class PromeniLozinku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromeniLozinku));
            currentPasswordLabel = new ReaLTaiizor.Controls.HeaderLabel();
            currentPasswordTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            newPasswordLabel = new ReaLTaiizor.Controls.HeaderLabel();
            newPasswordTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            editPasswordButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // currentPasswordLabel
            // 
            currentPasswordLabel.AutoSize = true;
            currentPasswordLabel.BackColor = Color.Transparent;
            currentPasswordLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            currentPasswordLabel.ForeColor = Color.FromArgb(255, 255, 255);
            currentPasswordLabel.Location = new Point(191, 38);
            currentPasswordLabel.Name = "currentPasswordLabel";
            currentPasswordLabel.Size = new Size(213, 29);
            currentPasswordLabel.TabIndex = 24;
            currentPasswordLabel.Text = "Trenutna lozinka:";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Alpha = 20;
            currentPasswordTextBox.BackColor = Color.Transparent;
            currentPasswordTextBox.Background_WidthPen = 3F;
            currentPasswordTextBox.BackgroundPen = true;
            currentPasswordTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            currentPasswordTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            currentPasswordTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            currentPasswordTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            currentPasswordTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            currentPasswordTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            currentPasswordTextBox.Font = new Font("Arial", 12F);
            currentPasswordTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            currentPasswordTextBox.Lighting = false;
            currentPasswordTextBox.LinearGradientPen = false;
            currentPasswordTextBox.Location = new Point(12, 85);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.Password = true;
            currentPasswordTextBox.PenWidth = 15;
            currentPasswordTextBox.RGB = false;
            currentPasswordTextBox.RightToLeft = RightToLeft.No;
            currentPasswordTextBox.Rounding = true;
            currentPasswordTextBox.RoundingInt = 60;
            currentPasswordTextBox.Size = new Size(554, 50);
            currentPasswordTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            currentPasswordTextBox.TabIndex = 23;
            currentPasswordTextBox.Tag = "Cyber";
            currentPasswordTextBox.TextButton = "";
            currentPasswordTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            currentPasswordTextBox.Timer_RGB = 300;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.BackColor = Color.Transparent;
            newPasswordLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            newPasswordLabel.ForeColor = Color.FromArgb(255, 255, 255);
            newPasswordLabel.Location = new Point(213, 171);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(169, 29);
            newPasswordLabel.TabIndex = 26;
            newPasswordLabel.Text = "Nova lozinka:";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Alpha = 20;
            newPasswordTextBox.BackColor = Color.Transparent;
            newPasswordTextBox.Background_WidthPen = 3F;
            newPasswordTextBox.BackgroundPen = true;
            newPasswordTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            newPasswordTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            newPasswordTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            newPasswordTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            newPasswordTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            newPasswordTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            newPasswordTextBox.Font = new Font("Arial", 12F);
            newPasswordTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            newPasswordTextBox.Lighting = false;
            newPasswordTextBox.LinearGradientPen = false;
            newPasswordTextBox.Location = new Point(12, 218);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Password = true;
            newPasswordTextBox.PenWidth = 15;
            newPasswordTextBox.RGB = false;
            newPasswordTextBox.RightToLeft = RightToLeft.No;
            newPasswordTextBox.Rounding = true;
            newPasswordTextBox.RoundingInt = 60;
            newPasswordTextBox.Size = new Size(554, 50);
            newPasswordTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            newPasswordTextBox.TabIndex = 25;
            newPasswordTextBox.Tag = "Cyber";
            newPasswordTextBox.TextButton = "";
            newPasswordTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            newPasswordTextBox.Timer_RGB = 300;
            // 
            // editPasswordButton
            // 
            editPasswordButton.BackColor = Color.Transparent;
            editPasswordButton.BaseColor = Color.Red;
            editPasswordButton.Cursor = Cursors.Hand;
            editPasswordButton.Font = new Font("Segoe UI", 12F);
            editPasswordButton.Location = new Point(215, 294);
            editPasswordButton.Name = "editPasswordButton";
            editPasswordButton.Rounded = true;
            editPasswordButton.Size = new Size(165, 45);
            editPasswordButton.TabIndex = 27;
            editPasswordButton.Text = "Izmeni lozinku";
            editPasswordButton.TextColor = Color.FromArgb(243, 243, 243);
            editPasswordButton.Click += editPasswordButton_Click;
            // 
            // PromeniLozinku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(578, 362);
            Controls.Add(editPasswordButton);
            Controls.Add(newPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(currentPasswordLabel);
            Controls.Add(currentPasswordTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PromeniLozinku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promeni lozinku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel currentPasswordLabel;
        private ReaLTaiizor.Controls.CyberTextBox currentPasswordTextBox;
        private ReaLTaiizor.Controls.HeaderLabel newPasswordLabel;
        private ReaLTaiizor.Controls.CyberTextBox newPasswordTextBox;
        private ReaLTaiizor.Controls.ForeverButton editPasswordButton;
    }
}