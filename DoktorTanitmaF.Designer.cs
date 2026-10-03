namespace SOHATS
{
    partial class DoktorTanitmaF
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
            txtDoktorKodu = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label4 = new Label();
            cmbPoliklinik = new ComboBox();
            btnKaydet = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(101, 72);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "Doktor Kodu";
            // 
            // txtDoktorKodu
            // 
            txtDoktorKodu.Location = new Point(240, 72);
            txtDoktorKodu.Name = "txtDoktorKodu";
            txtDoktorKodu.Size = new Size(182, 31);
            txtDoktorKodu.TabIndex = 1;
            txtDoktorKodu.KeyDown += txtDoktorKodu_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(101, 138);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 2;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(101, 204);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 3;
            label3.Text = "Soyadı";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(240, 138);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 31);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(240, 201);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 31);
            txtSoyad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(101, 282);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 6;
            label4.Text = "Poliklinik";
            // 
            // cmbPoliklinik
            // 
            cmbPoliklinik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPoliklinik.FormattingEnabled = true;
            cmbPoliklinik.Location = new Point(240, 282);
            cmbPoliklinik.Name = "cmbPoliklinik";
            cmbPoliklinik.Size = new Size(182, 33);
            cmbPoliklinik.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.GradientInactiveCaption;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(66, 353);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(202, 55);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Ekle / Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.GradientInactiveCaption;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(375, 353);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(157, 55);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // DoktorTanitmaF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(cmbPoliklinik);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDoktorKodu);
            Controls.Add(label1);
            Name = "DoktorTanitmaF";
            Text = "DoktorTanitmaF";
            Load += DoktorTanitmaF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDoktorKodu;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label4;
        private ComboBox cmbPoliklinik;
        private Button btnKaydet;
        private Button btnSil;
    }
}