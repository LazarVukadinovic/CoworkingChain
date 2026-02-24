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
            filterPaanel = new Panel();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            editLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            addLocationButton = new ReaLTaiizor.Controls.ForeverButton();
            memberDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            headerPanel.SuspendLayout();
            filterPaanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).BeginInit();
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
            // filterPaanel
            // 
            filterPaanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPaanel.BorderStyle = BorderStyle.FixedSingle;
            filterPaanel.Controls.Add(searchTextBox);
            filterPaanel.Controls.Add(searchButton);
            filterPaanel.Controls.Add(editLocationButton);
            filterPaanel.Controls.Add(deleteLocationButton);
            filterPaanel.Controls.Add(addLocationButton);
            filterPaanel.Dock = DockStyle.Top;
            filterPaanel.Location = new Point(0, 69);
            filterPaanel.Name = "filterPaanel";
            filterPaanel.Size = new Size(1102, 72);
            filterPaanel.TabIndex = 2;
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
            // memberDataGridView
            // 
            memberDataGridView.AllowUserToAddRows = false;
            memberDataGridView.AllowUserToDeleteRows = false;
            memberDataGridView.AllowUserToResizeRows = false;
            memberDataGridView.BackgroundColor = Color.FromArgb(37, 52, 68);
            memberDataGridView.BorderStyle = BorderStyle.None;
            memberDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            memberDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            memberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            memberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            memberDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            memberDataGridView.Dock = DockStyle.Fill;
            memberDataGridView.EnableHeadersVisualStyles = false;
            memberDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            memberDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            memberDataGridView.Location = new Point(0, 141);
            memberDataGridView.Name = "memberDataGridView";
            memberDataGridView.ReadOnly = true;
            memberDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            memberDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            memberDataGridView.RowHeadersWidth = 51;
            memberDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            memberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberDataGridView.Size = new Size(1102, 463);
            memberDataGridView.TabIndex = 3;
            // 
            // Lokacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 604);
            Controls.Add(memberDataGridView);
            Controls.Add(filterPaanel);
            Controls.Add(headerPanel);
            Name = "Lokacije";
            Text = "Lokacije";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPaanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel headerPanel;
        private Panel filterPaanel;
        private ReaLTaiizor.Controls.ForeverButton editLocationButton;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
        private ReaLTaiizor.Controls.ForeverButton deleteLocationButton;
        private ReaLTaiizor.Controls.ForeverButton addLocationButton;
        private ReaLTaiizor.Controls.CyberTextBox searchTextBox;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.PoisonDataGridView memberDataGridView;
    }
}