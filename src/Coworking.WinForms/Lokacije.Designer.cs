namespace Coworking.WinForms
{
    partial class Lokacije
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            headerPanel = new Panel();
            activeLocationsRadioButton = new ReaLTaiizor.Controls.CyberRadioButton();
            showStatisticsRadioButton = new ReaLTaiizor.Controls.CyberRadioButton();
            filterPanel = new Panel();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            editLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            addLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            locationDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(478, 12);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(164, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Lokacije";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(37, 52, 68);
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(activeLocationsRadioButton);
            headerPanel.Controls.Add(showStatisticsRadioButton);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1102, 69);
            headerPanel.TabIndex = 1;
            // 
            // activeLocationsRadioButton
            // 
            activeLocationsRadioButton.BackColor = Color.Transparent;
            activeLocationsRadioButton.Background = true;
            activeLocationsRadioButton.Background_WidthPen = 2F;
            activeLocationsRadioButton.BackgroundPen = true;
            activeLocationsRadioButton.Checked = false;
            activeLocationsRadioButton.Color_1_Background_value = Color.Empty;
            activeLocationsRadioButton.Color_2_Background_value = Color.Empty;
            activeLocationsRadioButton.ColorBackground = Color.FromArgb(37, 52, 68);
            activeLocationsRadioButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            activeLocationsRadioButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            activeLocationsRadioButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            activeLocationsRadioButton.ColorChecked = Color.FromArgb(29, 200, 238);
            activeLocationsRadioButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            activeLocationsRadioButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            activeLocationsRadioButton.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            activeLocationsRadioButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            activeLocationsRadioButton.Effect_1_Transparency = 25;
            activeLocationsRadioButton.Effect_2 = true;
            activeLocationsRadioButton.Effect_2_ColorBackground = Color.White;
            activeLocationsRadioButton.Effect_2_Transparency = 15;
            activeLocationsRadioButton.Font = new Font("Arial", 11F);
            activeLocationsRadioButton.ForeColor = Color.FromArgb(245, 245, 245);
            activeLocationsRadioButton.LinearGradient_Background = false;
            activeLocationsRadioButton.LinearGradient_Value = false;
            activeLocationsRadioButton.LinearGradientPen = false;
            activeLocationsRadioButton.Location = new Point(11, 12);
            activeLocationsRadioButton.Name = "activeLocationsRadioButton";
            activeLocationsRadioButton.RGB = false;
            activeLocationsRadioButton.Rounding = true;
            activeLocationsRadioButton.RoundingInt = 100;
            activeLocationsRadioButton.Size = new Size(180, 45);
            activeLocationsRadioButton.SizeChecked = 8;
            activeLocationsRadioButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            activeLocationsRadioButton.TabIndex = 29;
            activeLocationsRadioButton.Tag = "Cyber";
            activeLocationsRadioButton.TextButton = "Aktivne lokacije";
            activeLocationsRadioButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            activeLocationsRadioButton.Timer_Effect_1 = 1;
            activeLocationsRadioButton.Timer_RGB = 300;
            // 
            // showStatisticsRadioButton
            // 
            showStatisticsRadioButton.BackColor = Color.Transparent;
            showStatisticsRadioButton.Background = true;
            showStatisticsRadioButton.Background_WidthPen = 2F;
            showStatisticsRadioButton.BackgroundPen = true;
            showStatisticsRadioButton.Checked = false;
            showStatisticsRadioButton.Color_1_Background_value = Color.Empty;
            showStatisticsRadioButton.Color_2_Background_value = Color.Empty;
            showStatisticsRadioButton.ColorBackground = Color.FromArgb(37, 52, 68);
            showStatisticsRadioButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            showStatisticsRadioButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            showStatisticsRadioButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            showStatisticsRadioButton.ColorChecked = Color.FromArgb(29, 200, 238);
            showStatisticsRadioButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            showStatisticsRadioButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            showStatisticsRadioButton.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            showStatisticsRadioButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            showStatisticsRadioButton.Effect_1_Transparency = 25;
            showStatisticsRadioButton.Effect_2 = true;
            showStatisticsRadioButton.Effect_2_ColorBackground = Color.White;
            showStatisticsRadioButton.Effect_2_Transparency = 15;
            showStatisticsRadioButton.Font = new Font("Arial", 11F);
            showStatisticsRadioButton.ForeColor = Color.FromArgb(245, 245, 245);
            showStatisticsRadioButton.LinearGradient_Background = false;
            showStatisticsRadioButton.LinearGradient_Value = false;
            showStatisticsRadioButton.LinearGradientPen = false;
            showStatisticsRadioButton.Location = new Point(213, 12);
            showStatisticsRadioButton.Name = "showStatisticsRadioButton";
            showStatisticsRadioButton.RGB = false;
            showStatisticsRadioButton.Rounding = true;
            showStatisticsRadioButton.RoundingInt = 100;
            showStatisticsRadioButton.Size = new Size(180, 45);
            showStatisticsRadioButton.SizeChecked = 8;
            showStatisticsRadioButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            showStatisticsRadioButton.TabIndex = 28;
            showStatisticsRadioButton.Tag = "Cyber";
            showStatisticsRadioButton.TextButton = "Prikazi statistiku";
            showStatisticsRadioButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            showStatisticsRadioButton.Timer_Effect_1 = 1;
            showStatisticsRadioButton.Timer_RGB = 300;
            showStatisticsRadioButton.Click += showStatisticsRadioButton_Click;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(searchButton);
            filterPanel.Controls.Add(editLocationButton);
            filterPanel.Controls.Add(deleteLocationButton);
            filterPanel.Controls.Add(addLocationButton);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1102, 72);
            filterPanel.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Alpha = 20;
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.BackColor = Color.Transparent;
            searchTextBox.Background_WidthPen = 3F;
            searchTextBox.BackgroundPen = true;
            searchTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            searchTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            searchTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            searchTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            searchTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            searchTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            searchTextBox.Font = new Font("Arial", 11F);
            searchTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            searchTextBox.Lighting = false;
            searchTextBox.LinearGradientPen = false;
            searchTextBox.Location = new Point(597, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PenWidth = 15;
            searchTextBox.RGB = false;
            searchTextBox.Rounding = true;
            searchTextBox.RoundingInt = 60;
            searchTextBox.Size = new Size(374, 45);
            searchTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            searchTextBox.TabIndex = 9;
            searchTextBox.Tag = "Cyber";
            searchTextBox.TextButton = "";
            searchTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            searchTextBox.Timer_RGB = 300;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.Transparent;
            searchButton.BaseColor = Color.FromArgb(8, 133, 161);
            searchButton.Cursor = Cursors.Hand;
            searchButton.Font = new Font("Segoe UI", 12F);
            searchButton.Location = new Point(977, 12);
            searchButton.Name = "searchButton";
            searchButton.Rounded = true;
            searchButton.Size = new Size(112, 45);
            searchButton.TabIndex = 8;
            searchButton.Text = "Pretraga";
            searchButton.TextColor = Color.FromArgb(243, 243, 243);
            searchButton.Click += searchButton_Click;
            // 
            // editLocationButton
            // 
            editLocationButton.BackColor = Color.Transparent;
            editLocationButton.BaseColor = Color.FromArgb(56, 95, 235);
            editLocationButton.Font = new Font("Segoe UI", 12F);
            editLocationButton.Location = new Point(180, 12);
            editLocationButton.Name = "editLocationButton";
            editLocationButton.Rounded = true;
            editLocationButton.Size = new Size(183, 45);
            editLocationButton.TabIndex = 7;
            editLocationButton.Text = "Izmena podataka";
            editLocationButton.TextColor = Color.FromArgb(243, 243, 243);
            editLocationButton.Click += editLocationButton_Click;
            // 
            // deleteLocationButton
            // 
            deleteLocationButton.BackColor = Color.Transparent;
            deleteLocationButton.BaseColor = Color.Red;
            deleteLocationButton.Cursor = Cursors.Hand;
            deleteLocationButton.Font = new Font("Segoe UI", 12F);
            deleteLocationButton.Location = new Point(381, 12);
            deleteLocationButton.Name = "deleteLocationButton";
            deleteLocationButton.Rounded = true;
            deleteLocationButton.Size = new Size(150, 45);
            deleteLocationButton.TabIndex = 3;
            deleteLocationButton.Text = "Obriši lokaciju";
            deleteLocationButton.TextColor = Color.FromArgb(243, 243, 243);
            deleteLocationButton.Click += deleteLocationButton_Click;
            // 
            // addLocationButton
            // 
            addLocationButton.BackColor = Color.Transparent;
            addLocationButton.BaseColor = Color.FromArgb(35, 168, 109);
            addLocationButton.Cursor = Cursors.Hand;
            addLocationButton.Font = new Font("Segoe UI", 12F);
            addLocationButton.Location = new Point(11, 12);
            addLocationButton.Name = "addLocationButton";
            addLocationButton.Rounded = true;
            addLocationButton.Size = new Size(150, 45);
            addLocationButton.TabIndex = 2;
            addLocationButton.Text = "Dodaj lokaciju";
            addLocationButton.TextColor = Color.FromArgb(243, 243, 243);
            addLocationButton.Click += addLocationButton_Click;
            // 
            // locationDataGridView
            // 
            locationDataGridView.AllowUserToAddRows = false;
            locationDataGridView.AllowUserToDeleteRows = false;
            locationDataGridView.AllowUserToResizeRows = false;
            locationDataGridView.BackgroundColor = Color.FromArgb(37, 52, 68);
            locationDataGridView.BorderStyle = BorderStyle.None;
            locationDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            locationDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            locationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            locationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            locationDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            locationDataGridView.Dock = DockStyle.Fill;
            locationDataGridView.EnableHeadersVisualStyles = false;
            locationDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            locationDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            locationDataGridView.Location = new Point(0, 141);
            locationDataGridView.Name = "locationDataGridView";
            locationDataGridView.ReadOnly = true;
            locationDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            locationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            locationDataGridView.RowHeadersWidth = 51;
            locationDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            locationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            locationDataGridView.Size = new Size(1102, 463);
            locationDataGridView.TabIndex = 3;
            // 
            // Lokacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 604);
            Controls.Add(locationDataGridView);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "Lokacije";
            Text = "Lokacije";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)locationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel headerPanel;
        private Panel filterPanel;
        private ReaLTaiizor.Controls.ForeverButton editLocationButton;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
        private ReaLTaiizor.Controls.ForeverButton deleteLocationButton;
        private ReaLTaiizor.Controls.ForeverButton addLocationButton;
        private ReaLTaiizor.Controls.CyberTextBox searchTextBox;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.PoisonDataGridView locationDataGridView;
        private ReaLTaiizor.Controls.CyberRadioButton activeLocationsRadioButton;
        private ReaLTaiizor.Controls.CyberRadioButton showStatisticsRadioButton;
    }
}