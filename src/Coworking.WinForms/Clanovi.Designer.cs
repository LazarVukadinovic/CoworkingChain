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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            filterPanel = new Panel();
            editMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            searchTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            searchButton = new ReaLTaiizor.Controls.ForeverButton();
            deleteMemberButton2 = new ReaLTaiizor.Controls.ForeverButton();
            addMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            memberDataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).BeginInit();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            memberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            memberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            memberDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            memberDataGridView.Dock = DockStyle.Fill;
            memberDataGridView.EnableHeadersVisualStyles = false;
            memberDataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            memberDataGridView.GridColor = Color.FromArgb(255, 255, 255);
            memberDataGridView.Location = new Point(0, 141);
            memberDataGridView.Name = "memberDataGridView";
            memberDataGridView.ReadOnly = true;
            memberDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            memberDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            memberDataGridView.RowHeadersWidth = 51;
            memberDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            memberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberDataGridView.Size = new Size(1102, 449);
            memberDataGridView.TabIndex = 2;
            // 
            // Clanovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 590);
            Controls.Add(memberDataGridView);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Name = "Clanovi";
            Text = "Clanovi";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).EndInit();
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
    }
}