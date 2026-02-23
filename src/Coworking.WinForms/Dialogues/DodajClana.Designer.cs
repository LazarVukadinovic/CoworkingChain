namespace Coworking.WinForms.Dialogues
{
    partial class DodajClana
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
            nameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            nameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            lastnameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            lastnameTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            emailLabel = new ReaLTaiizor.Controls.HeaderLabel();
            emailTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            phoneLabel = new ReaLTaiizor.Controls.HeaderLabel();
            phoneTextBox = new ReaLTaiizor.Controls.CyberTextBox();
            membershipLabel = new ReaLTaiizor.Controls.HeaderLabel();
            membershipComboBox = new ReaLTaiizor.Controls.ForeverComboBox();
            addMemberButton = new ReaLTaiizor.Controls.ForeverButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            nameLabel.Location = new Point(22, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(112, 25);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Ime člana:";
            // 
            // nameTextBox
            // 
            nameTextBox.Alpha = 20;
            nameTextBox.BackColor = Color.Transparent;
            nameTextBox.Background_WidthPen = 3F;
            nameTextBox.BackgroundPen = true;
            nameTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            nameTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            nameTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            nameTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            nameTextBox.Font = new Font("Arial", 12F);
            nameTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            nameTextBox.Lighting = false;
            nameTextBox.LinearGradientPen = false;
            nameTextBox.Location = new Point(187, 33);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PenWidth = 15;
            nameTextBox.RGB = false;
            nameTextBox.RightToLeft = RightToLeft.No;
            nameTextBox.Rounding = true;
            nameTextBox.RoundingInt = 60;
            nameTextBox.Size = new Size(237, 50);
            nameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            nameTextBox.TabIndex = 17;
            nameTextBox.Tag = "Cyber";
            nameTextBox.TextButton = "";
            nameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            nameTextBox.Timer_RGB = 300;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.BackColor = Color.Transparent;
            lastnameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lastnameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            lastnameLabel.Location = new Point(21, 116);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(155, 25);
            lastnameLabel.TabIndex = 20;
            lastnameLabel.Text = "Prezime člana:";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Alpha = 20;
            lastnameTextBox.BackColor = Color.Transparent;
            lastnameTextBox.Background_WidthPen = 3F;
            lastnameTextBox.BackgroundPen = true;
            lastnameTextBox.ColorBackground = Color.FromArgb(37, 52, 68);
            lastnameTextBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            lastnameTextBox.ColorLighting = Color.FromArgb(29, 200, 238);
            lastnameTextBox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            lastnameTextBox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            lastnameTextBox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            lastnameTextBox.Font = new Font("Arial", 12F);
            lastnameTextBox.ForeColor = Color.FromArgb(245, 245, 245);
            lastnameTextBox.Lighting = false;
            lastnameTextBox.LinearGradientPen = false;
            lastnameTextBox.Location = new Point(187, 106);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.PenWidth = 15;
            lastnameTextBox.RGB = false;
            lastnameTextBox.RightToLeft = RightToLeft.No;
            lastnameTextBox.Rounding = true;
            lastnameTextBox.RoundingInt = 60;
            lastnameTextBox.Size = new Size(237, 50);
            lastnameTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            lastnameTextBox.TabIndex = 19;
            lastnameTextBox.Tag = "Cyber";
            lastnameTextBox.TextButton = "";
            lastnameTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            lastnameTextBox.Timer_RGB = 300;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(255, 255, 255);
            emailLabel.Location = new Point(21, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(130, 25);
            emailLabel.TabIndex = 22;
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
            emailTextBox.Location = new Point(187, 179);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PenWidth = 15;
            emailTextBox.RGB = false;
            emailTextBox.RightToLeft = RightToLeft.No;
            emailTextBox.Rounding = true;
            emailTextBox.RoundingInt = 60;
            emailTextBox.Size = new Size(237, 50);
            emailTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            emailTextBox.TabIndex = 21;
            emailTextBox.Tag = "Cyber";
            emailTextBox.TextButton = "";
            emailTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            emailTextBox.Timer_RGB = 300;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(255, 255, 255);
            phoneLabel.Location = new Point(21, 262);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(150, 25);
            phoneLabel.TabIndex = 24;
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
            phoneTextBox.Location = new Point(187, 252);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PenWidth = 15;
            phoneTextBox.RGB = false;
            phoneTextBox.RightToLeft = RightToLeft.No;
            phoneTextBox.Rounding = true;
            phoneTextBox.RoundingInt = 60;
            phoneTextBox.Size = new Size(237, 50);
            phoneTextBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            phoneTextBox.TabIndex = 23;
            phoneTextBox.Tag = "Cyber";
            phoneTextBox.TextButton = "";
            phoneTextBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            phoneTextBox.Timer_RGB = 300;
            // 
            // membershipLabel
            // 
            membershipLabel.AutoSize = true;
            membershipLabel.BackColor = Color.Transparent;
            membershipLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            membershipLabel.ForeColor = Color.FromArgb(255, 255, 255);
            membershipLabel.Location = new Point(21, 337);
            membershipLabel.Name = "membershipLabel";
            membershipLabel.Size = new Size(136, 25);
            membershipLabel.TabIndex = 26;
            membershipLabel.Text = "Tip članstva:";
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
            membershipComboBox.Location = new Point(187, 332);
            membershipComboBox.Name = "membershipComboBox";
            membershipComboBox.Size = new Size(237, 36);
            membershipComboBox.TabIndex = 29;
            // 
            // addMemberButton
            // 
            addMemberButton.BackColor = Color.Transparent;
            addMemberButton.BaseColor = Color.FromArgb(35, 168, 109);
            addMemberButton.Cursor = Cursors.Hand;
            addMemberButton.Font = new Font("Segoe UI", 12F);
            addMemberButton.Location = new Point(158, 422);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Rounded = true;
            addMemberButton.Size = new Size(150, 45);
            addMemberButton.TabIndex = 30;
            addMemberButton.Text = "Dodaj člana";
            addMemberButton.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // DodajClana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 26, 33);
            ClientSize = new Size(448, 496);
            Controls.Add(addMemberButton);
            Controls.Add(membershipComboBox);
            Controls.Add(membershipLabel);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(lastnameLabel);
            Controls.Add(lastnameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DodajClana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj Člana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel nameLabel;
        private ReaLTaiizor.Controls.CyberTextBox nameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel lastnameLabel;
        private ReaLTaiizor.Controls.CyberTextBox lastnameTextBox;
        private ReaLTaiizor.Controls.HeaderLabel emailLabel;
        private ReaLTaiizor.Controls.CyberTextBox emailTextBox;
        private ReaLTaiizor.Controls.HeaderLabel phoneLabel;
        private ReaLTaiizor.Controls.CyberTextBox phoneTextBox;
        private ReaLTaiizor.Controls.HeaderLabel membershipLabel;
        private ReaLTaiizor.Controls.ForeverComboBox membershipComboBox;
        private ReaLTaiizor.Controls.ForeverButton addMemberButton;
    }
}