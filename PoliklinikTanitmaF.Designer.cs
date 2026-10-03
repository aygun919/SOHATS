namespace SOHATS
{
    partial class PoliklinikTanitmaF
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
            btnKaydet = new Button();
            btnSil = new Button();
            chbGecerlilik = new CheckBox();
            label1 = new Label();
            txtPoliklinikAdi = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.GradientInactiveCaption;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(69, 229);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(176, 34);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Ekle / Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.GradientInactiveCaption;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(390, 229);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // chbGecerlilik
            // 
            chbGecerlilik.AutoSize = true;
            chbGecerlilik.Location = new Point(210, 150);
            chbGecerlilik.Name = "chbGecerlilik";
            chbGecerlilik.Size = new Size(171, 29);
            chbGecerlilik.TabIndex = 3;
            chbGecerlilik.Text = "Geçerli / Geçersiz";
            chbGecerlilik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(119, 88);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 4;
            label1.Text = "Poliklinik Adı";
            // 
            // txtPoliklinikAdi
            // 
            txtPoliklinikAdi.Location = new Point(302, 85);
            txtPoliklinikAdi.Name = "txtPoliklinikAdi";
            txtPoliklinikAdi.Size = new Size(150, 31);
            txtPoliklinikAdi.TabIndex = 5;
            txtPoliklinikAdi.KeyDown += txtPoliklinikAdi_KeyDown;
            // 
            // PoliklinikTanitmaF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 338);
            Controls.Add(txtPoliklinikAdi);
            Controls.Add(label1);
            Controls.Add(chbGecerlilik);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Name = "PoliklinikTanitmaF";
            Text = "PoliklinikTanitmaF";
            Load += PoliklinikTanitmaF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Button btnSil;
        private CheckBox chbGecerlilik;
        private Label label1;
        private TextBox txtPoliklinikAdi;
    }
}