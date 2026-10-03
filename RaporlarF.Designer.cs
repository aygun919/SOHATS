namespace SOHATS
{
    partial class RaporlarF
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
            label1 = new Label();
            label2 = new Label();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            btnSorgula = new Button();
            btnTemizle = new Button();
            btnYazdir = new Button();
            btnCikis = new Button();
            rbTaburcuOlmus = new RadioButton();
            rbTaburcuOlmamis = new RadioButton();
            rbHepsi = new RadioButton();
            dgvRapor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Bitiş Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(149, 28);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(174, 31);
            dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(149, 80);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(174, 31);
            dtpBitis.TabIndex = 3;
            // 
            // btnSorgula
            // 
            btnSorgula.BackColor = SystemColors.GradientInactiveCaption;
            btnSorgula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSorgula.Location = new Point(635, 17);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(112, 102);
            btnSorgula.TabIndex = 4;
            btnSorgula.Text = "SORGULA";
            btnSorgula.UseVisualStyleBackColor = false;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.GradientInactiveCaption;
            btnTemizle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTemizle.Location = new Point(770, 17);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(112, 102);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = SystemColors.GradientInactiveCaption;
            btnYazdir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYazdir.Location = new Point(899, 17);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(112, 101);
            btnYazdir.TabIndex = 6;
            btnYazdir.Text = "YAZDIR";
            btnYazdir.UseVisualStyleBackColor = false;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = SystemColors.GradientInactiveCaption;
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.Location = new Point(1144, 17);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(112, 101);
            btnCikis.TabIndex = 7;
            btnCikis.Text = "ÇIKIŞ";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // rbTaburcuOlmus
            // 
            rbTaburcuOlmus.AutoSize = true;
            rbTaburcuOlmus.Location = new Point(416, 12);
            rbTaburcuOlmus.Name = "rbTaburcuOlmus";
            rbTaburcuOlmus.Size = new Size(155, 29);
            rbTaburcuOlmus.TabIndex = 8;
            rbTaburcuOlmus.TabStop = true;
            rbTaburcuOlmus.Text = "Taburcu Olmuş";
            rbTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmamis
            // 
            rbTaburcuOlmamis.AutoSize = true;
            rbTaburcuOlmamis.Location = new Point(416, 53);
            rbTaburcuOlmamis.Name = "rbTaburcuOlmamis";
            rbTaburcuOlmamis.Size = new Size(174, 29);
            rbTaburcuOlmamis.TabIndex = 9;
            rbTaburcuOlmamis.TabStop = true;
            rbTaburcuOlmamis.Text = "Taburcu Olmamış";
            rbTaburcuOlmamis.UseVisualStyleBackColor = true;
            // 
            // rbHepsi
            // 
            rbHepsi.AutoSize = true;
            rbHepsi.Location = new Point(416, 90);
            rbHepsi.Name = "rbHepsi";
            rbHepsi.Size = new Size(82, 29);
            rbHepsi.TabIndex = 10;
            rbHepsi.TabStop = true;
            rbHepsi.Text = "Hepsi";
            rbHepsi.UseVisualStyleBackColor = true;
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(3, 141);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 62;
            dgvRapor.Size = new Size(1281, 470);
            dgvRapor.TabIndex = 11;
            // 
            // RaporlarF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 533);
            Controls.Add(dgvRapor);
            Controls.Add(rbHepsi);
            Controls.Add(rbTaburcuOlmamis);
            Controls.Add(rbTaburcuOlmus);
            Controls.Add(btnCikis);
            Controls.Add(btnYazdir);
            Controls.Add(btnTemizle);
            Controls.Add(btnSorgula);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RaporlarF";
            Text = "RaporlarF";
            Load += RaporlarF_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private Button btnSorgula;
        private Button btnTemizle;
        private Button btnYazdir;
        private Button btnCikis;
        private RadioButton rbTaburcuOlmus;
        private RadioButton rbTaburcuOlmamis;
        private RadioButton rbHepsi;
        private DataGridView dgvRapor;
    }
}