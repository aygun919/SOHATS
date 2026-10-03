using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SOHATS
{
    public partial class KullaniciTanitmaF : Form
    {
        
        bool kayitVarMi = false;
        int kullaniciID = 0;
        public KullaniciTanitmaF()
        {
            InitializeComponent();
        }

        private void KullaniciTanitmaF_Load(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
         
            if (cmbYetki.Items.Count == 0)
            {
                cmbYetki.Items.Add("Admin");
                cmbYetki.Items.Add("Personel");
            }
            cmbYetki.SelectedIndex = 1; 

        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string aranan = txtKullaniciAdi.Text.Trim();
                if (string.IsNullOrEmpty(aranan)) return;

                SqlConnection baglanti = SQLBaglantisi.Baglan();
                // Veritabanında bu isimde kullanıcı var mı? (Ad sütununu kullanıcı adı sayıyoruz)
                SqlCommand komut = new SqlCommand("SELECT * FROM Kullanici WHERE Ad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", aranan);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read()) 
                {
                    kullaniciID = Convert.ToInt32(dr["KullaniciKodu"]);
                    txtSifre.Text = dr["Sifre"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();

                   
                    string yetki = dr["Yetki"].ToString();
                    if (cmbYetki.Items.Contains(yetki)) cmbYetki.SelectedItem = yetki;

                   
                    chbDurum.Checked = (dr["Durum"].ToString() == "true");

                    kayitVarMi = true;
                    btnKaydet.Text = "Güncelle";
                    btnSil.Enabled = true;
                }
                else 
                {
                    DialogResult cevap = MessageBox.Show("Kullanıcı bulunamadı. Yeni kayıt eklemek ister misiniz?", "Kayıt Yok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        
                        txtSifre.Text = "";
                        txtSoyad.Text = "";
                        chbDurum.Checked = false;
                        kayitVarMi = false;

                        btnKaydet.Text = "Ekle";
                        btnSil.Enabled = false;
                        txtSifre.Focus();
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            SqlConnection baglanti = SQLBaglantisi.Baglan();

            if (kayitVarMi) 
            {
                string sql = "UPDATE Kullanici SET Sifre=@p1, Soyad=@p2, Yetki=@p3, Durum=@p4 WHERE KullaniciKodu=@p5";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbYetki.Text);
                komut.Parameters.AddWithValue("@p4", chbDurum.Checked ? "true" : "false");
                komut.Parameters.AddWithValue("@p5", kullaniciID);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı güncellendi.");
            }
            else 
            {
                string sql = "INSERT INTO Kullanici (Ad, Sifre, Soyad, Yetki, Durum) VALUES (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", cmbYetki.Text);
                komut.Parameters.AddWithValue("@p5", chbDurum.Checked ? "true" : "false");
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni kullanıcı eklendi.");
                kayitVarMi = true; 
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kayitVarMi)
            {
                if (MessageBox.Show("Bu kullanıcıyı silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection baglanti = SQLBaglantisi.Baglan();
                    SqlCommand komut = new SqlCommand("DELETE FROM Kullanici WHERE KullaniciKodu=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", kullaniciID);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı silindi.");

                    // Temizle
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                    txtSoyad.Text = "";
                    kayitVarMi = false;
                    btnKaydet.Text = "Ekle";
                    btnSil.Enabled = false;
                }
            }
        }
    }
}
