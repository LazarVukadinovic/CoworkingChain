namespace Coworking.WinForms.Dialogues
{
    partial class IzmeniLokaciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniLokaciju));
            commentRichTextBox = new ReaLTaiizor.Controls.CyberRichTextBox();
            commentLabel = new ReaLTaiizor.Controls.HeaderLabel();
            capacityNumericUpDown = new ReaLTaiizor.Controls.ForeverNumeric();
            capacityLabel = new ReaLTaiizor.Controls.HeaderLabel();
            workLabel = new ReaLTaiizor.Controls.HeaderLabel();
            workTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            cityLabel = new ReaLTaiizor.Controls.HeaderLabel();
            cityTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            addressLabel = new ReaLTaiizor.Controls.HeaderLabel();
            addressTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            nameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            nameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            editLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            membershipID = new ReaLTaiizor.Controls.HeaderLabel();
            foreverComboBox1 = new ReaLTaiizor.Controls.ForeverComboBox();
            SuspendLayout();
            // 
            // commentRichTextBox
            // 
            commentRichTextBox.Alpha = 20;
            commentRichTextBox.BackColor = Color.Transparent;
            commentRichTextBox.Background_WidthPen = 3F;
            commentRichTextBox.BackgroundPen = true;
            commentRichTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            commentRichTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            commentRichTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            commentRichTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            commentRichTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            commentRichTextBox.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            commentRichTextBox.Font = new Font("Arial", 11F);
            commentRichTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            commentRichTextBox.Lighting = false;
            commentRichTextBox.LinearGradientPen = false;
            commentRichTextBox.Location = new Point(12, 388);
            commentRichTextBox.Name = "commentRichTextBox";
            commentRichTextBox.PenWidth = 15;
            commentRichTextBox.RGB = false;
            commentRichTextBox.Rounding = true;
            commentRichTextBox.RoundingInt = 60;
            commentRichTextBox.Size = new Size(797, 122);
            commentRichTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            commentRichTextBox.TabIndex = 43;
            commentRichTextBox.Tag = "Cyber";
            commentRichTextBox.TextButton = "";
            commentRichTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            commentRichTextBox.Timer_RGB = 300;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = Color.Transparent;
            commentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            commentLabel.ForeColor = Color.FromArgb(255, 255, 255);
            commentLabel.Location = new Point(12, 349);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new Size(64, 25);
            commentLabel.TabIndex = 42;
            commentLabel.Text = "Opis:";
            // 
            // capacityNumericUpDown
            // 
            capacityNumericUpDown.BaseColor = Color.FromArgb(37, 52, 68);
            capacityNumericUpDown.ButtonColorA = Color.FromArgb(29, 200, 238);
            capacityNumericUpDown.ButtonColorB = Color.White;
            capacityNumericUpDown.ButtonColorC = Color.White;
            capacityNumericUpDown.Font = new Font("Segoe UI", 10F);
            capacityNumericUpDown.ForeColor = Color.Silver;
            capacityNumericUpDown.Location = new Point(572, 323);
            capacityNumericUpDown.Maximum = 100L;
            capacityNumericUpDown.Minimum = 0L;
            capacityNumericUpDown.Name = "capacityNumericUpDown";
            capacityNumericUpDown.Size = new Size(237, 30);
            capacityNumericUpDown.TabIndex = 41;
            capacityNumericUpDown.Value = 0L;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.BackColor = Color.Transparent;
            capacityLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            capacityLabel.ForeColor = Color.FromArgb(255, 255, 255);
            capacityLabel.Location = new Point(407, 328);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(110, 25);
            capacityLabel.TabIndex = 40;
            capacityLabel.Text = "Kapacitet:";
            // 
            // workLabel
            // 
            workLabel.AutoSize = true;
            workLabel.BackColor = Color.Transparent;
            workLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            workLabel.ForeColor = Color.FromArgb(255, 255, 255);
            workLabel.Location = new Point(407, 253);
            workLabel.Name = "workLabel";
            workLabel.Size = new Size(146, 25);
            workLabel.TabIndex = 39;
            workLabel.Text = "Radno vreme:";
            // 
            // workTextBox
            // 
            workTextBox.Alpha = 20;
            workTextBox.BackColor = Color.Transparent;
            workTextBox.Background_WidthPen = 3F;
            workTextBox.BackgroundPen = true;
            workTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            workTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            workTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            workTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            workTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            workTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            workTextBox.Font = new Font("Arial", 12F);
            workTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            workTextBox.Lighting = false;
            workTextBox.LinearGradientPen = false;
            workTextBox.Location = new Point(572, 242);
            workTextBox.Name = "workTextBox";
            workTextBox.PenWidth = 15;
            workTextBox.RGB = false;
            workTextBox.RightToLeft = RightToLeft.No;
            workTextBox.Rounding = true;
            workTextBox.RoundingInt = 60;
            workTextBox.Size = new Size(237, 50);
            workTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            workTextBox.TabIndex = 38;
            workTextBox.Tag = "Cyber";
            workTextBox.TextButton = "";
            workTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            workTextBox.Timer_RGB = 300;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = Color.Transparent;
            cityLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            cityLabel.ForeColor = Color.FromArgb(255, 255, 255);
            cityLabel.Location = new Point(12, 253);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(66, 25);
            cityLabel.TabIndex = 37;
            cityLabel.Text = "Grad:";
            // 
            // cityTextBox
            // 
            cityTextBox.Alpha = 20;
            cityTextBox.BackColor = Color.Transparent;
            cityTextBox.Background_WidthPen = 3F;
            cityTextBox.BackgroundPen = true;
            cityTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            cityTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cityTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            cityTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cityTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cityTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cityTextBox.Font = new Font("Arial", 12F);
            cityTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            cityTextBox.Lighting = false;
            cityTextBox.LinearGradientPen = false;
            cityTextBox.Location = new Point(101, 242);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PenWidth = 15;
            cityTextBox.RGB = false;
            cityTextBox.RightToLeft = RightToLeft.No;
            cityTextBox.Rounding = true;
            cityTextBox.RoundingInt = 60;
            cityTextBox.Size = new Size(242, 50);
            cityTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cityTextBox.TabIndex = 36;
            cityTextBox.Tag = "Cyber";
            cityTextBox.TextButton = "";
            cityTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cityTextBox.Timer_RGB = 300;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            addressLabel.ForeColor = Color.FromArgb(255, 255, 255);
            addressLabel.Location = new Point(12, 179);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(167, 25);
            addressLabel.TabIndex = 35;
            addressLabel.Text = "Adresa lokacije:";
            // 
            // addressTextBox
            // 
            addressTextBox.Alpha = 20;
            addressTextBox.BackColor = Color.Transparent;
            addressTextBox.Background_WidthPen = 3F;
            addressTextBox.BackgroundPen = true;
            addressTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            addressTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            addressTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            addressTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            addressTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            addressTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addressTextBox.Font = new Font("Arial", 12F);
            addressTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            addressTextBox.Lighting = false;
            addressTextBox.LinearGradientPen = false;
            addressTextBox.Location = new Point(177, 168);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PenWidth = 15;
            addressTextBox.RGB = false;
            addressTextBox.RightToLeft = RightToLeft.No;
            addressTextBox.Rounding = true;
            addressTextBox.RoundingInt = 60;
            addressTextBox.Size = new Size(632, 50);
            addressTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addressTextBox.TabIndex = 34;
            addressTextBox.Tag = "Cyber";
            addressTextBox.TextButton = "";
            addressTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            addressTextBox.Timer_RGB = 300;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            nameLabel.Location = new Point(12, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(133, 25);
            nameLabel.TabIndex = 33;
            nameLabel.Text = "Ime lokacije:";
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
            nameTextBox.Location = new Point(177, 91);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PenWidth = 15;
            nameTextBox.RGB = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.Rounding = true;
            nameTextBox.RoundingInt = 60;
            nameTextBox.Size = new Size(632, 50);
            nameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            nameTextBox.TabIndex = 32;
            nameTextBox.Tag = "Cyber";
            nameTextBox.TextButton = "";
            nameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            nameTextBox.Timer_RGB = 300;
            // 
            // editLocationButton
            // 
            editLocationButton.BackColor = Color.Transparent;
            editLocationButton.BaseColor = Color.FromArgb(56, 95, 235);
            editLocationButton.Font = new Font("Segoe UI", 12F);
            editLocationButton.Location = new Point(330, 524);
            editLocationButton.Name = "editLocationButton";
            editLocationButton.Rounded = true;
            editLocationButton.Size = new Size(183, 45);
            editLocationButton.TabIndex = 44;
            editLocationButton.Text = "Izmena podataka";
            editLocationButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // membershipID
            // 
            membershipID.AutoSize = true;
            membershipID.BackColor = Color.Transparent;
            membershipID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            membershipID.ForeColor = Color.FromArgb(255, 255, 255);
            membershipID.Location = new Point(13, 33);
            membershipID.Name = "membershipID";
            membershipID.Size = new Size(119, 25);
            membershipID.TabIndex = 53;
            membershipID.Text = "ID lokacije:";
            // 
            // foreverComboBox1
            // 
            foreverComboBox1.BackColor = Color.FromArgb(37, 52, 68);
            foreverComboBox1.BaseColor = Color.FromArgb(37, 52, 68);
            foreverComboBox1.BGColor = Color.FromArgb(37, 52, 68);
            foreverComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            foreverComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreverComboBox1.Font = new Font("Segoe UI", 8F);
            foreverComboBox1.ForeColor = Color.White;
            foreverComboBox1.FormattingEnabled = true;
            foreverComboBox1.HoverColor = Color.FromArgb(35, 168, 109);
            foreverComboBox1.HoverFontColor = Color.White;
            foreverComboBox1.ItemHeight = 30;
            foreverComboBox1.Location = new Point(177, 28);
            foreverComboBox1.Name = "foreverComboBox1";
            foreverComboBox1.Size = new Size(632, 36);
            foreverComboBox1.TabIndex = 52;
            foreverComboBox1.SelectedIndexChanged += foreverComboBox1_SelectedIndexChanged;
            // 
            // IzmeniLokaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(826, 591);
            Controls.Add(membershipID);
            Controls.Add(foreverComboBox1);
            Controls.Add(editLocationButton);
            Controls.Add(commentRichTextBox);
            Controls.Add(commentLabel);
            Controls.Add(capacityNumericUpDown);
            Controls.Add(capacityLabel);
            Controls.Add(workLabel);
            Controls.Add(workTextBox);
            Controls.Add(cityLabel);
            Controls.Add(cityTextBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IzmeniLokaciju";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni lokaciju";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CyberRichTextBox commentRichTextBox;
        private ReaLTaiizor.Controls.HeaderLabel commentLabel;
        private ReaLTaiizor.Controls.ForeverNumeric capacityNumericUpDown;
        private ReaLTaiizor.Controls.HeaderLabel capacityLabel;
        private ReaLTaiizor.Controls.HeaderLabel workLabel;
        private ReaLTaiizor.Controls.CyberTextBox workTextBox;
        private ReaLTaiizor.Controls.HeaderLabel cityLabel;
        private ReaLTaiizor.Controls.CyberTextBox cityTextBox;
        private ReaLTaiizor.Controls.HeaderLabel addressLabel;
        private ReaLTaiizor.Controls.CyberTextBox addressTextBox;
        private ReaLTaiizor.Controls.HeaderLabel nameLabel;
        private ReaLTaiizor.Controls.CyberTextBox nameTextBox;
        private ReaLTaiizor.Controls.ForeverButton editLocationButton;
        private ReaLTaiizor.Controls.HeaderLabel membershipID;
        private ReaLTaiizor.Controls.ForeverComboBox foreverComboBox1;
    }
}