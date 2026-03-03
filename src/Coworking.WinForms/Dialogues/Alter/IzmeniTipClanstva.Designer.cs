namespace Coworking.WinForms.Dialogues
{
    partial class IzmeniTipClanstva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniTipClanstva));
            conferenceTimeNumeric = new ReaLTaiizor.Controls.ForeverNumeric();
            conferenceTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            conferenceCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            monthlyNumeric1 = new ReaLTaiizor.Controls.ForeverNumeric();
            monthlyLabel = new ReaLTaiizor.Controls.HeaderLabel();
            durationNumeric = new ReaLTaiizor.Controls.ForeverNumeric();
            durationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            priceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            priceTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            nameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            editMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            nameTextBox = new ReaLTaiizor.Controls.ForeverComboBox();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            membershipID = new ReaLTaiizor.Controls.HeaderLabel();
            SuspendLayout();
            // 
            // conferenceTimeNumeric
            // 
            conferenceTimeNumeric.BaseColor = Color.FromArgb(37, 52, 68);
            conferenceTimeNumeric.ButtonColorA = Color.FromArgb(29, 200, 238);
            conferenceTimeNumeric.ButtonColorB = Color.White;
            conferenceTimeNumeric.ButtonColorC = Color.White;
            conferenceTimeNumeric.Font = new Font("Segoe UI", 10F);
            conferenceTimeNumeric.ForeColor = Color.Silver;
            conferenceTimeNumeric.Location = new Point(333, 365);
            conferenceTimeNumeric.Maximum = 365L;
            conferenceTimeNumeric.Minimum = 1L;
            conferenceTimeNumeric.Name = "conferenceTimeNumeric";
            conferenceTimeNumeric.Size = new Size(218, 30);
            conferenceTimeNumeric.TabIndex = 47;
            conferenceTimeNumeric.Value = 1L;
            conferenceTimeNumeric.Visible = false;
            // 
            // conferenceTimeLabel
            // 
            conferenceTimeLabel.AutoSize = true;
            conferenceTimeLabel.BackColor = Color.Transparent;
            conferenceTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            conferenceTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            conferenceTimeLabel.Location = new Point(26, 370);
            conferenceTimeLabel.Name = "conferenceTimeLabel";
            conferenceTimeLabel.Size = new Size(301, 25);
            conferenceTimeLabel.TabIndex = 46;
            conferenceTimeLabel.Text = "Maksimum sati sale mesečno:";
            conferenceTimeLabel.Visible = false;
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
            conferenceCheckBox.Location = new Point(17, 305);
            conferenceCheckBox.Name = "conferenceCheckBox";
            conferenceCheckBox.RGB = false;
            conferenceCheckBox.Rounding = true;
            conferenceCheckBox.RoundingInt = 100;
            conferenceCheckBox.Size = new Size(212, 45);
            conferenceCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            conferenceCheckBox.TabIndex = 45;
            conferenceCheckBox.Tag = "Cyber";
            conferenceCheckBox.TextButton = "Dozvoljena sala";
            conferenceCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            conferenceCheckBox.Timer_Effect_1 = 1;
            conferenceCheckBox.Timer_RGB = 300;
            conferenceCheckBox.CheckedChanged += conferenceCheckBox_CheckedChanged;
            // 
            // monthlyNumeric1
            // 
            monthlyNumeric1.BaseColor = Color.FromArgb(37, 52, 68);
            monthlyNumeric1.ButtonColorA = Color.FromArgb(29, 200, 238);
            monthlyNumeric1.ButtonColorB = Color.White;
            monthlyNumeric1.ButtonColorC = Color.White;
            monthlyNumeric1.Font = new Font("Segoe UI", 10F);
            monthlyNumeric1.ForeColor = Color.Silver;
            monthlyNumeric1.Location = new Point(333, 210);
            monthlyNumeric1.Maximum = 365L;
            monthlyNumeric1.Minimum = 1L;
            monthlyNumeric1.Name = "monthlyNumeric1";
            monthlyNumeric1.Size = new Size(218, 30);
            monthlyNumeric1.TabIndex = 44;
            monthlyNumeric1.Value = 1L;
            // 
            // monthlyLabel
            // 
            monthlyLabel.AutoSize = true;
            monthlyLabel.BackColor = Color.Transparent;
            monthlyLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            monthlyLabel.ForeColor = Color.FromArgb(255, 255, 255);
            monthlyLabel.Location = new Point(26, 215);
            monthlyLabel.Name = "monthlyLabel";
            monthlyLabel.Size = new Size(255, 25);
            monthlyLabel.TabIndex = 43;
            monthlyLabel.Text = "Maksimum sati mesečno:";
            // 
            // durationNumeric
            // 
            durationNumeric.BaseColor = Color.FromArgb(37, 52, 68);
            durationNumeric.ButtonColorA = Color.FromArgb(29, 200, 238);
            durationNumeric.ButtonColorB = Color.White;
            durationNumeric.ButtonColorC = Color.White;
            durationNumeric.Font = new Font("Segoe UI", 10F);
            durationNumeric.ForeColor = Color.Silver;
            durationNumeric.Location = new Point(333, 265);
            durationNumeric.Maximum = 365L;
            durationNumeric.Minimum = 1L;
            durationNumeric.Name = "durationNumeric";
            durationNumeric.Size = new Size(218, 30);
            durationNumeric.TabIndex = 42;
            durationNumeric.Value = 30L;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.BackColor = Color.Transparent;
            durationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            durationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            durationLabel.Location = new Point(26, 270);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(168, 25);
            durationLabel.TabIndex = 41;
            durationLabel.Text = "Trajanje (dana):";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            priceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            priceLabel.Location = new Point(32, 154);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(142, 25);
            priceLabel.TabIndex = 40;
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
            priceTextBox.Location = new Point(180, 144);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PenWidth = 15;
            priceTextBox.RGB = false;
            priceTextBox.RightToLeft = RightToLeft.No;
            priceTextBox.Rounding = true;
            priceTextBox.RoundingInt = 60;
            priceTextBox.Size = new Size(371, 50);
            priceTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            priceTextBox.TabIndex = 39;
            priceTextBox.Tag = "Cyber";
            priceTextBox.TextButton = "";
            priceTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            priceTextBox.Timer_RGB = 300;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            nameLabel.Location = new Point(32, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(144, 25);
            nameLabel.TabIndex = 38;
            nameLabel.Text = "Naziv paketa:";
            // 
            // editMembershipButton
            // 
            editMembershipButton.BackColor = Color.Transparent;
            editMembershipButton.BaseColor = Color.FromArgb(56, 95, 235);
            editMembershipButton.Font = new Font("Segoe UI", 12F);
            editMembershipButton.Location = new Point(210, 428);
            editMembershipButton.Name = "editMembershipButton";
            editMembershipButton.Rounded = true;
            editMembershipButton.Size = new Size(183, 45);
            editMembershipButton.TabIndex = 48;
            editMembershipButton.Text = "Izmena podataka";
            editMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
            editMembershipButton.Click += editMembershipButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(37, 52, 68);
            nameTextBox.BaseColor = Color.FromArgb(37, 52, 68);
            nameTextBox.BGColor = Color.FromArgb(37, 52, 68);
            nameTextBox.DrawMode = DrawMode.OwnerDrawFixed;
            nameTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameTextBox.Font = new Font("Segoe UI", 8F);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.FormattingEnabled = true;
            nameTextBox.HoverColor = Color.FromArgb(35, 168, 109);
            nameTextBox.HoverFontColor = Color.White;
            nameTextBox.ItemHeight = 30;
            nameTextBox.Location = new Point(181, 29);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(370, 36);
            nameTextBox.TabIndex = 49;
            nameTextBox.SelectedIndexChanged += membershipComboBox_SelectedIndexChanged;
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
            cyberTextBox1.Location = new Point(181, 80);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.RightToLeft = RightToLeft.No;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(371, 50);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 50;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // membershipID
            // 
            membershipID.AutoSize = true;
            membershipID.BackColor = Color.Transparent;
            membershipID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            membershipID.ForeColor = Color.FromArgb(255, 255, 255);
            membershipID.Location = new Point(32, 34);
            membershipID.Name = "membershipID";
            membershipID.Size = new Size(111, 25);
            membershipID.TabIndex = 51;
            membershipID.Text = "ID paketa:";
            membershipID.Click += headerLabel1_Click;
            // 
            // IzmeniTipClanstva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(586, 504);
            Controls.Add(membershipID);
            Controls.Add(cyberTextBox1);
            Controls.Add(nameTextBox);
            Controls.Add(editMembershipButton);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IzmeniTipClanstva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni tip članstva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverNumeric conferenceTimeNumeric;
        private ReaLTaiizor.Controls.HeaderLabel conferenceTimeLabel;
        private ReaLTaiizor.Controls.CyberCheckBox conferenceCheckBox;
        private ReaLTaiizor.Controls.ForeverNumeric monthlyNumeric1;
        private ReaLTaiizor.Controls.HeaderLabel monthlyLabel;
        private ReaLTaiizor.Controls.ForeverNumeric durationNumeric;
        private ReaLTaiizor.Controls.HeaderLabel durationLabel;
        private ReaLTaiizor.Controls.HeaderLabel priceLabel;
        private ReaLTaiizor.Controls.CyberTextBox priceTextBox;
        private ReaLTaiizor.Controls.HeaderLabel nameLabel;
        private ReaLTaiizor.Controls.ForeverButton editMembershipButton;
        private ReaLTaiizor.Controls.ForeverComboBox nameTextBox;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.HeaderLabel membershipID;
    }
}