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
            locationTextBox = new TextBox();
            endTimeDateTime = new DateTimePicker();
            startTimeDateTime = new DateTimePicker();
            endTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startTimeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            addReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            userComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            SuspendLayout();
            // 
            // locationTextBox
            // 
            locationTextBox.BackColor = Color.FromArgb(37, 52, 68);
            locationTextBox.BorderStyle = BorderStyle.None;
            locationTextBox.ForeColor = Color.White;
            locationTextBox.Location = new Point(120, 166);
            locationTextBox.Multiline = true;
            locationTextBox.Name = "locationTextBox";
            locationTextBox.ReadOnly = true;
            locationTextBox.Size = new Size(562, 31);
            locationTextBox.TabIndex = 64;
            // 
            // endTimeDateTime
            // 
            endTimeDateTime.CustomFormat = "HH:mm";
            endTimeDateTime.Format = DateTimePickerFormat.Custom;
            endTimeDateTime.Location = new Point(609, 282);
            endTimeDateTime.Name = "endTimeDateTime";
            endTimeDateTime.ShowUpDown = true;
            endTimeDateTime.Size = new Size(73, 27);
            endTimeDateTime.TabIndex = 63;
            // 
            // startTimeDateTime
            // 
            startTimeDateTime.CustomFormat = "HH:mm";
            startTimeDateTime.Format = DateTimePickerFormat.Custom;
            startTimeDateTime.Location = new Point(609, 233);
            startTimeDateTime.Name = "startTimeDateTime";
            startTimeDateTime.ShowUpDown = true;
            startTimeDateTime.Size = new Size(73, 27);
            startTimeDateTime.TabIndex = 62;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = Color.Transparent;
            endTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endTimeLabel.Location = new Point(422, 285);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(181, 25);
            endTimeLabel.TabIndex = 61;
            endTimeLabel.Text = "Vreme završetka:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endDateLabel.Location = new Point(17, 285);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(180, 25);
            endDateLabel.TabIndex = 60;
            endDateLabel.Text = "Datum završetka:";
            // 
            // endDateDateTime
            // 
            endDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            endDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            endDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            endDateDateTime.Format = DateTimePickerFormat.Custom;
            endDateDateTime.Location = new Point(202, 282);
            endDateDateTime.MinimumSize = new Size(0, 30);
            endDateDateTime.Name = "endDateDateTime";
            endDateDateTime.Size = new Size(200, 30);
            endDateDateTime.TabIndex = 59;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = Color.Transparent;
            startTimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startTimeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startTimeLabel.Location = new Point(422, 236);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(164, 25);
            startTimeLabel.TabIndex = 58;
            startTimeLabel.Text = "Vreme početka:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startDateLabel.Location = new Point(17, 236);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(163, 25);
            startDateLabel.TabIndex = 57;
            startDateLabel.Text = "Datum početka:";
            // 
            // startDateDateTime
            // 
            startDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            startDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            startDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            startDateDateTime.Format = DateTimePickerFormat.Custom;
            startDateDateTime.Location = new Point(202, 233);
            startDateDateTime.MinimumSize = new Size(0, 30);
            startDateDateTime.Name = "startDateDateTime";
            startDateDateTime.Size = new Size(200, 30);
            startDateDateTime.TabIndex = 56;
            // 
            // addReservationButton
            // 
            addReservationButton.BackColor = Color.Transparent;
            addReservationButton.BaseColor = Color.FromArgb(35, 168, 109);
            addReservationButton.Cursor = Cursors.Hand;
            addReservationButton.Font = new Font("Segoe UI", 12F);
            addReservationButton.Location = new Point(276, 344);
            addReservationButton.Name = "addReservationButton";
            addReservationButton.Rounded = true;
            addReservationButton.Size = new Size(175, 45);
            addReservationButton.TabIndex = 55;
            addReservationButton.Text = "Dodaj rezervaciju";
            addReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(17, 166);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(99, 25);
            locationLabel.TabIndex = 54;
            locationLabel.Text = "Lokacija:";
            // 
            // resourceLabel
            // 
            resourceLabel.AutoSize = true;
            resourceLabel.BackColor = Color.Transparent;
            resourceLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            resourceLabel.ForeColor = Color.FromArgb(255, 255, 255);
            resourceLabel.Location = new Point(17, 118);
            resourceLabel.Name = "resourceLabel";
            resourceLabel.Size = new Size(86, 25);
            resourceLabel.TabIndex = 53;
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
            resourceComboBox.Location = new Point(120, 115);
            resourceComboBox.Name = "resourceComboBox";
            resourceComboBox.Size = new Size(562, 31);
            resourceComboBox.TabIndex = 52;
            resourceComboBox.SelectedValueChanged += resourceComboBox_SelectedValueChanged;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(17, 65);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(97, 25);
            userLabel.TabIndex = 51;
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
            userComboBox.Location = new Point(120, 62);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(562, 31);
            userComboBox.TabIndex = 50;
            // 
            // DodajRezervaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(699, 450);
            Controls.Add(locationTextBox);
            Controls.Add(endTimeDateTime);
            Controls.Add(startTimeDateTime);
            Controls.Add(endTimeLabel);
            Controls.Add(endDateLabel);
            Controls.Add(endDateDateTime);
            Controls.Add(startTimeLabel);
            Controls.Add(startDateLabel);
            Controls.Add(startDateDateTime);
            Controls.Add(addReservationButton);
            Controls.Add(locationLabel);
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

        private TextBox locationTextBox;
        private DateTimePicker endTimeDateTime;
        private DateTimePicker startTimeDateTime;
        private ReaLTaiizor.Controls.HeaderLabel endTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel startTimeLabel;
        private ReaLTaiizor.Controls.HeaderLabel startDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime startDateDateTime;
        private ReaLTaiizor.Controls.ForeverButton addReservationButton;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.HeaderLabel resourceLabel;
        private ReaLTaiizor.Controls.ForeverComboBox resourceComboBox;
        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.ForeverComboBox userComboBox;
    }
}