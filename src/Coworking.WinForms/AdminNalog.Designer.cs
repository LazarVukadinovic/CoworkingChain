namespace Coworking.WinForms
{
    partial class AdminNalog
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
            headerPanel = new Panel();
            headerLabel = new ReaLTaiizor.Controls.HeaderLabel();
            userLabel = new ReaLTaiizor.Controls.HeaderLabel();
            usernameLabel = new ReaLTaiizor.Controls.HeaderLabel();
            passLabel = new ReaLTaiizor.Controls.HeaderLabel();
            passwordLabel = new ReaLTaiizor.Controls.HeaderLabel();
            addAdminButton = new ReaLTaiizor.Controls.ForeverButton();
            editUsernameButton = new ReaLTaiizor.Controls.ForeverButton();
            editPasswordButton = new ReaLTaiizor.Controls.ForeverButton();
            headerPanel.SuspendLayout();
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
            headerPanel.TabIndex = 1;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.Transparent;
            headerLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel.Location = new Point(363, 11);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(392, 42);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Nalog administratora:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            userLabel.ForeColor = Color.FromArgb(255, 255, 255);
            userLabel.Location = new Point(12, 111);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(193, 29);
            userLabel.TabIndex = 17;
            userLabel.Text = "Korisničko ime:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.FromArgb(255, 255, 255);
            usernameLabel.Location = new Point(211, 105);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 36);
            usernameLabel.TabIndex = 18;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            passLabel.ForeColor = Color.FromArgb(255, 255, 255);
            passLabel.Location = new Point(12, 178);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(109, 29);
            passLabel.TabIndex = 19;
            passLabel.Text = "Lozinka:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(255, 255, 255);
            passwordLabel.Location = new Point(127, 172);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(184, 36);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "*************";
            // 
            // addAdminButton
            // 
            addAdminButton.BackColor = Color.Transparent;
            addAdminButton.BaseColor = Color.FromArgb(35, 168, 109);
            addAdminButton.Cursor = Cursors.Hand;
            addAdminButton.Font = new Font("Segoe UI", 12F);
            addAdminButton.Location = new Point(12, 305);
            addAdminButton.Name = "addAdminButton";
            addAdminButton.Rounded = true;
            addAdminButton.Size = new Size(225, 45);
            addAdminButton.TabIndex = 21;
            addAdminButton.Text = "Dodaj administratora";
            addAdminButton.TextColor = Color.FromArgb(243, 243, 243);
            addAdminButton.Click += addAdminButton_Click;
            // 
            // editUsernameButton
            // 
            editUsernameButton.BackColor = Color.Transparent;
            editUsernameButton.BaseColor = Color.FromArgb(56, 95, 235);
            editUsernameButton.Font = new Font("Segoe UI", 12F);
            editUsernameButton.Location = new Point(12, 235);
            editUsernameButton.Name = "editUsernameButton";
            editUsernameButton.Rounded = true;
            editUsernameButton.Size = new Size(225, 45);
            editUsernameButton.TabIndex = 22;
            editUsernameButton.Text = "Izmeni korisničko ime";
            editUsernameButton.TextColor = Color.FromArgb(243, 243, 243);
            editUsernameButton.Click += editUsernameButton_Click;
            // 
            // editPasswordButton
            // 
            editPasswordButton.BackColor = Color.Transparent;
            editPasswordButton.BaseColor = Color.Red;
            editPasswordButton.Cursor = Cursors.Hand;
            editPasswordButton.Font = new Font("Segoe UI", 12F);
            editPasswordButton.Location = new Point(255, 235);
            editPasswordButton.Name = "editPasswordButton";
            editPasswordButton.Rounded = true;
            editPasswordButton.Size = new Size(165, 45);
            editPasswordButton.TabIndex = 23;
            editPasswordButton.Text = "Izmeni lozinku";
            editPasswordButton.TextColor = Color.FromArgb(243, 243, 243);
            editPasswordButton.Click += editPasswordButton_Click;
            // 
            // AdminNalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 52, 68);
            ClientSize = new Size(1102, 590);
            Controls.Add(editPasswordButton);
            Controls.Add(editUsernameButton);
            Controls.Add(addAdminButton);
            Controls.Add(passwordLabel);
            Controls.Add(passLabel);
            Controls.Add(usernameLabel);
            Controls.Add(userLabel);
            Controls.Add(headerPanel);
            Name = "AdminNalog";
            Text = "AdminNalog";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel;
        private ReaLTaiizor.Controls.HeaderLabel userLabel;
        private ReaLTaiizor.Controls.HeaderLabel usernameLabel;
        private ReaLTaiizor.Controls.HeaderLabel passLabel;
        private ReaLTaiizor.Controls.HeaderLabel passwordLabel;
        private ReaLTaiizor.Controls.ForeverButton addAdminButton;
        private ReaLTaiizor.Controls.ForeverButton editUsernameButton;
        private ReaLTaiizor.Controls.ForeverButton editPasswordButton;
    }
}