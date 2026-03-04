namespace Coworking.WinForms
{
    partial class Resursi
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
            filterPanel = new Panel();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            editResourceButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteResourceButton = new ReaLTaiizor.Controls.ForeverButton();
            addResourceButton = new ReaLTaiizor.Controls.ForeverButton();
            resourceDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            filteringpanel = new Panel();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            resourceTypeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            resourceTypeComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resourceDataGridView).BeginInit();
            filteringpanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(484, 10);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(152, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Resursi";
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
            headerPanel.TabIndex = 3;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(searchButton);
            filterPanel.Controls.Add(editResourceButton);
            filterPanel.Controls.Add(deleteResourceButton);
            filterPanel.Controls.Add(addResourceButton);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1102, 72);
            filterPanel.TabIndex = 4;
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
            searchTextBox.TabIndex = 11;
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
            searchButton.TabIndex = 10;
            searchButton.Text = "Pretraga";
            searchButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // editResourceButton
            // 
            editResourceButton.BackColor = Color.Transparent;
            editResourceButton.BaseColor = Color.FromArgb(56, 95, 235);
            editResourceButton.Font = new Font("Segoe UI", 12F);
            editResourceButton.Location = new Point(180, 12);
            editResourceButton.Name = "editResourceButton";
            editResourceButton.Rounded = true;
            editResourceButton.Size = new Size(183, 45);
            editResourceButton.TabIndex = 7;
            editResourceButton.Text = "Izmena podataka";
            editResourceButton.TextColor = Color.FromArgb(243, 243, 243);
            editResourceButton.Click += editResourceButton_Click;
            // 
            // deleteResourceButton
            // 
            deleteResourceButton.BackColor = Color.Transparent;
            deleteResourceButton.BaseColor = Color.Red;
            deleteResourceButton.Cursor = Cursors.Hand;
            deleteResourceButton.Font = new Font("Segoe UI", 12F);
            deleteResourceButton.Location = new Point(381, 12);
            deleteResourceButton.Name = "deleteResourceButton";
            deleteResourceButton.Rounded = true;
            deleteResourceButton.Size = new Size(150, 45);
            deleteResourceButton.TabIndex = 3;
            deleteResourceButton.Text = "Obriši resurs";
            deleteResourceButton.TextColor = Color.FromArgb(243, 243, 243);
            deleteResourceButton.Click += deleteResourceButton_Click;
            // 
            // addResourceButton
            // 
            addResourceButton.BackColor = Color.Transparent;
            addResourceButton.BaseColor = Color.FromArgb(35, 168, 109);
            addResourceButton.Cursor = Cursors.Hand;
            addResourceButton.Font = new Font("Segoe UI", 12F);
            addResourceButton.Location = new Point(11, 12);
            addResourceButton.Name = "addResourceButton";
            addResourceButton.Rounded = true;
            addResourceButton.Size = new Size(150, 45);
            addResourceButton.TabIndex = 2;
            addResourceButton.Text = "Dodaj resurs";
            addResourceButton.TextColor = Color.FromArgb(243, 243, 243);
            addResourceButton.Click += addResourceButton_Click;
            // 
            // resourceDataGridView
            // 
            resourceDataGridView.AllowUserToAddRows = false;
            resourceDataGridView.AllowUserToDeleteRows = false;
            resourceDataGridView.AllowUserToResizeRows = false;
            resourceDataGridView.BackgroundColor = Color.FromArgb(37, 52, 68);
            resourceDataGridView.BorderStyle = BorderStyle.None;
            resourceDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            resourceDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resourceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resourceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resourceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resourceDataGridView.Dock = DockStyle.Fill;
            resourceDataGridView.EnableHeadersVisualStyles = false;
            resourceDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            resourceDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            resourceDataGridView.Location = new Point(0, 238);
            resourceDataGridView.Name = "resourceDataGridView";
            resourceDataGridView.ReadOnly = true;
            resourceDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            resourceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            resourceDataGridView.RowHeadersWidth = 51;
            resourceDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            resourceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resourceDataGridView.Size = new Size(1102, 366);
            resourceDataGridView.TabIndex = 5;
            resourceDataGridView.CellContentClick += resourceDataGridView_CellContentClick;
            // 
            // filteringpanel
            // 
            filteringpanel.BackColor = Color.FromArgb(37, 52, 68);
            filteringpanel.BorderStyle = BorderStyle.FixedSingle;
            filteringpanel.Controls.Add(locationLabel);
            filteringpanel.Controls.Add(locationComboBox);
            filteringpanel.Controls.Add(resourceTypeLabel);
            filteringpanel.Controls.Add(resourceTypeComboBox);
            filteringpanel.Dock = DockStyle.Top;
            filteringpanel.Location = new Point(0, 141);
            filteringpanel.Name = "filteringpanel";
            filteringpanel.Size = new Size(1102, 97);
            filteringpanel.TabIndex = 6;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = Color.Transparent;
            locationLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            locationLabel.ForeColor = Color.FromArgb(255, 255, 255);
            locationLabel.Location = new Point(268, 23);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(85, 20);
            locationLabel.TabIndex = 19;
            locationLabel.Text = "Lokacija:";
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
            locationComboBox.Location = new Point(268, 46);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(223, 31);
            locationComboBox.TabIndex = 18;
            locationComboBox.SelectedIndexChanged += locationComboBox_SelectedIndexChanged;
            // 
            // resourceTypeLabel
            // 
            resourceTypeLabel.AutoSize = true;
            resourceTypeLabel.BackColor = Color.Transparent;
            resourceTypeLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            resourceTypeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            resourceTypeLabel.Location = new Point(12, 23);
            resourceTypeLabel.Name = "resourceTypeLabel";
            resourceTypeLabel.Size = new Size(111, 20);
            resourceTypeLabel.TabIndex = 17;
            resourceTypeLabel.Text = "Tip resursa:";
            // 
            // resourceTypeComboBox
            // 
            resourceTypeComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            resourceTypeComboBox.BGColor = Color.FromArgb(18, 26, 33);
            resourceTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            resourceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            resourceTypeComboBox.Font = new Font("Segoe UI", 8F);
            resourceTypeComboBox.ForeColor = Color.White;
            resourceTypeComboBox.FormattingEnabled = true;
            resourceTypeComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            resourceTypeComboBox.HoverFontColor = Color.White;
            resourceTypeComboBox.ItemHeight = 25;
            resourceTypeComboBox.Items.AddRange(new object[] { "Svi", "sala", "radno_mesto" });
            resourceTypeComboBox.Location = new Point(12, 46);
            resourceTypeComboBox.Name = "resourceTypeComboBox";
            resourceTypeComboBox.Size = new Size(223, 31);
            resourceTypeComboBox.TabIndex = 0;
            resourceTypeComboBox.SelectedIndexChanged += resourceTypeComboBox_SelectedIndexChanged;
            // 
            // Resursi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 604);
            Controls.Add(resourceDataGridView);
            Controls.Add(filteringpanel);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "Resursi";
            Text = "Resursi";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resourceDataGridView).EndInit();
            filteringpanel.ResumeLayout(false);
            filteringpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel headerPanel;
        private Panel filterPanel;
        private ReaLTaiizor.Controls.CyberTextBox searchTextBox;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.ForeverButton editResourceButton;
        private ReaLTaiizor.Controls.ForeverButton deleteResourceButton;
        private ReaLTaiizor.Controls.ForeverButton addResourceButton;
        private ReaLTaiizor.Controls.PoisonDataGridView resourceDataGridView;
        private Panel filteringpanel;
        private ReaLTaiizor.Controls.ForeverComboBox resourceTypeComboBox;
        private ReaLTaiizor.Controls.HeaderLabel resourceTypeLabel;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.ForeverComboBox locationComboBox;
    }
}