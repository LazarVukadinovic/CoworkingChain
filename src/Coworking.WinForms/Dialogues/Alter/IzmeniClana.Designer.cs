namespace Coworking.WinForms.Dialogues
{
    partial class IzmeniClana
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
            lastnameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            nameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            fillNameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            fillLastnameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            membershipComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            membershipLabel = new ReaLTaiizor.Controls.HeaderLabel();
            phoneLabel = new ReaLTaiizor.Controls.HeaderLabel();
            phoneTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            emailLabel = new ReaLTaiizor.Controls.HeaderLabel();
            emailTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            statusComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            statusLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            endDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            startDateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            startDateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            editMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.BackColor = Color.Transparent;
            lastnameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lastnameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            lastnameLabel.Location = new Point(12, 81);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(155, 25);
            lastnameLabel.TabIndex = 22;
            lastnameLabel.Text = "Prezime člana:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            nameLabel.Location = new Point(12, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(112, 25);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Ime člana:";
            // 
            // fillNameLabel
            // 
            fillNameLabel.AutoSize = true;
            fillNameLabel.BackColor = Color.Transparent;
            fillNameLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            fillNameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            fillNameLabel.Location = new Point(130, 22);
            fillNameLabel.Name = "fillNameLabel";
            fillNameLabel.Size = new Size(0, 31);
            fillNameLabel.TabIndex = 23;
            // 
            // fillLastnameLabel
            // 
            fillLastnameLabel.AutoSize = true;
            fillLastnameLabel.BackColor = Color.Transparent;
            fillLastnameLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            fillLastnameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            fillLastnameLabel.Location = new Point(173, 75);
            fillLastnameLabel.Name = "fillLastnameLabel";
            fillLastnameLabel.Size = new Size(0, 31);
            fillLastnameLabel.TabIndex = 24;
            // 
            // membershipComboBox
            // 
            membershipComboBox.BackColor = Color.FromArgb(37, 52, 68);
            membershipComboBox.BaseColor = Color.FromArgb(37, 52, 68);
            membershipComboBox.BGColor = Color.FromArgb(37, 52, 68);
            membershipComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            membershipComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            membershipComboBox.Font = new Font("Segoe UI", 8F);
            membershipComboBox.ForeColor = Color.White;
            membershipComboBox.FormattingEnabled = true;
            membershipComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            membershipComboBox.HoverFontColor = Color.White;
            membershipComboBox.ItemHeight = 30;
            membershipComboBox.Location = new Point(178, 288);
            membershipComboBox.Name = "membershipComboBox";
            membershipComboBox.Size = new Size(387, 36);
            membershipComboBox.TabIndex = 35;
            // 
            // membershipLabel
            // 
            membershipLabel.AutoSize = true;
            membershipLabel.BackColor = Color.Transparent;
            membershipLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            membershipLabel.ForeColor = Color.FromArgb(255, 255, 255);
            membershipLabel.Location = new Point(12, 293);
            membershipLabel.Name = "membershipLabel";
            membershipLabel.Size = new Size(136, 25);
            membershipLabel.TabIndex = 34;
            membershipLabel.Text = "Tip članstva:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(255, 255, 255);
            phoneLabel.Location = new Point(12, 218);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(150, 25);
            phoneLabel.TabIndex = 33;
            phoneLabel.Text = "Telefon člana:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Alpha = 20;
            phoneTextBox.BackColor = Color.Transparent;
            phoneTextBox.Background_WidthPen = 3F;
            phoneTextBox.BackgroundPen = true;
            phoneTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            phoneTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            phoneTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            phoneTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            phoneTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            phoneTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            phoneTextBox.Font = new Font("Arial", 12F);
            phoneTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            phoneTextBox.Lighting = false;
            phoneTextBox.LinearGradientPen = false;
            phoneTextBox.Location = new Point(178, 208);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PenWidth = 15;
            phoneTextBox.RGB = false;
            phoneTextBox.RightToLeft = RightToLeft.No;
            phoneTextBox.Rounding = true;
            phoneTextBox.RoundingInt = 60;
            phoneTextBox.Size = new Size(387, 50);
            phoneTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            phoneTextBox.TabIndex = 32;
            phoneTextBox.Tag = "Cyber";
            phoneTextBox.TextButton = "";
            phoneTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            phoneTextBox.Timer_RGB = 300;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(255, 255, 255);
            emailLabel.Location = new Point(12, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(130, 25);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "Email člana:";
            // 
            // emailTextBox
            // 
            emailTextBox.Alpha = 20;
            emailTextBox.BackColor = Color.Transparent;
            emailTextBox.Background_WidthPen = 3F;
            emailTextBox.BackgroundPen = true;
            emailTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            emailTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            emailTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            emailTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            emailTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            emailTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            emailTextBox.Font = new Font("Arial", 12F);
            emailTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            emailTextBox.Lighting = false;
            emailTextBox.LinearGradientPen = false;
            emailTextBox.Location = new Point(178, 135);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PenWidth = 15;
            emailTextBox.RGB = false;
            emailTextBox.RightToLeft = RightToLeft.No;
            emailTextBox.Rounding = true;
            emailTextBox.RoundingInt = 60;
            emailTextBox.Size = new Size(387, 50);
            emailTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            emailTextBox.TabIndex = 30;
            emailTextBox.Tag = "Cyber";
            emailTextBox.TextButton = "";
            emailTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            emailTextBox.Timer_RGB = 300;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(37, 52, 68);
            statusComboBox.BaseColor = Color.FromArgb(37, 52, 68);
            statusComboBox.BGColor = Color.FromArgb(37, 52, 68);
            statusComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Font = new Font("Segoe UI", 8F);
            statusComboBox.ForeColor = Color.White;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            statusComboBox.HoverFontColor = Color.White;
            statusComboBox.ItemHeight = 30;
            statusComboBox.Items.AddRange(new object[] { "Aktivan", "Neaktivan", "Suspendovan" });
            statusComboBox.Location = new Point(178, 354);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(387, 36);
            statusComboBox.TabIndex = 37;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            statusLabel.ForeColor = Color.FromArgb(255, 255, 255);
            statusLabel.Location = new Point(12, 359);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(152, 25);
            statusLabel.TabIndex = 36;
            statusLabel.Text = "Status naloga:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            endDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            endDateLabel.Location = new Point(12, 465);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(180, 25);
            endDateLabel.TabIndex = 48;
            endDateLabel.Text = "Datum završetka:";
            // 
            // endDateDateTime
            // 
            endDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            endDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            endDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            endDateDateTime.Format = DateTimePickerFormat.Custom;
            endDateDateTime.Location = new Point(197, 462);
            endDateDateTime.MinimumSize = new Size(0, 30);
            endDateDateTime.Name = "endDateDateTime";
            endDateDateTime.Size = new Size(200, 30);
            endDateDateTime.TabIndex = 47;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            startDateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            startDateLabel.Location = new Point(12, 416);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(163, 25);
            startDateLabel.TabIndex = 46;
            startDateLabel.Text = "Datum početka:";
            // 
            // startDateDateTime
            // 
            startDateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            startDateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            startDateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            startDateDateTime.Format = DateTimePickerFormat.Custom;
            startDateDateTime.Location = new Point(197, 413);
            startDateDateTime.MinimumSize = new Size(0, 30);
            startDateDateTime.Name = "startDateDateTime";
            startDateDateTime.Size = new Size(200, 30);
            startDateDateTime.TabIndex = 45;
            // 
            // editMemberButton
            // 
            editMemberButton.BackColor = Color.Transparent;
            editMemberButton.BaseColor = Color.FromArgb(56, 95, 235);
            editMemberButton.Font = new Font("Segoe UI", 12F);
            editMemberButton.Location = new Point(206, 520);
            editMemberButton.Name = "editMemberButton";
            editMemberButton.Rounded = true;
            editMemberButton.Size = new Size(183, 45);
            editMemberButton.TabIndex = 49;
            editMemberButton.Text = "Izmena podataka";
            editMemberButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // IzmeniClana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(577, 587);
            Controls.Add(editMemberButton);
            Controls.Add(endDateLabel);
            Controls.Add(endDateDateTime);
            Controls.Add(startDateLabel);
            Controls.Add(startDateDateTime);
            Controls.Add(statusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(membershipComboBox);
            Controls.Add(membershipLabel);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(fillLastnameLabel);
            Controls.Add(fillNameLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "IzmeniClana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni člana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel lastnameLabel;
        private ReaLTaiizor.Controls.HeaderLabel nameLabel;
        private ReaLTaiizor.Controls.HeaderLabel fillNameLabel;
        private ReaLTaiizor.Controls.HeaderLabel fillLastnameLabel;
        private ReaLTaiizor.Controls.ForeverComboBox membershipComboBox;
        private ReaLTaiizor.Controls.HeaderLabel membershipLabel;
        private ReaLTaiizor.Controls.HeaderLabel phoneLabel;
        private ReaLTaiizor.Controls.CyberTextBox phoneTextBox;
        private ReaLTaiizor.Controls.HeaderLabel emailLabel;
        private ReaLTaiizor.Controls.CyberTextBox emailTextBox;
        private ReaLTaiizor.Controls.ForeverComboBox statusComboBox;
        private ReaLTaiizor.Controls.HeaderLabel statusLabel;
        private ReaLTaiizor.Controls.HeaderLabel endDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime endDateDateTime;
        private ReaLTaiizor.Controls.HeaderLabel startDateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime startDateDateTime;
        private ReaLTaiizor.Controls.ForeverButton editMemberButton;
    }
}