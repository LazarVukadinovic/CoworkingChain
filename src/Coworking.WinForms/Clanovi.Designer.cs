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
            filterPaanel = new Panel();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            foreverButton3 = new ReaLTaiizor.Controls.ForeverButton();
            deleteMemberButton2 = new ReaLTaiizor.Controls.ForeverButton();
            addMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            editMembershipButton = new ReaLTaiizor.Controls.ForeverButton();
            headerPanel.SuspendLayout();
            filterPaanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
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
            // filterPaanel
            // 
            filterPaanel.BackColor = Color.FromArgb(37, 52, 68);
            filterPaanel.BorderStyle = BorderStyle.FixedSingle;
            filterPaanel.Controls.Add(editMembershipButton);
            filterPaanel.Controls.Add(cyberTextBox1);
            filterPaanel.Controls.Add(foreverButton3);
            filterPaanel.Controls.Add(deleteMemberButton2);
            filterPaanel.Controls.Add(addMemberButton);
            filterPaanel.Dock = DockStyle.Top;
            filterPaanel.Location = new Point(0, 69);
            filterPaanel.Name = "filterPaanel";
            filterPaanel.Size = new Size(1102, 72);
            filterPaanel.TabIndex = 1;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 11F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(597, 12);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(374, 45);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 6;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // foreverButton3
            // 
            foreverButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverButton3.BackColor = Color.Transparent;
            foreverButton3.BaseColor = Color.FromArgb(8, 133, 161);
            foreverButton3.Cursor = Cursors.Hand;
            foreverButton3.Font = new Font("Segoe UI", 12F);
            foreverButton3.Location = new Point(977, 12);
            foreverButton3.Name = "foreverButton3";
            foreverButton3.Rounded = true;
            foreverButton3.Size = new Size(112, 45);
            foreverButton3.TabIndex = 4;
            foreverButton3.Text = "Pretraga";
            foreverButton3.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // deleteMemberButton2
            // 
            deleteMemberButton2.BackColor = Color.Transparent;
            deleteMemberButton2.BaseColor = Color.Red;
            deleteMemberButton2.Cursor = Cursors.Hand;
            deleteMemberButton2.Font = new Font("Segoe UI", 12F);
            deleteMemberButton2.Location = new Point(344, 12);
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
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(37, 52, 68);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            poisonDataGridView1.Dock = DockStyle.Fill;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(0, 141);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.ReadOnly = true;
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            poisonDataGridView1.RowHeadersWidth = 51;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(1102, 449);
            poisonDataGridView1.TabIndex = 2;
            // 
            // editMembershipButton
            // 
            editMembershipButton.BackColor = Color.Transparent;
            editMembershipButton.BaseColor = Color.FromArgb(56, 95, 235);
            editMembershipButton.Font = new Font("Segoe UI", 12F);
            editMembershipButton.Location = new Point(177, 12);
            editMembershipButton.Name = "editMembershipButton";
            editMembershipButton.Rounded = true;
            editMembershipButton.Size = new Size(150, 45);
            editMembershipButton.TabIndex = 7;
            editMembershipButton.Text = "Uredi članstvo";
            editMembershipButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // Clanovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 590);
            Controls.Add(poisonDataGridView1);
            Controls.Add(filterPaanel);
            Controls.Add(headerPanel);
            Name = "Clanovi";
            Text = "Clanovi";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPaanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private Panel filterPaanel;
        private ReaLTaiizor.Controls.ForeverButton deleteMemberButton2;
        private ReaLTaiizor.Controls.ForeverButton addMemberButton;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.ForeverButton editMembershipButton;
    }
}