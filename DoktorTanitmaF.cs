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


namespace SOHATS
{
    
    public partial class DoktorTanitmaF : Form
    {
        bool kayitVarMi = false;
        public DoktorTanitmaF()
        {
            InitializeComponent();
        }
      
        private void txtDoktorKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string kod = txtDoktorKodu.Text.Trim();
                if (string.IsNullOrEmpty(kod)) return;

                SqlConnection baglanti = SQLBaglantisi.Baglan();
                SqlCommand komut = new SqlCommand("SELECT * FROM Doktor WHERE DoktorKodu=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", kod);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read()) 
                {
                    txtAd.Text = dr["Ad"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();
                    cmbPoliklinik.SelectedValue = dr["PoliklinikID"]; 

                    kayitVarMi = true;
                    btnKaydet.Text = "Güncelle";
                    btnSil.Enabled = true;
                }
                else 
                {
                    DialogResult cevap = MessageBox.Show("Doktor bulunamadı. Yeni kayıt eklemek ister misiniz?", "Kayıt Yok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        kayitVarMi = false;
                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        cmbPoliklinik.SelectedIndex = -1;
                        btnKaydet.Text = "Ekle";
                        btnSil.Enabled = false;
                        txtAd.Focus();
                    }
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen poliklinik seçiniz.");
                return;
            }

            SqlConnection baglanti = SQLBaglantisi.Baglan();
            if (kayitVarMi) 
            {
                string sql = "UPDATE Doktor SET Ad=@p1, Soyad=@p2, PoliklinikID=@p3 WHERE DoktorKodu=@p4";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbPoliklinik.SelectedValue);
                komut.Parameters.AddWithValue("@p4", txtDoktorKodu.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Doktor güncellendi.");
            }
            else 
            {
                string sql = "INSERT INTO Doktor (Ad, Soyad, PoliklinikID) VALUES (@p1, @p2, @p3)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbPoliklinik.SelectedValue);
                komut.ExecuteNonQuery();
                MessageBox.Show("Doktor eklendi.");
                kayitVarMi = true;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kayitVarMi)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection baglanti = SQLBaglantisi.Baglan();
                        SqlCommand komut = new SqlCommand("DELETE FROM Doktor WHERE DoktorKodu=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", txtDoktorKodu.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Silindi.");

                        // Temizle
                        txtDoktorKodu.Text = "";
                        txtAd.Text = "";
                        txtSoyad.Text = "";
                        cmbPoliklinik.SelectedIndex = -1;
                        kayitVarMi = false;
                        btnKaydet.Text = "Ekle";
                        btnSil.Enabled = false;
                    }
                    catch { MessageBox.Show("Bu doktor işlem yaptığı için silinemez!"); }
                }
            }
        }



        private void DoktorTanitmaF_Load(object sender, EventArgs e)
        {
            // Sadece geçerli poliklinikleri çekiyoruz
            SqlConnection baglanti = SQLBaglantisi.Baglan();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Poliklinik WHERE Durum='true'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ComboBox ayarları
            cmbPoliklinik.DisplayMember = "PoliklinikAdi"; 
            cmbPoliklinik.ValueMember = "PoliklinikID";    
            cmbPoliklinik.DataSource = dt;

            cmbPoliklinik.SelectedIndex = -1;
            btnSil.Enabled = false;


        }
    }
}
