namespace Coworking.WinForms
{
    partial class Rezervacije
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            filterPanel = new Panel();
            cancelReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            editReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            addReservationButton = new ReaLTaiizor.Controls.ForeverButton();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            filteringpanel = new Panel();
            dateLabel = new ReaLTaiizor.Controls.HeaderLabel();
            dateDateTime = new ReaLTaiizor.Controls.PoisonDateTime();
            doneCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            confirmedCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            cancelledCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationDateRadioButton = new ReaLTaiizor.Controls.CyberRadioButton();
            reservedCheckBox = new ReaLTaiizor.Controls.CyberCheckBox();
            userRadioButton = new ReaLTaiizor.Controls.CyberRadioButton();
            userTextBox = new ReaLTaiizor.Controls.ForeverComboBox();
            reservationDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            filteringpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(37, 52, 68);
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1313, 69);
            headerPanel.TabIndex = 4;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(552, 10);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(225, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Rezervacije";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(cancelReservationButton);
            filterPanel.Controls.Add(deleteReservationButton);
            filterPanel.Controls.Add(editReservationButton);
            filterPanel.Controls.Add(addReservationButton);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1313, 72);
            filterPanel.TabIndex = 5;
            // 
            // cancelReservationButton
            // 
            cancelReservationButton.BackColor = Color.Transparent;
            cancelReservationButton.BaseColor = Color.FromArgb(255, 192, 128);
            cancelReservationButton.Font = new Font("Segoe UI", 12F);
            cancelReservationButton.Location = new Point(380, 12);
            cancelReservationButton.Name = "cancelReservationButton";
            cancelReservationButton.Rounded = true;
            cancelReservationButton.Size = new Size(183, 45);
            cancelReservationButton.TabIndex = 9;
            cancelReservationButton.Text = "Otkazi rezervaciju";
            cancelReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            cancelReservationButton.Click += cancelReservationButton_Click;
            // 
            // deleteReservationButton
            // 
            deleteReservationButton.BackColor = Color.Transparent;
            deleteReservationButton.BaseColor = Color.Red;
            deleteReservationButton.Cursor = Cursors.Hand;
            deleteReservationButton.Font = new Font("Segoe UI", 12F);
            deleteReservationButton.Location = new Point(569, 12);
            deleteReservationButton.Name = "deleteReservationButton";
            deleteReservationButton.Rounded = true;
            deleteReservationButton.Size = new Size(183, 45);
            deleteReservationButton.TabIndex = 8;
            deleteReservationButton.Text = "Obriši rezervaciju";
            deleteReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            deleteReservationButton.Click += deleteReservationButton_Click;
            // 
            // editReservationButton
            // 
            editReservationButton.BackColor = Color.Transparent;
            editReservationButton.BaseColor = Color.FromArgb(56, 95, 235);
            editReservationButton.Font = new Font("Segoe UI", 12F);
            editReservationButton.Location = new Point(192, 12);
            editReservationButton.Name = "editReservationButton";
            editReservationButton.Rounded = true;
            editReservationButton.Size = new Size(183, 45);
            editReservationButton.TabIndex = 7;
            editReservationButton.Text = "Izmena podataka";
            editReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            editReservationButton.Click += editReservationButton_Click;
            // 
            // addReservationButton
            // 
            addReservationButton.BackColor = Color.Transparent;
            addReservationButton.BaseColor = Color.FromArgb(35, 168, 109);
            addReservationButton.Cursor = Cursors.Hand;
            addReservationButton.Font = new Font("Segoe UI", 12F);
            addReservationButton.Location = new Point(11, 12);
            addReservationButton.Name = "addReservationButton";
            addReservationButton.Rounded = true;
            addReservationButton.Size = new Size(175, 45);
            addReservationButton.TabIndex = 2;
            addReservationButton.Text = "Dodaj rezervaciju";
            addReservationButton.TextColor = Color.FromArgb(243, 243, 243);
            addReservationButton.Click += addReservationButton_Click;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(272, 5);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(85, 20);
            locationLabel.TabIndex = 19;
            locationLabel.Text = "Lokacija:";
            locationLabel.Visible = false;
            // 
            // locationComboBox
            // 
            locationComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            locationComboBox.BGColor = Color.FromArgb(18, 26, 33);
            locationComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            locationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            locationComboBox.Font = new Font("Segoe UI", 8F);
            locationComboBox.ForeColor = Color.White;
            locationComboBox.FormattingEnabled = true;
            locationComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            locationComboBox.HoverFontColor = Color.White;
            locationComboBox.ItemHeight = 25;
            locationComboBox.Items.AddRange(new object[] { "Sve" });
            locationComboBox.Location = new Point(272, 28);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(223, 31);
            locationComboBox.TabIndex = 18;
            locationComboBox.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BaseColor = Color.FromArgb(8, 133, 161);
            searchButton.Cursor = Cursors.Hand;
            searchButton.Font = new Font("Segoe UI", 12F);
            searchButton.Location = new Point(949, 25);
            searchButton.Name = "searchButton";
            searchButton.Rounded = true;
            searchButton.Size = new Size(112, 45);
            searchButton.TabIndex = 10;
            searchButton.Text = "Pretraga";
            searchButton.TextColor = Color.FromArgb(243, 243, 243);
            searchButton.Visible = false;
            searchButton.Click += searchButton_Click;
            // 
            // filteringpanel
            // 
            filteringpanel.BackColor = Color.FromArgb(37, 52, 68);
            filteringpanel.BorderStyle = BorderStyle.FixedSingle;
            filteringpanel.Controls.Add(dateLabel);
            filteringpanel.Controls.Add(searchButton);
            filteringpanel.Controls.Add(dateDateTime);
            filteringpanel.Controls.Add(doneCheckBox);
            filteringpanel.Controls.Add(confirmedCheckBox);
            filteringpanel.Controls.Add(locationLabel);
            filteringpanel.Controls.Add(locationComboBox);
            filteringpanel.Controls.Add(cancelledCheckBox);
            filteringpanel.Controls.Add(userLabel);
            filteringpanel.Controls.Add(locationDateRadioButton);
            filteringpanel.Controls.Add(reservedCheckBox);
            filteringpanel.Controls.Add(userRadioButton);
            filteringpanel.Controls.Add(userTextBox);
            filteringpanel.Dock = DockStyle.Top;
            filteringpanel.Location = new Point(0, 141);
            filteringpanel.Name = "filteringpanel";
            filteringpanel.Size = new Size(1313, 97);
            filteringpanel.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dateLabel.ForeColor = Color.FromArgb(255, 255, 255);
            dateLabel.Location = new Point(525, 6);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(70, 20);
            dateLabel.TabIndex = 27;
            dateLabel.Text = "Datum:";
            dateLabel.Visible = false;
            // 
            // dateDateTime
            // 
            dateDateTime.CalendarMonthBackground = Color.FromArgb(18, 26, 33);
            dateDateTime.CustomFormat = "dddd, MMMM dd, yyyy";
            dateDateTime.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dateDateTime.Format = DateTimePickerFormat.Custom;
            dateDateTime.Location = new Point(525, 29);
            dateDateTime.MinimumSize = new Size(0, 30);
            dateDateTime.Name = "dateDateTime";
            dateDateTime.Size = new Size(200, 30);
            dateDateTime.TabIndex = 8;
            dateDateTime.Visible = false;
            // 
            // doneCheckBox
            // 
            doneCheckBox.BackColor = Color.Transparent;
            doneCheckBox.Background = true;
            doneCheckBox.Background_WidthPen = 2F;
            doneCheckBox.BackgroundPen = true;
            doneCheckBox.Checked = false;
            doneCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            doneCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            doneCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            doneCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            doneCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            doneCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            doneCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            doneCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            doneCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            doneCheckBox.Effect_1_Transparency = 25;
            doneCheckBox.Effect_2 = true;
            doneCheckBox.Effect_2_ColorBackground = Color.White;
            doneCheckBox.Effect_2_Transparency = 15;
            doneCheckBox.Font = new Font("Arial", 12F);
            doneCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            doneCheckBox.LinearGradient_Background = false;
            doneCheckBox.LinearGradientPen = false;
            doneCheckBox.Location = new Point(778, 42);
            doneCheckBox.Name = "doneCheckBox";
            doneCheckBox.RGB = false;
            doneCheckBox.Rounding = false;
            doneCheckBox.RoundingInt = 100;
            doneCheckBox.Size = new Size(165, 45);
            doneCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            doneCheckBox.TabIndex = 26;
            doneCheckBox.Tag = "Cyber";
            doneCheckBox.TextButton = "Zavrsena";
            doneCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            doneCheckBox.Timer_Effect_1 = 1;
            doneCheckBox.Timer_RGB = 300;
            doneCheckBox.Visible = false;
            // 
            // confirmedCheckBox
            // 
            confirmedCheckBox.BackColor = Color.Transparent;
            confirmedCheckBox.Background = true;
            confirmedCheckBox.Background_WidthPen = 2F;
            confirmedCheckBox.BackgroundPen = true;
            confirmedCheckBox.Checked = false;
            confirmedCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            confirmedCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            confirmedCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            confirmedCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            confirmedCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            confirmedCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            confirmedCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            confirmedCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            confirmedCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            confirmedCheckBox.Effect_1_Transparency = 25;
            confirmedCheckBox.Effect_2 = true;
            confirmedCheckBox.Effect_2_ColorBackground = Color.White;
            confirmedCheckBox.Effect_2_Transparency = 15;
            confirmedCheckBox.Font = new Font("Arial", 12F);
            confirmedCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            confirmedCheckBox.LinearGradient_Background = false;
            confirmedCheckBox.LinearGradientPen = false;
            confirmedCheckBox.Location = new Point(778, 5);
            confirmedCheckBox.Name = "confirmedCheckBox";
            confirmedCheckBox.RGB = false;
            confirmedCheckBox.Rounding = false;
            confirmedCheckBox.RoundingInt = 100;
            confirmedCheckBox.Size = new Size(165, 45);
            confirmedCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            confirmedCheckBox.TabIndex = 25;
            confirmedCheckBox.Tag = "Cyber";
            confirmedCheckBox.TextButton = "Potvrdjena";
            confirmedCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            confirmedCheckBox.Timer_Effect_1 = 1;
            confirmedCheckBox.Timer_RGB = 300;
            confirmedCheckBox.Visible = false;
            // 
            // cancelledCheckBox
            // 
            cancelledCheckBox.BackColor = Color.Transparent;
            cancelledCheckBox.Background = true;
            cancelledCheckBox.Background_WidthPen = 2F;
            cancelledCheckBox.BackgroundPen = true;
            cancelledCheckBox.Checked = false;
            cancelledCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            cancelledCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cancelledCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cancelledCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cancelledCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            cancelledCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cancelledCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cancelledCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cancelledCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cancelledCheckBox.Effect_1_Transparency = 25;
            cancelledCheckBox.Effect_2 = true;
            cancelledCheckBox.Effect_2_ColorBackground = Color.White;
            cancelledCheckBox.Effect_2_Transparency = 15;
            cancelledCheckBox.Font = new Font("Arial", 12F);
            cancelledCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            cancelledCheckBox.LinearGradient_Background = false;
            cancelledCheckBox.LinearGradientPen = false;
            cancelledCheckBox.Location = new Point(589, 42);
            cancelledCheckBox.Name = "cancelledCheckBox";
            cancelledCheckBox.RGB = false;
            cancelledCheckBox.Rounding = false;
            cancelledCheckBox.RoundingInt = 100;
            cancelledCheckBox.Size = new Size(212, 45);
            cancelledCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cancelledCheckBox.TabIndex = 24;
            cancelledCheckBox.Tag = "Cyber";
            cancelledCheckBox.TextButton = "Otkazana";
            cancelledCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cancelledCheckBox.Timer_Effect_1 = 1;
            cancelledCheckBox.Timer_RGB = 300;
            cancelledCheckBox.Visible = false;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(272, 5);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(83, 20);
            userLabel.TabIndex = 23;
            userLabel.Text = "Korisnik:";
            userLabel.Visible = false;
            // 
            // locationDateRadioButton
            // 
            locationDateRadioButton.BackColor = Color.Transparent;
            locationDateRadioButton.Background = true;
            locationDateRadioButton.Background_WidthPen = 2F;
            locationDateRadioButton.BackgroundPen = true;
            locationDateRadioButton.Checked = false;
            locationDateRadioButton.Color_1_Background_value = Color.Empty;
            locationDateRadioButton.Color_2_Background_value = Color.Empty;
            locationDateRadioButton.ColorBackground = Color.FromArgb(37, 52, 68);
            locationDateRadioButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            locationDateRadioButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            locationDateRadioButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            locationDateRadioButton.ColorChecked = Color.FromArgb(29, 200, 238);
            locationDateRadioButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            locationDateRadioButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            locationDateRadioButton.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            locationDateRadioButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            locationDateRadioButton.Effect_1_Transparency = 25;
            locationDateRadioButton.Effect_2 = true;
            locationDateRadioButton.Effect_2_ColorBackground = Color.White;
            locationDateRadioButton.Effect_2_Transparency = 15;
            locationDateRadioButton.Font = new Font("Arial", 11F);
            locationDateRadioButton.ForeColor = Color.FromArgb(245, 245, 245);
            locationDateRadioButton.LinearGradient_Background = false;
            locationDateRadioButton.LinearGradient_Value = false;
            locationDateRadioButton.LinearGradientPen = false;
            locationDateRadioButton.Location = new Point(11, 42);
            locationDateRadioButton.Name = "locationDateRadioButton";
            locationDateRadioButton.RGB = false;
            locationDateRadioButton.Rounding = true;
            locationDateRadioButton.RoundingInt = 100;
            locationDateRadioButton.Size = new Size(225, 45);
            locationDateRadioButton.SizeChecked = 8;
            locationDateRadioButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            locationDateRadioButton.TabIndex = 22;
            locationDateRadioButton.Tag = "Cyber";
            locationDateRadioButton.TextButton = "Lokacija i datum";
            locationDateRadioButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            locationDateRadioButton.Timer_Effect_1 = 1;
            locationDateRadioButton.Timer_RGB = 300;
            locationDateRadioButton.CheckedChanged += locationDateRadioButton_CheckedChanged;
            // 
            // reservedCheckBox
            // 
            reservedCheckBox.BackColor = Color.Transparent;
            reservedCheckBox.Background = true;
            reservedCheckBox.Background_WidthPen = 2F;
            reservedCheckBox.BackgroundPen = true;
            reservedCheckBox.Checked = false;
            reservedCheckBox.ColorBackground = Color.FromArgb(37, 52, 68);
            reservedCheckBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            reservedCheckBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            reservedCheckBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            reservedCheckBox.ColorChecked = Color.FromArgb(29, 200, 238);
            reservedCheckBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            reservedCheckBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            reservedCheckBox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            reservedCheckBox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            reservedCheckBox.Effect_1_Transparency = 25;
            reservedCheckBox.Effect_2 = true;
            reservedCheckBox.Effect_2_ColorBackground = Color.White;
            reservedCheckBox.Effect_2_Transparency = 15;
            reservedCheckBox.Font = new Font("Arial", 12F);
            reservedCheckBox.ForeColor = Color.FromArgb(245, 245, 245);
            reservedCheckBox.LinearGradient_Background = false;
            reservedCheckBox.LinearGradientPen = false;
            reservedCheckBox.Location = new Point(589, 5);
            reservedCheckBox.Name = "reservedCheckBox";
            reservedCheckBox.RGB = false;
            reservedCheckBox.Rounding = false;
            reservedCheckBox.RoundingInt = 100;
            reservedCheckBox.Size = new Size(212, 45);
            reservedCheckBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            reservedCheckBox.TabIndex = 20;
            reservedCheckBox.Tag = "Cyber";
            reservedCheckBox.TextButton = "Rezervisana";
            reservedCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            reservedCheckBox.Timer_Effect_1 = 1;
            reservedCheckBox.Timer_RGB = 300;
            reservedCheckBox.Visible = false;
            // 
            // userRadioButton
            // 
            userRadioButton.BackColor = Color.Transparent;
            userRadioButton.Background = true;
            userRadioButton.Background_WidthPen = 2F;
            userRadioButton.BackgroundPen = true;
            userRadioButton.Checked = false;
            userRadioButton.Color_1_Background_value = Color.Empty;
            userRadioButton.Color_2_Background_value = Color.Empty;
            userRadioButton.ColorBackground = Color.FromArgb(37, 52, 68);
            userRadioButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            userRadioButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            userRadioButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            userRadioButton.ColorChecked = Color.FromArgb(29, 200, 238);
            userRadioButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            userRadioButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            userRadioButton.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            userRadioButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            userRadioButton.Effect_1_Transparency = 25;
            userRadioButton.Effect_2 = true;
            userRadioButton.Effect_2_ColorBackground = Color.White;
            userRadioButton.Effect_2_Transparency = 15;
            userRadioButton.Font = new Font("Arial", 11F);
            userRadioButton.ForeColor = Color.FromArgb(245, 245, 245);
            userRadioButton.LinearGradient_Background = false;
            userRadioButton.LinearGradient_Value = false;
            userRadioButton.LinearGradientPen = false;
            userRadioButton.Location = new Point(11, 5);
            userRadioButton.Name = "userRadioButton";
            userRadioButton.RGB = false;
            userRadioButton.Rounding = true;
            userRadioButton.RoundingInt = 100;
            userRadioButton.Size = new Size(255, 45);
            userRadioButton.SizeChecked = 8;
            userRadioButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            userRadioButton.TabIndex = 21;
            userRadioButton.Tag = "Cyber";
            userRadioButton.TextButton = "Korisnik";
            userRadioButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            userRadioButton.Timer_Effect_1 = 1;
            userRadioButton.Timer_RGB = 300;
            userRadioButton.CheckedChanged += userRadioButton_CheckedChanged;
            // 
            // userTextBox
            // 
            userTextBox.BaseColor = Color.FromArgb(8, 133, 161);
            userTextBox.BGColor = Color.FromArgb(18, 26, 33);
            userTextBox.DrawMode = DrawMode.OwnerDrawFixed;
            userTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userTextBox.Font = new Font("Segoe UI", 8F);
            userTextBox.ForeColor = Color.White;
            userTextBox.FormattingEnabled = true;
            userTextBox.HoverColor = Color.FromArgb(35, 168, 109);
            userTextBox.HoverFontColor = Color.White;
            userTextBox.ItemHeight = 25;
            userTextBox.Location = new Point(272, 29);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(291, 31);
            userTextBox.TabIndex = 28;
            userTextBox.Visible = false;
            userTextBox.SelectedIndexChanged += userTextBox_SelectedIndexChanged;
            // 
            // reservationDataGridView
            // 
            reservationDataGridView.AllowUserToAddRows = false;
            reservationDataGridView.AllowUserToDeleteRows = false;
            reservationDataGridView.AllowUserToResizeRows = false;
            reservationDataGridView.BackgroundColor = Color.FromArgb(37, 52, 68);
            reservationDataGridView.BorderStyle = BorderStyle.None;
            reservationDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            reservationDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            reservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            reservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            reservationDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            reservationDataGridView.Dock = DockStyle.Fill;
            reservationDataGridView.EnableHeadersVisualStyles = false;
            reservationDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            reservationDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            reservationDataGridView.Location = new Point(0, 238);
            reservationDataGridView.Name = "reservationDataGridView";
            reservationDataGridView.ReadOnly = true;
            reservationDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            reservationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            reservationDataGridView.RowHeadersWidth = 51;
            reservationDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            reservationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationDataGridView.Size = new Size(1313, 366);
            reservationDataGridView.TabIndex = 8;
            // 
            // Rezervacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 604);
            Controls.Add(reservationDataGridView);
            Controls.Add(filteringpanel);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "Rezervacije";
            Text = "Rezervacije";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filteringpanel.ResumeLayout(false);
            filteringpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel filterPanel;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.ForeverButton editReservationButton;
        private ReaLTaiizor.Controls.ForeverButton deleteReservationButton;
        private ReaLTaiizor.Controls.ForeverButton addReservationButton;
        private Panel filteringpanel;
        private ReaLTaiizor.Controls.CyberCheckBox reservedCheckBox;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.ForeverComboBox locationComboBox;
        private ReaLTaiizor.Controls.PoisonDataGridView reservationDataGridView;
        private ReaLTaiizor.Controls.CyberRadioButton locationDateRadioButton;
        private ReaLTaiizor.Controls.CyberRadioButton userRadioButton;
        private ReaLTaiizor.Controls.CyberCheckBox cancelledCheckBox;
        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.CyberCheckBox doneCheckBox;
        private ReaLTaiizor.Controls.CyberCheckBox confirmedCheckBox;
        private ReaLTaiizor.Controls.HeaderLabel dateLabel;
        private ReaLTaiizor.Controls.PoisonDateTime dateDateTime;
        private ReaLTaiizor.Controls.ForeverComboBox userTextBox;
        private ReaLTaiizor.Controls.ForeverButton cancelReservationButton;
    }
}

