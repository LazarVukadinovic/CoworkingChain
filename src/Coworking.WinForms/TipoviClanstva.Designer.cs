namespace Coworking.WinForms
{
    partial class TipoviClanstva
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
            editMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            addMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            membershipDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)membershipDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(419, 12);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(281, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Tipovi članstva";
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
            headerPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(searchButton);
            filterPanel.Controls.Add(editMembershipButton);
            filterPanel.Controls.Add(deleteMembershipButton);
            filterPanel.Controls.Add(addMembershipButton);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1102, 72);
            filterPanel.TabIndex = 3;
            // 
            // editMembershipButton
            // 
            editMembershipButton.BackColor = Color.Transparent;
            editMembershipButton.BaseColor = Color.FromArgb(56, 95, 235);
            editMembershipButton.Font = new Font("Segoe UI", 12F);
            editMembershipButton.Location = new Point(180, 12);
            editMembershipButton.Name = "editMembershipButton";
            editMembershipButton.Rounded = true;
            editMembershipButton.Size = new Size(183, 45);
            editMembershipButton.TabIndex = 7;
            editMembershipButton.Text = "Izmena podataka";
            editMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // deleteMembershipButton
            // 
            deleteMembershipButton.BackColor = Color.Transparent;
            deleteMembershipButton.BaseColor = Color.Red;
            deleteMembershipButton.Cursor = Cursors.Hand;
            deleteMembershipButton.Font = new Font("Segoe UI", 12F);
            deleteMembershipButton.Location = new Point(381, 12);
            deleteMembershipButton.Name = "deleteMembershipButton";
            deleteMembershipButton.Rounded = true;
            deleteMembershipButton.Size = new Size(150, 45);
            deleteMembershipButton.TabIndex = 3;
            deleteMembershipButton.Text = "Obriši tip";
            deleteMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // addMembershipButton
            // 
            addMembershipButton.BackColor = Color.Transparent;
            addMembershipButton.BaseColor = Color.FromArgb(35, 168, 109);
            addMembershipButton.Cursor = Cursors.Hand;
            addMembershipButton.Font = new Font("Segoe UI", 12F);
            addMembershipButton.Location = new Point(11, 12);
            addMembershipButton.Name = "addMembershipButton";
            addMembershipButton.Rounded = true;
            addMembershipButton.Size = new Size(150, 45);
            addMembershipButton.TabIndex = 2;
            addMembershipButton.Text = "Dodaj tip";
            addMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
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
            // membershipDataGridView
            // 
            membershipDataGridView.AllowUserToAddRows = false;
            membershipDataGridView.AllowUserToDeleteRows = false;
            membershipDataGridView.AllowUserToResizeRows = false;
            membershipDataGridView.BackgroundColor = Color.FromArgb(37, 52, 68);
            membershipDataGridView.BorderStyle = BorderStyle.None;
            membershipDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            membershipDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            membershipDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            membershipDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            membershipDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            membershipDataGridView.Dock = DockStyle.Fill;
            membershipDataGridView.EnableHeadersVisualStyles = false;
            membershipDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            membershipDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            membershipDataGridView.Location = new Point(0, 141);
            membershipDataGridView.Name = "membershipDataGridView";
            membershipDataGridView.ReadOnly = true;
            membershipDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            membershipDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            membershipDataGridView.RowHeadersWidth = 51;
            membershipDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            membershipDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membershipDataGridView.Size = new Size(1102, 463);
            membershipDataGridView.TabIndex = 4;
            // 
            // TipoviClanstva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 604);
            Controls.Add(membershipDataGridView);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "TipoviClanstva";
            Text = "TipoviClanstva";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)membershipDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel headerPanel;
        private Panel filterPanel;
        private ReaLTaiizor.Controls.CyberTextBox searchTextBox;
        private ReaLTaiizor.Controls.ForeverButton searchButton;
        private ReaLTaiizor.Controls.ForeverButton editMembershipButton;
        private ReaLTaiizor.Controls.ForeverButton deleteMembershipButton;
        private ReaLTaiizor.Controls.ForeverButton addMembershipButton;
        private ReaLTaiizor.Controls.PoisonDataGridView membershipDataGridView;
    }
}