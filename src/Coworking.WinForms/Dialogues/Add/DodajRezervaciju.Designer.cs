namespace Coworking.WinForms.Dialogues
{
    partial class DodajRezervaciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajRezervaciju));
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            userComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            resourceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            currentLocationCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            addReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            startDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startTimeDateTime = new DateTimePicker();
            endTimeDateTime = new DateTimePicker();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(12, 46);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(97, 25);
            userLabel.TabIndex = 32;
            userLabel.Text = "Korisnik:";
            // 
            // userComboBox
            // 
            userComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            userComboBox.BGColor = Color.FromArgb(37, 52, 68);
            userComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComboBox.Font = new Font("Segoe UI", 8F);
            userComboBox.ForeColor = Color.White;
            userComboBox.FormattingEnabled = true;
            userComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            userComboBox.HoverFontColor = Color.White;
            userComboBox.ItemHeight = 25;
            userComboBox.Location = new Point(115, 43);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(562, 31);
            userComboBox.TabIndex = 31;
            // 
            // resourceLabel
            // 
            resourceLabel.AutoSize = true;
            resourceLabel.BackColor = Color.Transparent;
            resourceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            resourceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            resourceLabel.Location = new Point(12, 99);
            resourceLabel.Name = "resourceLabel";
            resourceLabel.Size = new Size(86, 25);
            resourceLabel.TabIndex = 34;
            resourceLabel.Text = "Resurs:";
            // 
            // resourceComboBox
            // 
            resourceComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            resourceComboBox.BGColor = Color.FromArgb(37, 52, 68);
            resourceComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            resourceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            resourceComboBox.Font = new Font("Segoe UI", 8F);
            resourceComboBox.ForeColor = Color.White;
            resourceComboBox.FormattingEnabled = true;
            resourceComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            resourceComboBox.HoverFontColor = Color.White;
            resourceComboBox.ItemHeight = 25;
            resourceComboBox.Items.AddRange(new object[] { "Hot desk", "Dedicated desk", "Private office", "Conference room" });
            resourceComboBox.Location = new Point(115, 96);
            resourceComboBox.Name = "resourceComboBox";
            resourceComboBox.Size = new Size(562, 31);
            resourceComboBox.TabIndex = 33;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(12, 208);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(99, 25);
            locationLabel.TabIndex = 36;
            locationLabel.Text = "Lokacija:";
            // 
            // locationComboBox
            // 
            locationComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            locationComboBox.BGColor = Color.FromArgb(37, 52, 68);
            locationComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            locationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            locationComboBox.Enabled = false;
            locationComboBox.Font = new Font("Segoe UI", 8F);
            locationComboBox.ForeColor = Color.White;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            locationComboBox.HoverFontColor = Color.White;
            locationComboBox.ItemHeight = 25;
            locationComboBox.Location = new Point(115, 205);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(562, 31);
            locationComboBox.TabIndex = 35;
            // 
            // currentLocationCheckBox
            // 
            currentLocationCheckBox.BackColor = Color.Transparent;
            currentLocationCheckBox.Background = true;
            currentLocationCheckBox.Background_WidthPen = 2F;
            currentLocationCheckBox.BackgroundPen = true;
            currentLocationCheckBox.Checked = true;
            currentLocationCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            currentLocationCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            currentLocationCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            currentLocationCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            currentLocationCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            currentLocationCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            currentLocationCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            currentLocationCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            currentLocationCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            currentLocationCheckBox.Effect_1_Transparency = 25;
            currentLocationCheckBox.Effect_2 = true;
            currentLocationCheckBox.Effect_2_ColorBackground = Color.White;
            currentLocationCheckBox.Effect_2_Transparency = 15;
            currentLocationCheckBox.Font = new Font("Arial", 12F);
            currentLocationCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            currentLocationCheckBox.LinearGradient_Background = false;
            currentLocationCheckBox.LinearGradientPen = false;
            currentLocationCheckBox.Location = new Point(1, 154);
            currentLocationCheckBox.Name = "currentLocationCheckBox";
            currentLocationCheckBox.RGB = false;
            currentLocationCheckBox.Rounding = false;
            currentLocationCheckBox.RoundingInt = 100;
            currentLocationCheckBox.Size = new Size(213, 45);
            currentLocationCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            currentLocationCheckBox.TabIndex = 37;
            currentLocationCheckBox.Tag = "Cyber";
            currentLocationCheckBox.TextButton = "Trenutna lokacija";
            currentLocationCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            currentLocationCheckBox.Timer_Effect_1 = 1;
            currentLocationCheckBox.Timer_RGB = 300;
            currentLocationCheckBox.CheckedChanged += currentLocationCheckBox_CheckedChanged;
            // 
            // addReservationButton
            // 
            addReservationButton.BackColor = Color.Transparent;
            addReservationButton.BaseColor = Color.FromArgb(35, 168, 109);
            addReservationButton.Cursor = Cursors.Hand;
            addReservationButton.Font = new Font("Segoe UI", 12F);
            addReservationButton.Location = new Point(271, 389);
            addReservationButton.Name = "addReservationButton";
            addReservationButton.Rounded = true;
            addReservationButton.Size = new Size(175, 45);
            addReservationButton.TabIndex = 38;
            addReservationButton.Text = "Dodaj rezervaciju";
            addReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // startDateDateTime
            // 
            startDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            startDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            startDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            startDateDateTime.Format = DateTimePickerFormat.Custom;
            startDateDateTime.Location = new Point(197, 278);
            startDateDateTime.MinimumSize = new Size(0, 30);
            startDateDateTime.Name = "startDateDateTime";
            startDateDateTime.Size = new Size(200, 30);
            startDateDateTime.TabIndex = 39;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startDateLabel.Location = new Point(12, 281);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(163, 25);
            startDateLabel.TabIndex = 40;
            startDateLabel.Text = "Datum početka:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = Color.Transparent;
            startTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startTimeLabel.Location = new Point(417, 281);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(164, 25);
            startTimeLabel.TabIndex = 41;
            startTimeLabel.Text = "Vreme početka:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = Color.Transparent;
            endTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endTimeLabel.Location = new Point(417, 330);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(181, 25);
            endTimeLabel.TabIndex = 45;
            endTimeLabel.Text = "Vreme završetka:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endDateLabel.Location = new Point(12, 330);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(180, 25);
            endDateLabel.TabIndex = 44;
            endDateLabel.Text = "Datum završetka:";
            // 
            // endDateDateTime
            // 
            endDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            endDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            endDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            endDateDateTime.Format = DateTimePickerFormat.Custom;
            endDateDateTime.Location = new Point(197, 327);
            endDateDateTime.MinimumSize = new Size(0, 30);
            endDateDateTime.Name = "endDateDateTime";
            endDateDateTime.Size = new Size(200, 30);
            endDateDateTime.TabIndex = 43;
            // 
            // startTimeDateTime
            // 
            startTimeDateTime.CustomFormat = "HH:mm";
            startTimeDateTime.Format = DateTimePickerFormat.Custom;
            startTimeDateTime.Location = new Point(604, 278);
            startTimeDateTime.Name = "startTimeDateTime";
            startTimeDateTime.ShowUpDown = true;
            startTimeDateTime.Size = new Size(73, 27);
            startTimeDateTime.TabIndex = 47;
            // 
            // endTimeDateTime
            // 
            endTimeDateTime.CustomFormat = "HH:mm";
            endTimeDateTime.Format = DateTimePickerFormat.Custom;
            endTimeDateTime.Location = new Point(604, 327);
            endTimeDateTime.Name = "endTimeDateTime";
            endTimeDateTime.ShowUpDown = true;
            endTimeDateTime.Size = new Size(73, 27);
            endTimeDateTime.TabIndex = 48;
            // 
            // DodajRezervaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(699, 450);
            Controls.Add(endTimeDateTime);
            Controls.Add(startTimeDateTime);
            Controls.Add(endTimeLabel);
            Controls.Add(endDateLabel);
            Controls.Add(endDateDateTime);
            Controls.Add(startTimeLabel);
            Controls.Add(startDateLabel);
            Controls.Add(startDateDateTime);
            Controls.Add(addReservationButton);
            Controls.Add(currentLocationCheckBox);
            Controls.Add(locationLabel);
            Controls.Add(locationComboBox);
            Controls.Add(resourceLabel);
            Controls.Add(resourceComboBox);
            Controls.Add(userLabel);
            Controls.Add(userComboBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DodajRezervaciju";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj rezervaciju";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.ForeverComboBox userComboBox;
        private ReaLTaiizor.Controls.HeaderLabel resourceLabel;
        private ReaLTaiizor.Controls.ForeverComboBox resourceComboBox;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.ForeverComboBox locationComboBox;
        private ReaLTaiizor.Controls.CyberCheckBox currentLocationCheckBox;
        private ReaLTaiizor.Controls.ForeverButton addReservationButton;
        private ReaLTaiizor.Controls.PoisonDateTime startDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel startDateLabel;
        private ReaLTaiizor.Controls.HeaderLabel startTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel endTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDateDateTime;
        private DateTimePicker startTimeDateTime;
        private DateTimePicker endTimeDateTime;
    }
}