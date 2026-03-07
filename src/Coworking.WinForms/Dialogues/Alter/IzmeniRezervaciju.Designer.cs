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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniRezervaciju));
            locationTextBox = new TextBox();
            editReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            endTimeDateTime = new DateTimePicker();
            startTimeDateTime = new DateTimePicker();
            endTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            userNameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            SuspendLayout();
            // 
            // locationTextBox
            // 
            locationTextBox.BackColor = Color.FromArgb(37, 52, 68);
            locationTextBox.BorderStyle = BorderStyle.None;
            locationTextBox.ForeColor = Color.White;
            locationTextBox.Location = new Point(119, 164);
            locationTextBox.Multiline = true;
            locationTextBox.Name = "locationTextBox";
            locationTextBox.ReadOnly = true;
            locationTextBox.Size = new Size(562, 31);
            locationTextBox.TabIndex = 82;
            // 
            // editReservationButton
            // 
            editReservationButton.BackColor = Color.Transparent;
            editReservationButton.BaseColor = Color.FromArgb(56, 95, 235);
            editReservationButton.Font = new Font("Segoe UI", 12F);
            editReservationButton.Location = new Point(245, 355);
            editReservationButton.Name = "editReservationButton";
            editReservationButton.Rounded = true;
            editReservationButton.Size = new Size(183, 45);
            editReservationButton.TabIndex = 81;
            editReservationButton.Text = "Izmena podataka";
            editReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            editReservationButton.Click += editReservationButton_Click;
            // 
            // endTimeDateTime
            // 
            endTimeDateTime.CustomFormat = "HH:mm";
            endTimeDateTime.Format = DateTimePickerFormat.Custom;
            endTimeDateTime.Location = new Point(608, 283);
            endTimeDateTime.Name = "endTimeDateTime";
            endTimeDateTime.ShowUpDown = true;
            endTimeDateTime.Size = new Size(73, 27);
            endTimeDateTime.TabIndex = 78;
            // 
            // startTimeDateTime
            // 
            startTimeDateTime.CustomFormat = "HH:mm";
            startTimeDateTime.Format = DateTimePickerFormat.Custom;
            startTimeDateTime.Location = new Point(608, 234);
            startTimeDateTime.Name = "startTimeDateTime";
            startTimeDateTime.ShowUpDown = true;
            startTimeDateTime.Size = new Size(73, 27);
            startTimeDateTime.TabIndex = 77;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = Color.Transparent;
            endTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endTimeLabel.Location = new Point(421, 286);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(181, 25);
            endTimeLabel.TabIndex = 76;
            endTimeLabel.Text = "Vreme završetka:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endDateLabel.Location = new Point(16, 286);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(180, 25);
            endDateLabel.TabIndex = 75;
            endDateLabel.Text = "Datum završetka:";
            // 
            // endDateDateTime
            // 
            endDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            endDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            endDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            endDateDateTime.Format = DateTimePickerFormat.Custom;
            endDateDateTime.Location = new Point(201, 283);
            endDateDateTime.MinimumSize = new Size(0, 30);
            endDateDateTime.Name = "endDateDateTime";
            endDateDateTime.Size = new Size(200, 30);
            endDateDateTime.TabIndex = 74;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = Color.Transparent;
            startTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startTimeLabel.Location = new Point(421, 237);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(164, 25);
            startTimeLabel.TabIndex = 73;
            startTimeLabel.Text = "Vreme početka:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startDateLabel.Location = new Point(16, 237);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(163, 25);
            startDateLabel.TabIndex = 72;
            startDateLabel.Text = "Datum početka:";
            // 
            // startDateDateTime
            // 
            startDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            startDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            startDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            startDateDateTime.Format = DateTimePickerFormat.Custom;
            startDateDateTime.Location = new Point(201, 234);
            startDateDateTime.MinimumSize = new Size(0, 30);
            startDateDateTime.Name = "startDateDateTime";
            startDateDateTime.Size = new Size(200, 30);
            startDateDateTime.TabIndex = 71;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(16, 164);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(99, 25);
            locationLabel.TabIndex = 70;
            locationLabel.Text = "Lokacija:";
            // 
            // resourceLabel
            // 
            resourceLabel.AutoSize = true;
            resourceLabel.BackColor = Color.Transparent;
            resourceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            resourceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            resourceLabel.Location = new Point(16, 116);
            resourceLabel.Name = "resourceLabel";
            resourceLabel.Size = new Size(86, 25);
            resourceLabel.TabIndex = 69;
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
            resourceComboBox.Location = new Point(119, 113);
            resourceComboBox.Name = "resourceComboBox";
            resourceComboBox.Size = new Size(562, 31);
            resourceComboBox.TabIndex = 68;
            resourceComboBox.SelectedIndexChanged += resourceComboBox_SelectedIndexChanged;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            userNameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userNameLabel.Location = new Point(245, 48);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(0, 36);
            userNameLabel.TabIndex = 67;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(16, 59);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(223, 25);
            userLabel.TabIndex = 66;
            userLabel.Text = "Rezervacija korisnika:";
            // 
            // IzmeniRezervaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(697, 497);
            Controls.Add(locationTextBox);
            Controls.Add(editReservationButton);
            Controls.Add(endTimeDateTime);
            Controls.Add(startTimeDateTime);
            Controls.Add(endTimeLabel);
            Controls.Add(endDateLabel);
            Controls.Add(endDateDateTime);
            Controls.Add(startTimeLabel);
            Controls.Add(startDateLabel);
            Controls.Add(startDateDateTime);
            Controls.Add(locationLabel);
            Controls.Add(resourceLabel);
            Controls.Add(resourceComboBox);
            Controls.Add(userNameLabel);
            Controls.Add(userLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IzmeniRezervaciju";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni rezervaciju";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationTextBox;
        private ReaLTaiizor.Controls.ForeverButton editReservationButton;
        private DateTimePicker endTimeDateTime;
        private DateTimePicker startTimeDateTime;
        private ReaLTaiizor.Controls.HeaderLabel endTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel startTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel startDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime startDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.HeaderLabel resourceLabel;
        private ReaLTaiizor.Controls.ForeverComboBox resourceComboBox;
        private ReaLTaiizor.Controls.HeaderLabel userNameLabel;
        private ReaLTaiizor.Controls.HeaderLabel userLabel;
    }
}