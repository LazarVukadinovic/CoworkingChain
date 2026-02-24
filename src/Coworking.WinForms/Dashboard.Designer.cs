namespace Coworking.WinForms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            nalogButton = new Button();
            izlazButton = new Button();
            rezervacijeButton = new Button();
            resursButton = new Button();
            tipoviClanstvaButton = new Button();
            lokacijeButton = new Button();
            korisniciButton = new Button();
            panel3 = new Panel();
            pbLogo = new PictureBox();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 52, 68);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nalogButton);
            panel1.Controls.Add(izlazButton);
            panel1.Controls.Add(rezervacijeButton);
            panel1.Controls.Add(resursButton);
            panel1.Controls.Add(tipoviClanstvaButton);
            panel1.Controls.Add(lokacijeButton);
            panel1.Controls.Add(korisniciButton);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 953);
            panel1.TabIndex = 0;
            // 
            // nalogButton
            // 
            nalogButton.BackColor = Color.Transparent;
            nalogButton.Cursor = Cursors.Hand;
            nalogButton.Dock = DockStyle.Bottom;
            nalogButton.FlatAppearance.BorderSize = 0;
            nalogButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            nalogButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            nalogButton.FlatStyle = FlatStyle.Flat;
            nalogButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            nalogButton.ForeColor = Color.White;
            nalogButton.Location = new Point(0, 801);
            nalogButton.Name = "nalogButton";
            nalogButton.Size = new Size(317, 75);
            nalogButton.TabIndex = 9;
            nalogButton.Text = "Nalog";
            nalogButton.UseVisualStyleBackColor = false;
            // 
            // izlazButton
            // 
            izlazButton.BackColor = Color.Transparent;
            izlazButton.Cursor = Cursors.Hand;
            izlazButton.Dock = DockStyle.Bottom;
            izlazButton.FlatAppearance.BorderSize = 0;
            izlazButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            izlazButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            izlazButton.FlatStyle = FlatStyle.Flat;
            izlazButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            izlazButton.ForeColor = Color.White;
            izlazButton.Location = new Point(0, 876);
            izlazButton.Name = "izlazButton";
            izlazButton.Size = new Size(317, 75);
            izlazButton.TabIndex = 6;
            izlazButton.Text = "Izlaz";
            izlazButton.UseVisualStyleBackColor = false;
            izlazButton.Click += izlazButton_Click;
            // 
            // rezervacijeButton
            // 
            rezervacijeButton.BackColor = Color.Transparent;
            rezervacijeButton.Cursor = Cursors.Hand;
            rezervacijeButton.Dock = DockStyle.Top;
            rezervacijeButton.FlatAppearance.BorderSize = 0;
            rezervacijeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            rezervacijeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            rezervacijeButton.FlatStyle = FlatStyle.Flat;
            rezervacijeButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            rezervacijeButton.ForeColor = Color.White;
            rezervacijeButton.Location = new Point(0, 489);
            rezervacijeButton.Name = "rezervacijeButton";
            rezervacijeButton.Size = new Size(317, 90);
            rezervacijeButton.TabIndex = 5;
            rezervacijeButton.Text = "Rezervacije";
            rezervacijeButton.UseVisualStyleBackColor = false;
            // 
            // resursButton
            // 
            resursButton.BackColor = Color.Transparent;
            resursButton.Cursor = Cursors.Hand;
            resursButton.Dock = DockStyle.Top;
            resursButton.FlatAppearance.BorderSize = 0;
            resursButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            resursButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            resursButton.FlatStyle = FlatStyle.Flat;
            resursButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            resursButton.ForeColor = Color.White;
            resursButton.Location = new Point(0, 399);
            resursButton.Name = "resursButton";
            resursButton.Size = new Size(317, 90);
            resursButton.TabIndex = 4;
            resursButton.Text = "Resurs";
            resursButton.UseVisualStyleBackColor = false;
            // 
            // tipoviClanstvaButton
            // 
            tipoviClanstvaButton.BackColor = Color.Transparent;
            tipoviClanstvaButton.Cursor = Cursors.Hand;
            tipoviClanstvaButton.Dock = DockStyle.Top;
            tipoviClanstvaButton.FlatAppearance.BorderSize = 0;
            tipoviClanstvaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            tipoviClanstvaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            tipoviClanstvaButton.FlatStyle = FlatStyle.Flat;
            tipoviClanstvaButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            tipoviClanstvaButton.ForeColor = Color.White;
            tipoviClanstvaButton.Location = new Point(0, 309);
            tipoviClanstvaButton.Name = "tipoviClanstvaButton";
            tipoviClanstvaButton.Size = new Size(317, 90);
            tipoviClanstvaButton.TabIndex = 3;
            tipoviClanstvaButton.Text = "Tipovi članstva";
            tipoviClanstvaButton.UseVisualStyleBackColor = false;
            // 
            // lokacijeButton
            // 
            lokacijeButton.BackColor = Color.Transparent;
            lokacijeButton.Cursor = Cursors.Hand;
            lokacijeButton.Dock = DockStyle.Top;
            lokacijeButton.FlatAppearance.BorderSize = 0;
            lokacijeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            lokacijeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            lokacijeButton.FlatStyle = FlatStyle.Flat;
            lokacijeButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lokacijeButton.ForeColor = Color.White;
            lokacijeButton.Location = new Point(0, 219);
            lokacijeButton.Name = "lokacijeButton";
            lokacijeButton.Size = new Size(317, 90);
            lokacijeButton.TabIndex = 2;
            lokacijeButton.Text = "Lokacije";
            lokacijeButton.UseVisualStyleBackColor = false;
            lokacijeButton.Click += lokacijeButton_Click;
            // 
            // korisniciButton
            // 
            korisniciButton.BackColor = Color.Transparent;
            korisniciButton.Cursor = Cursors.Hand;
            korisniciButton.Dock = DockStyle.Top;
            korisniciButton.FlatAppearance.BorderSize = 0;
            korisniciButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 18, 23);
            korisniciButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 26, 33);
            korisniciButton.FlatStyle = FlatStyle.Flat;
            korisniciButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            korisniciButton.ForeColor = Color.White;
            korisniciButton.Location = new Point(0, 129);
            korisniciButton.Name = "korisniciButton";
            korisniciButton.Size = new Size(317, 90);
            korisniciButton.TabIndex = 1;
            korisniciButton.Text = "Članovi";
            korisniciButton.UseVisualStyleBackColor = false;
            korisniciButton.Click += korisniciButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbLogo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 129);
            panel3.TabIndex = 8;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.InitialImage = Properties.Resources.logo;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(317, 126);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(37, 52, 68);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(319, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1063, 953);
            mainPanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 953);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1400, 900);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button korisniciButton;
        private Button rezervacijeButton;
        private Button resursButton;
        private Button tipoviClanstvaButton;
        private Button lokacijeButton;
        private Button izlazButton;
        private Panel mainPanel;
        private PictureBox pbLogo;
        private Panel panel3;
        private Button nalogButton;
    }
}