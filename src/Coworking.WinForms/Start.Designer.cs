namespace Coworking.WinForms
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            comboBox_configFile = new ComboBox();
            pictureBox1 = new PictureBox();
            pokreni_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_configFile
            // 
            comboBox_configFile.Font = new Font("Century Gothic", 12F);
            comboBox_configFile.FormattingEnabled = true;
            comboBox_configFile.Location = new Point(179, 276);
            comboBox_configFile.Name = "comboBox_configFile";
            comboBox_configFile.Size = new Size(327, 31);
            comboBox_configFile.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pokreni_btn
            // 
            pokreni_btn.BackColor = Color.FromArgb(0, 71, 160);
            pokreni_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            pokreni_btn.ForeColor = Color.White;
            pokreni_btn.Location = new Point(179, 344);
            pokreni_btn.Name = "pokreni_btn";
            pokreni_btn.Size = new Size(327, 62);
            pokreni_btn.TabIndex = 2;
            pokreni_btn.Text = "Pokreni";
            pokreni_btn.UseVisualStyleBackColor = false;
            pokreni_btn.Click += pokreni_btn_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 491);
            Controls.Add(pokreni_btn);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox_configFile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dobrodošli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox_configFile;
        private PictureBox pictureBox1;
        private Button pokreni_btn;
    }
}
