namespace Coworking.WinForms.Dialogues
{
    partial class DodajTipClanstva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajTipClanstva));
            nameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            nameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            priceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            priceTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            durationNumeric = new ReaLTaiizor.Controls.ForeverNumeric();
            durationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            monthlyNumeric1 = new ReaLTaiizor.Controls.ForeverNumeric();
            monthlyLabel = new ReaLTaiizor.Controls.HeaderLabel();
            conferenceCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            conferenceTimeNumeric = new ReaLTaiizor.Controls.ForeverNumeric();
            conferenceTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            addMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            nameLabel.Location = new Point(35, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(144, 25);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "Naziv paketa:";
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
            nameTextBox.Location = new Point(185, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PenWidth = 15;
            nameTextBox.RGB = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.Rounding = true;
            nameTextBox.RoundingInt = 60;
            nameTextBox.Size = new Size(369, 50);
            nameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            nameTextBox.TabIndex = 25;
            nameTextBox.Tag = "Cyber";
            nameTextBox.TextButton = "";
            nameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            nameTextBox.Timer_RGB = 300;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            priceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            priceLabel.Location = new Point(35, 123);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(142, 25);
            priceLabel.TabIndex = 28;
            priceLabel.Text = "Cena paketa:";
            // 
            // priceTextBox
            // 
            priceTextBox.Alpha = 20;
            priceTextBox.BackColor = Color.Transparent;
            priceTextBox.Background_WidthPen = 3F;
            priceTextBox.BackgroundPen = true;
            priceTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            priceTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            priceTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            priceTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            priceTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            priceTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            priceTextBox.Font = new Font("Arial", 12F);
            priceTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            priceTextBox.Lighting = false;
            priceTextBox.LinearGradientPen = false;
            priceTextBox.Location = new Point(183, 109);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PenWidth = 15;
            priceTextBox.RGB = false;
            priceTextBox.RightToLeft = RightToLeft.No;
            priceTextBox.Rounding = true;
            priceTextBox.RoundingInt = 60;
            priceTextBox.Size = new Size(371, 50);
            priceTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            priceTextBox.TabIndex = 27;
            priceTextBox.Tag = "Cyber";
            priceTextBox.TextButton = "";
            priceTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            priceTextBox.Timer_RGB = 300;
            // 
            // durationNumeric
            // 
            durationNumeric.BaseColor = Color.FromArgb(37, 52, 68);
            durationNumeric.ButtonColorA = Color.FromArgb(29, 200, 238);
            durationNumeric.ButtonColorB = Color.White;
            durationNumeric.ButtonColorC = Color.White;
            durationNumeric.Font = new Font("Segoe UI", 10F);
            durationNumeric.ForeColor = Color.Silver;
            durationNumeric.Location = new Point(336, 249);
            durationNumeric.Maximum = 365L;
            durationNumeric.Minimum = 1L;
            durationNumeric.Name = "durationNumeric";
            durationNumeric.Size = new Size(218, 30);
            durationNumeric.TabIndex = 31;
            durationNumeric.Value = 30L;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.BackColor = Color.Transparent;
            durationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            durationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            durationLabel.Location = new Point(29, 254);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(168, 25);
            durationLabel.TabIndex = 30;
            durationLabel.Text = "Trajanje (dana):";
            // 
            // monthlyNumeric1
            // 
            monthlyNumeric1.BaseColor = Color.FromArgb(37, 52, 68);
            monthlyNumeric1.ButtonColorA = Color.FromArgb(29, 200, 238);
            monthlyNumeric1.ButtonColorB = Color.White;
            monthlyNumeric1.ButtonColorC = Color.White;
            monthlyNumeric1.Font = new Font("Segoe UI", 10F);
            monthlyNumeric1.ForeColor = Color.Silver;
            monthlyNumeric1.Location = new Point(336, 194);
            monthlyNumeric1.Maximum = 365L;
            monthlyNumeric1.Minimum = 1L;
            monthlyNumeric1.Name = "monthlyNumeric1";
            monthlyNumeric1.Size = new Size(218, 30);
            monthlyNumeric1.TabIndex = 33;
            monthlyNumeric1.Value = 1L;
            // 
            // monthlyLabel
            // 
            monthlyLabel.AutoSize = true;
            monthlyLabel.BackColor = Color.Transparent;
            monthlyLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            monthlyLabel.ForeColor = Color.FromArgb(255, 255, 255);
            monthlyLabel.Location = new Point(29, 199);
            monthlyLabel.Name = "monthlyLabel";
            monthlyLabel.Size = new Size(255, 25);
            monthlyLabel.TabIndex = 32;
            monthlyLabel.Text = "Maksimum sati mesečno:";
            // 
            // conferenceCheckBox
            // 
            conferenceCheckBox.BackColor = Color.Transparent;
            conferenceCheckBox.Background = true;
            conferenceCheckBox.Background_WidthPen = 2F;
            conferenceCheckBox.BackgroundPen = true;
            conferenceCheckBox.Checked = false;
            conferenceCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            conferenceCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            conferenceCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            conferenceCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            conferenceCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            conferenceCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            conferenceCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            conferenceCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            conferenceCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            conferenceCheckBox.Effect_1_Transparency = 25;
            conferenceCheckBox.Effect_2 = true;
            conferenceCheckBox.Effect_2_ColorBackground = Color.White;
            conferenceCheckBox.Effect_2_Transparency = 15;
            conferenceCheckBox.Font = new Font("Arial", 11F);
            conferenceCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            conferenceCheckBox.LinearGradient_Background = false;
            conferenceCheckBox.LinearGradientPen = false;
            conferenceCheckBox.Location = new Point(20, 305);
            conferenceCheckBox.Name = "conferenceCheckBox";
            conferenceCheckBox.RGB = false;
            conferenceCheckBox.Rounding = true;
            conferenceCheckBox.RoundingInt = 100;
            conferenceCheckBox.Size = new Size(212, 45);
            conferenceCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            conferenceCheckBox.TabIndex = 34;
            conferenceCheckBox.Tag = "Cyber";
            conferenceCheckBox.TextButton = "Dozvoljena sala";
            conferenceCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            conferenceCheckBox.Timer_Effect_1 = 1;
            conferenceCheckBox.Timer_RGB = 300;
            conferenceCheckBox.CheckedChanged += conferenceCheckBox_CheckedChanged;
            // 
            // conferenceTimeNumeric
            // 
            conferenceTimeNumeric.BaseColor = Color.FromArgb(37, 52, 68);
            conferenceTimeNumeric.ButtonColorA = Color.FromArgb(29, 200, 238);
            conferenceTimeNumeric.ButtonColorB = Color.White;
            conferenceTimeNumeric.ButtonColorC = Color.White;
            conferenceTimeNumeric.Font = new Font("Segoe UI", 10F);
            conferenceTimeNumeric.ForeColor = Color.Silver;
            conferenceTimeNumeric.Location = new Point(336, 365);
            conferenceTimeNumeric.Maximum = 365L;
            conferenceTimeNumeric.Minimum = 1L;
            conferenceTimeNumeric.Name = "conferenceTimeNumeric";
            conferenceTimeNumeric.Size = new Size(218, 30);
            conferenceTimeNumeric.TabIndex = 36;
            conferenceTimeNumeric.Value = 1L;
            conferenceTimeNumeric.Visible = false;
            // 
            // conferenceTimeLabel
            // 
            conferenceTimeLabel.AutoSize = true;
            conferenceTimeLabel.BackColor = Color.Transparent;
            conferenceTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            conferenceTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            conferenceTimeLabel.Location = new Point(29, 370);
            conferenceTimeLabel.Name = "conferenceTimeLabel";
            conferenceTimeLabel.Size = new Size(301, 25);
            conferenceTimeLabel.TabIndex = 35;
            conferenceTimeLabel.Text = "Maksimum sati sale mesečno:";
            conferenceTimeLabel.Visible = false;
            // 
            // addMembershipButton
            // 
            addMembershipButton.BackColor = Color.Transparent;
            addMembershipButton.BaseColor = Color.FromArgb(35, 168, 109);
            addMembershipButton.Cursor = Cursors.Hand;
            addMembershipButton.Font = new Font("Segoe UI", 12F);
            addMembershipButton.Location = new Point(227, 425);
            addMembershipButton.Name = "addMembershipButton";
            addMembershipButton.Rounded = true;
            addMembershipButton.Size = new Size(150, 45);
            addMembershipButton.TabIndex = 37;
            addMembershipButton.Text = "Dodaj tip";
            addMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
            addMembershipButton.Click += addMembershipButton_Click;
            // 
            // DodajTipClanstva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(586, 504);
            Controls.Add(addMembershipButton);
            Controls.Add(conferenceTimeNumeric);
            Controls.Add(conferenceTimeLabel);
            Controls.Add(conferenceCheckBox);
            Controls.Add(monthlyNumeric1);
            Controls.Add(monthlyLabel);
            Controls.Add(durationNumeric);
            Controls.Add(durationLabel);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DodajTipClanstva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj tip članstva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel nameLabel;
        private ReaLTaiizor.Controls.CyberTextBox nameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel priceLabel;
        private ReaLTaiizor.Controls.CyberTextBox priceTextBox;
        private ReaLTaiizor.Controls.ForeverNumeric durationNumeric;
        private ReaLTaiizor.Controls.HeaderLabel durationLabel;
        private ReaLTaiizor.Controls.ForeverNumeric monthlyNumeric1;
        private ReaLTaiizor.Controls.HeaderLabel monthlyLabel;
        private ReaLTaiizor.Controls.CyberCheckBox conferenceCheckBox;
        private ReaLTaiizor.Controls.ForeverNumeric conferenceTimeNumeric;
        private ReaLTaiizor.Controls.HeaderLabel conferenceTimeLabel;
        private ReaLTaiizor.Controls.ForeverButton addMembershipButton;
    }
}