namespace SOHATS
{
    partial class HastaIslemleriF
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
            txtDosyaNo = new TextBox();
            btnBul = new Button();
            label2 = new Label();
            dtpSevkTarihi = new DateTimePicker();
            label3 = new Label();
            cmbOncekiIslemler = new ComboBox();
            btnGit = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHastaAd = new TextBox();
            txtSoyad = new TextBox();
            txtKurumAdi = new TextBox();
            label7 = new Label();
            btnHastaBilgileri = new Button();
            label8 = new Label();
            cmbPoliklinik = new ComboBox();
            label9 = new Label();
            txtSiraNo = new TextBox();
            label10 = new Label();
            cmbIslem = new ComboBox();
            cmbDoktor = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            numMiktar = new NumericUpDown();
            label13 = new Label();
            txtBirimFiyat = new TextBox();
            btnEkle = new Button();
            dgvIslemler = new DataGridView();
            lblToplamTutar = new Label();
            btnYeni = new Button();
            btnSecSil = new Button();
            btnTaburcu = new Button();
            btnYazdir = new Button();
            btnOnizleme = new Button();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)numMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Dosya No";
            // 
            // txtDosyaNo
            // 
            txtDosyaNo.Location = new Point(172, 21);
            txtDosyaNo.Name = "txtDosyaNo";
            txtDosyaNo.Size = new Size(182, 31);
            txtDosyaNo.TabIndex = 1;
            // 
            // btnBul
            // 
            btnBul.BackColor = SystemColors.GradientActiveCaption;
            btnBul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBul.Location = new Point(360, 18);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(112, 34);
            btnBul.TabIndex = 2;
            btnBul.Text = "bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 70);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "Sevk Tarihi";
            // 
            // dtpSevkTarihi
            // 
            dtpSevkTarihi.Location = new Point(172, 67);
            dtpSevkTarihi.Name = "dtpSevkTarihi";
            dtpSevkTarihi.Size = new Size(300, 31);
            dtpSevkTarihi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Önceki İşlemler";
            // 
            // cmbOncekiIslemler
            // 
            cmbOncekiIslemler.FormattingEnabled = true;
            cmbOncekiIslemler.Location = new Point(172, 117);
            cmbOncekiIslemler.Name = "cmbOncekiIslemler";
            cmbOncekiIslemler.Size = new Size(182, 33);
            cmbOncekiIslemler.TabIndex = 6;
            // 
            // btnGit
            // 
            btnGit.BackColor = SystemColors.GradientActiveCaption;
            btnGit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGit.Location = new Point(360, 116);
            btnGit.Name = "btnGit";
            btnGit.Size = new Size(112, 34);
            btnGit.TabIndex = 7;
            btnGit.Text = "git";
            btnGit.UseVisualStyleBackColor = false;
            btnGit.Click += btnGit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 16);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 8;
            label4.Text = "Hasta Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 70);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Soyadı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 120);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 10;
            label6.Text = "Kurum Adı";
            // 
            // txtHastaAd
            // 
            txtHastaAd.Location = new Point(662, 13);
            txtHastaAd.Name = "txtHastaAd";
            txtHastaAd.Size = new Size(150, 31);
            txtHastaAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(662, 67);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 31);
            txtSoyad.TabIndex = 12;
            // 
            // txtKurumAdi
            // 
            txtKurumAdi.Location = new Point(662, 120);
            txtKurumAdi.Name = "txtKurumAdi";
            txtKurumAdi.Size = new Size(150, 31);
            txtKurumAdi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(855, 24);
            label7.Name = "label7";
            label7.Size = new Size(287, 25);
            label7.TabIndex = 14;
            label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // btnHastaBilgileri
            // 
            btnHastaBilgileri.BackColor = SystemColors.GradientActiveCaption;
            btnHastaBilgileri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHastaBilgileri.Location = new Point(855, 67);
            btnHastaBilgileri.Name = "btnHastaBilgileri";
            btnHastaBilgileri.Size = new Size(287, 84);
            btnHastaBilgileri.TabIndex = 15;
            btnHastaBilgileri.Text = "Hasta Bilgileri";
            btnHastaBilgileri.UseVisualStyleBackColor = false;
            btnHastaBilgileri.Click += btnHastaBilgileri_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 170);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 16;
            label8.Text = "Poliklinik";
            // 
            // cmbPoliklinik
            // 
            cmbPoliklinik.FormattingEnabled = true;
            cmbPoliklinik.Location = new Point(22, 198);
            cmbPoliklinik.Name = "cmbPoliklinik";
            cmbPoliklinik.Size = new Size(143, 33);
            cmbPoliklinik.TabIndex = 17;
            cmbPoliklinik.SelectedIndexChanged += cmbPoliklinik_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 170);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 18;
            label9.Text = "Sıra No";
            // 
            // txtSiraNo
            // 
            txtSiraNo.Location = new Point(171, 198);
            txtSiraNo.Name = "txtSiraNo";
            txtSiraNo.Size = new Size(150, 31);
            txtSiraNo.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(360, 170);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 20;
            label10.Text = "Yapılan İşlem";
            // 
            // cmbIslem
            // 
            cmbIslem.FormattingEnabled = true;
            cmbIslem.Location = new Point(327, 196);
            cmbIslem.Name = "cmbIslem";
            cmbIslem.Size = new Size(182, 33);
            cmbIslem.TabIndex = 21;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(515, 195);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(157, 33);
            cmbDoktor.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(556, 167);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 23;
            label11.Text = "Dr. Kodu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(703, 170);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 24;
            label12.Text = "Miktar";
            // 
            // numMiktar
            // 
            numMiktar.Location = new Point(678, 195);
            numMiktar.Name = "numMiktar";
            numMiktar.Size = new Size(180, 31);
            numMiktar.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(888, 170);
            label13.Name = "label13";
            label13.Size = new Size(94, 25);
            label13.TabIndex = 26;
            label13.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(864, 194);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(150, 31);
            txtBirimFiyat.TabIndex = 27;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientInactiveCaption;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(1037, 170);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 55);
            btnEkle.TabIndex = 28;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvIslemler
            // 
            dgvIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslemler.Location = new Point(-8, 237);
            dgvIslemler.Name = "dgvIslemler";
            dgvIslemler.RowHeadersWidth = 62;
            dgvIslemler.Size = new Size(1230, 305);
            dgvIslemler.TabIndex = 29;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(962, 500);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(217, 28);
            lblToplamTutar.TabIndex = 30;
            lblToplamTutar.Text = "Toplam Tutar :     0TL";
            // 
            // btnYeni
            // 
            btnYeni.BackColor = SystemColors.GradientActiveCaption;
            btnYeni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeni.ForeColor = SystemColors.Control;
            btnYeni.Location = new Point(9, 580);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(112, 67);
            btnYeni.TabIndex = 31;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSecSil
            // 
            btnSecSil.BackColor = SystemColors.GradientActiveCaption;
            btnSecSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSecSil.ForeColor = Color.Red;
            btnSecSil.Location = new Point(127, 580);
            btnSecSil.Name = "btnSecSil";
            btnSecSil.Size = new Size(118, 67);
            btnSecSil.TabIndex = 32;
            btnSecSil.Text = "Seç-Sil";
            btnSecSil.UseVisualStyleBackColor = false;
            // 
            // btnTaburcu
            // 
            btnTaburcu.BackColor = SystemColors.GradientActiveCaption;
            btnTaburcu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTaburcu.Location = new Point(251, 580);
            btnTaburcu.Name = "btnTaburcu";
            btnTaburcu.Size = new Size(117, 65);
            btnTaburcu.TabIndex = 33;
            btnTaburcu.Text = "Taburcu";
            btnTaburcu.UseVisualStyleBackColor = false;
            btnTaburcu.Click += btnTaburcu_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = SystemColors.GradientActiveCaption;
            btnYazdir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYazdir.Location = new Point(374, 580);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(123, 65);
            btnYazdir.TabIndex = 34;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnOnizleme
            // 
            btnOnizleme.BackColor = SystemColors.GradientActiveCaption;
            btnOnizleme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOnizleme.Location = new Point(503, 581);
            btnOnizleme.Name = "btnOnizleme";
            btnOnizleme.Size = new Size(201, 65);
            btnOnizleme.TabIndex = 35;
            btnOnizleme.Text = "Baskı Önizleme";
            btnOnizleme.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = SystemColors.GradientActiveCaption;
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.Location = new Point(1037, 592);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(142, 46);
            btnCikis.TabIndex = 36;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // HastaIslemleriF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1203, 650);
            Controls.Add(btnCikis);
            Controls.Add(btnOnizleme);
            Controls.Add(btnYazdir);
            Controls.Add(btnTaburcu);
            Controls.Add(btnSecSil);
            Controls.Add(btnYeni);
            Controls.Add(lblToplamTutar);
            Controls.Add(dgvIslemler);
            Controls.Add(btnEkle);
            Controls.Add(txtBirimFiyat);
            Controls.Add(label13);
            Controls.Add(numMiktar);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbIslem);
            Controls.Add(label10);
            Controls.Add(txtSiraNo);
            Controls.Add(label9);
            Controls.Add(cmbPoliklinik);
            Controls.Add(label8);
            Controls.Add(btnHastaBilgileri);
            Controls.Add(label7);
            Controls.Add(txtKurumAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtHastaAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnGit);
            Controls.Add(cmbOncekiIslemler);
            Controls.Add(label3);
            Controls.Add(dtpSevkTarihi);
            Controls.Add(label2);
            Controls.Add(btnBul);
            Controls.Add(txtDosyaNo);
            Controls.Add(label1);
            Name = "HastaIslemleriF";
            Text = "HastaIslemleriF";
            Load += HastaIslemleriF_Load;
            ((System.ComponentModel.ISupportInitialize)numMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDosyaNo;
        private Button btnBul;
        private Label label2;
        private DateTimePicker dtpSevkTarihi;
        private Label label3;
        private ComboBox cmbOncekiIslemler;
        private Button btnGit;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHastaAd;
        private TextBox txtSoyad;
        private TextBox txtKurumAdi;
        private Label label7;
        private Button btnHastaBilgileri;
        private Label label8;
        private ComboBox cmbPoliklinik;
        private Label label9;
        private TextBox txtSiraNo;
        private Label label10;
        private ComboBox cmbIslem;
        private ComboBox cmbDoktor;
        private Label label11;
        private Label label12;
        private NumericUpDown numMiktar;
        private Label label13;
        private TextBox txtBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvIslemler;
        private Label lblToplamTutar;
        private Button btnYeni;
        private Button btnSecSil;
        private Button btnTaburcu;
        private Button btnYazdir;
        private Button btnOnizleme;
        private Button btnCikis;
    }
}