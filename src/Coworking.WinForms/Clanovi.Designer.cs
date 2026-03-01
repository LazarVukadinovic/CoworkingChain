namespace Coworking.WinForms
{
    partial class Clanovi
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
            headerPanel = new Panel();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            filterPanel = new Panel();
            editMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteMemberButton2 = new ReaLTaiizor.Controls.ForeverButton();
            addMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            memberDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            filteringpanel = new Panel();
            statusLabel = new ReaLTaiizor.Controls.HeaderLabel();
            statusComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            locationLabel = new ReaLTaiizor.Controls.HeaderLabel();
            locationComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            membershipTypeLabel = new ReaLTaiizor.Controls.HeaderLabel();
            membershipComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).BeginInit();
            filteringpanel.SuspendLayout();
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
            headerPanel.Size = new Size(1102, 69);
            headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(476, 13);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(150, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Članovi";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(editMemberButton);
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(searchButton);
            filterPanel.Controls.Add(deleteMemberButton2);
            filterPanel.Controls.Add(addMemberButton);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1102, 72);
            filterPanel.TabIndex = 1;
            // 
            // editMemberButton
            // 
            editMemberButton.BackColor = Color.Transparent;
            editMemberButton.BaseColor = Color.FromArgb(56, 95, 235);
            editMemberButton.Font = new Font("Segoe UI", 12F);
            editMemberButton.Location = new Point(180, 12);
            editMemberButton.Name = "editMemberButton";
            editMemberButton.Rounded = true;
            editMemberButton.Size = new Size(183, 45);
            editMemberButton.TabIndex = 7;
            editMemberButton.Text = "Izmena podataka";
            editMemberButton.TextColor = Color.FromArgb(243, 243, 243);
            editMemberButton.Click += editMemberButton_Click;
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
            searchTextBox.TabIndex = 6;
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
            searchButton.TabIndex = 4;
            searchButton.Text = "Pretraga";
            searchButton.TextColor = Color.FromArgb(243, 243, 243);
            searchButton.Click += searchButton_Click;
            // 
            // deleteMemberButton2
            // 
            deleteMemberButton2.BackColor = Color.Transparent;
            deleteMemberButton2.BaseColor = Color.Red;
            deleteMemberButton2.Cursor = Cursors.Hand;
            deleteMemberButton2.Font = new Font("Segoe UI", 12F);
            deleteMemberButton2.Location = new Point(381, 12);
            deleteMemberButton2.Name = "deleteMemberButton2";
            deleteMemberButton2.Rounded = true;
            deleteMemberButton2.Size = new Size(150, 45);
            deleteMemberButton2.TabIndex = 3;
            deleteMemberButton2.Text = "Obriši člana";
            deleteMemberButton2.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // addMemberButton
            // 
            addMemberButton.BackColor = Color.Transparent;
            addMemberButton.BaseColor = Color.FromArgb(35, 168, 109);
            addMemberButton.Cursor = Cursors.Hand;
            addMemberButton.Font = new Font("Segoe UI", 12F);
            addMemberButton.Location = new Point(11, 12);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Rounded = true;
            addMemberButton.Size = new Size(150, 45);
            addMemberButton.TabIndex = 2;
            addMemberButton.Text = "Dodaj člana";
            addMemberButton.TextColor = Color.FromArgb(243, 243, 243);
            addMemberButton.Click += addMemberButton_Click;
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
            memberDataGridView.Size = new Size(1102, 449);
            memberDataGridView.TabIndex = 2;
            // 
            // filteringpanel
            // 
            filteringpanel.BackColor = Color.FromArgb(37, 52, 68);
            filteringpanel.BorderStyle = BorderStyle.FixedSingle;
            filteringpanel.Controls.Add(statusLabel);
            filteringpanel.Controls.Add(statusComboBox);
            filteringpanel.Controls.Add(locationLabel);
            filteringpanel.Controls.Add(locationComboBox);
            filteringpanel.Controls.Add(membershipTypeLabel);
            filteringpanel.Controls.Add(membershipComboBox);
            filteringpanel.Dock = DockStyle.Top;
            filteringpanel.Location = new Point(0, 141);
            filteringpanel.Name = "filteringpanel";
            filteringpanel.Size = new Size(1102, 97);
            filteringpanel.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            statusLabel.ForeColor = Color.FromArgb(255, 255, 255);
            statusLabel.Location = new Point(529, 23);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(130, 20);
            statusLabel.TabIndex = 21;
            statusLabel.Text = "Status naloga:";
            // 
            // statusComboBox
            // 
            statusComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            statusComboBox.BGColor = Color.FromArgb(18, 26, 33);
            statusComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Font = new Font("Segoe UI", 8F);
            statusComboBox.ForeColor = Color.White;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            statusComboBox.HoverFontColor = Color.White;
            statusComboBox.ItemHeight = 25;
            statusComboBox.Items.AddRange(new object[] { "Svi", "Aktivan", "Neaktivan", "Suspendovan" });
            statusComboBox.Location = new Point(529, 46);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(223, 31);
            statusComboBox.TabIndex = 20;
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
            // 
            // membershipTypeLabel
            // 
            membershipTypeLabel.AutoSize = true;
            membershipTypeLabel.BackColor = Color.Transparent;
            membershipTypeLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            membershipTypeLabel.ForeColor = Color.FromArgb(255, 255, 255);
            membershipTypeLabel.Location = new Point(12, 23);
            membershipTypeLabel.Name = "membershipTypeLabel";
            membershipTypeLabel.Size = new Size(117, 20);
            membershipTypeLabel.TabIndex = 17;
            membershipTypeLabel.Text = "Tip članstva:";
            // 
            // membershipComboBox
            // 
            membershipComboBox.BaseColor = Color.FromArgb(8, 133, 161);
            membershipComboBox.BGColor = Color.FromArgb(18, 26, 33);
            membershipComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            membershipComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            membershipComboBox.Font = new Font("Segoe UI", 8F);
            membershipComboBox.ForeColor = Color.White;
            membershipComboBox.FormattingEnabled = true;
            membershipComboBox.HoverColor = Color.FromArgb(35, 168, 109);
            membershipComboBox.HoverFontColor = Color.White;
            membershipComboBox.ItemHeight = 25;
            membershipComboBox.Items.AddRange(new object[] { "Svi" });
            membershipComboBox.Location = new Point(12, 46);
            membershipComboBox.Name = "membershipComboBox";
            membershipComboBox.Size = new Size(223, 31);
            membershipComboBox.TabIndex = 0;
            // 
            // Clanovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 590);
            Controls.Add(filteringpanel);
            Controls.Add(memberDataGridView);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "Clanovi";
            Text = "Clanovi";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).EndInit();
            filteringpanel.ResumeLayout(false);
            filteringpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel filterPanel;
        private ReaLTaiizor.Controls.ForeverButton deleteMemberButton2;
        private ReaLTaiizor.Controls.ForeverButton addMemberButton;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.CyberTextBox searchTextBox;
        private ReaLTaiizor.Controls.PoisonDataGridView memberDataGridView;
        private ReaLTaiizor.Controls.ForeverButton editMemberButton;
        private Panel filteringpanel;
        private ReaLTaiizor.Controls.HeaderLabel locationLabel;
        private ReaLTaiizor.Controls.ForeverComboBox locationComboBox;
        private ReaLTaiizor.Controls.HeaderLabel membershipTypeLabel;
        private ReaLTaiizor.Controls.ForeverComboBox membershipComboBox;
        private ReaLTaiizor.Controls.HeaderLabel statusLabel;
        private ReaLTaiizor.Controls.ForeverComboBox statusComboBox;
    }
}