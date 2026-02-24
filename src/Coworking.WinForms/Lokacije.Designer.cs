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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            headerPanel = new Panel();
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
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1102, 69);
            headerPanel.TabIndex = 1;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            locationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            locationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            locationDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            locationDataGridView.Dock = DockStyle.Fill;
            locationDataGridView.EnableHeadersVisualStyles = false;
            locationDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            locationDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            locationDataGridView.Location = new Point(0, 141);
            locationDataGridView.Name = "locationDataGridView";
            locationDataGridView.ReadOnly = true;
            locationDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            locationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
    }
}