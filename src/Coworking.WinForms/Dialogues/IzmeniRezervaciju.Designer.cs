namespace Coworking.WinForms.Dialogues
{
    partial class IzmeniRezervaciju
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
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            userNameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endTimeDateTime = new DateTimePicker();
            startTimeDateTime = new DateTimePicker();
            endTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            currentLocationCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            resourceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            statusLabel = new ReaLTaiizor.Controls.HeaderLabel();
            statusComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            editReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(12, 35);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(223, 25);
            userLabel.TabIndex = 33;
            userLabel.Text = "Rezervacija korisnika:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            userNameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userNameLabel.Location = new Point(241, 24);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(0, 36);
            userNameLabel.TabIndex = 34;
            // 
            // endTimeDateTime
            // 
            endTimeDateTime.CustomFormat = "HH:mm";
            endTimeDateTime.Format = DateTimePickerFormat.Custom;
            endTimeDateTime.Location = new Point(604, 320);
            endTimeDateTime.Name = "endTimeDateTime";
            endTimeDateTime.ShowUpDown = true;
            endTimeDateTime.Size = new Size(73, 27);
            endTimeDateTime.TabIndex = 61;
            // 
            // startTimeDateTime
            // 
            startTimeDateTime.CustomFormat = "HH:mm";
            startTimeDateTime.Format = DateTimePickerFormat.Custom;
            startTimeDateTime.Location = new Point(604, 271);
            startTimeDateTime.Name = "startTimeDateTime";
            startTimeDateTime.ShowUpDown = true;
            startTimeDateTime.Size = new Size(73, 27);
            startTimeDateTime.TabIndex = 60;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = Color.Transparent;
            endTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endTimeLabel.Location = new Point(417, 323);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(181, 25);
            endTimeLabel.TabIndex = 59;
            endTimeLabel.Text = "Vreme završetka:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endDateLabel.Location = new Point(12, 323);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(180, 25);
            endDateLabel.TabIndex = 58;
            endDateLabel.Text = "Datum završetka:";
            // 
            // endDateDateTime
            // 
            endDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            endDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            endDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            endDateDateTime.Format = DateTimePickerFormat.Custom;
            endDateDateTime.Location = new Point(197, 320);
            endDateDateTime.MinimumSize = new Size(0, 30);
            endDateDateTime.Name = "endDateDateTime";
            endDateDateTime.Size = new Size(200, 30);
            endDateDateTime.TabIndex = 57;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = Color.Transparent;
            startTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startTimeLabel.Location = new Point(417, 274);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(164, 25);
            startTimeLabel.TabIndex = 56;
            startTimeLabel.Text = "Vreme početka:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startDateLabel.Location = new Point(12, 274);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(163, 25);
            startDateLabel.TabIndex = 55;
            startDateLabel.Text = "Datum početka:";
            // 
            // startDateDateTime
            // 
            startDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            startDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            startDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            startDateDateTime.Format = DateTimePickerFormat.Custom;
            startDateDateTime.Location = new Point(197, 271);
            startDateDateTime.MinimumSize = new Size(0, 30);
            startDateDateTime.Name = "startDateDateTime";
            startDateDateTime.Size = new Size(200, 30);
            startDateDateTime.TabIndex = 54;
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
            currentLocationCheckBox.Location = new Point(1, 147);
            currentLocationCheckBox.Name = "currentLocationCheckBox";
            currentLocationCheckBox.RGB = false;
            currentLocationCheckBox.Rounding = false;
            currentLocationCheckBox.RoundingInt = 100;
            currentLocationCheckBox.Size = new Size(213, 45);
            currentLocationCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            currentLocationCheckBox.TabIndex = 53;
            currentLocationCheckBox.Tag = "Cyber";
            currentLocationCheckBox.TextButton = "Trenutna lokacija";
            currentLocationCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            currentLocationCheckBox.Timer_Effect_1 = 1;
            currentLocationCheckBox.Timer_RGB = 300;
            currentLocationCheckBox.CheckedChanged += currentLocationCheckBox_CheckedChanged;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(12, 201);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(99, 25);
            locationLabel.TabIndex = 52;
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
            locationComboBox.Location = new Point(115, 198);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(562, 31);
            locationComboBox.TabIndex = 51;
            // 
            // resourceLabel
            // 
            resourceLabel.AutoSize = true;
            resourceLabel.BackColor = Color.Transparent;
            resourceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            resourceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            resourceLabel.Location = new Point(12, 92);
            resourceLabel.Name = "resourceLabel";
            resourceLabel.Size = new Size(86, 25);
            resourceLabel.TabIndex = 50;
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
            resourceComboBox.Location = new Point(115, 89);
            resourceComboBox.Name = "resourceComboBox";
            resourceComboBox.Size = new Size(562, 31);
            resourceComboBox.TabIndex = 49;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            statusLabel.ForeColor = Color.FromArgb(255, 255, 255);
            statusLabel.Location = new Point(12, 388);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(81, 25);
            statusLabel.TabIndex = 63;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            statusComboBox.BGColor = Color.FromArgb(37, 52, 68);
            statusComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Font = new Font("Segoe UI", 8F);
            statusComboBox.ForeColor = Color.White;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            statusComboBox.HoverFontColor = Color.White;
            statusComboBox.ItemHeight = 25;
            statusComboBox.Items.AddRange(new object[] { "Rezervisana", "Potvrdjena", "Završena", "Otkazana" });
            statusComboBox.Location = new Point(115, 385);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(562, 31);
            statusComboBox.TabIndex = 62;
            // 
            // editReservationButton
            // 
            editReservationButton.BackColor = Color.Transparent;
            editReservationButton.BaseColor = Color.FromArgb(56, 95, 235);
            editReservationButton.Font = new Font("Segoe UI", 12F);
            editReservationButton.Location = new Point(261, 440);
            editReservationButton.Name = "editReservationButton";
            editReservationButton.Rounded = true;
            editReservationButton.Size = new Size(183, 45);
            editReservationButton.TabIndex = 64;
            editReservationButton.Text = "Izmena podataka";
            editReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // IzmeniRezervaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(697, 497);
            Controls.Add(editReservationButton);
            Controls.Add(statusLabel);
            Controls.Add(statusComboBox);
            Controls.Add(endTimeDateTime);
            Controls.Add(startTimeDateTime);
            Controls.Add(endTimeLabel);
            Controls.Add(endDateLabel);
            Controls.Add(endDateDateTime);
            Controls.Add(startTimeLabel);
            Controls.Add(startDateLabel);
            Controls.Add(startDateDateTime);
            Controls.Add(currentLocationCheckBox);
            Controls.Add(locationLabel);
            Controls.Add(locationComboBox);
            Controls.Add(resourceLabel);
            Controls.Add(resourceComboBox);
            Controls.Add(userNameLabel);
            Controls.Add(userLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "IzmeniRezervaciju";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni rezervaciju";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.HeaderLabel userNameLabel;
        private DateTimePicker endTimeDateTime;
        private DateTimePicker startTimeDateTime;
        private ReaLTaiizor.Controls.HeaderLabel endTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel startTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel startDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime startDateDateTime;
        private ReaLTaiizor.Controls.CyberCheckBox currentLocationCheckBox;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.ForeverComboBox locationComboBox;
        private ReaLTaiizor.Controls.HeaderLabel resourceLabel;
        private ReaLTaiizor.Controls.ForeverComboBox resourceComboBox;
        private ReaLTaiizor.Controls.HeaderLabel statusLabel;
        private ReaLTaiizor.Controls.ForeverComboBox statusComboBox;
        private ReaLTaiizor.Controls.ForeverButton editReservationButton;
    }
}