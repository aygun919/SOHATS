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
    public partial class HastaIslemleriF : Form
    {
        int mevcutSevkID = 0; 
        public HastaIslemleriF()
        {
            InitializeComponent();
        }

        private void HastaIslemleriF_Load(object sender, EventArgs e)
        {
           
            dtpSevkTarihi.Value = DateTime.Now;

           
            if (cmbIslem.Items.Count == 0)
            {
                cmbIslem.Items.Add("Muayene");
                cmbIslem.Items.Add("Tahlil");
                cmbIslem.Items.Add("Röntgen");
                cmbIslem.Items.Add("Müdahale");
                cmbIslem.SelectedIndex = 0;
            }

          
            SqlConnection baglanti = SQLBaglantisi.Baglan();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Poliklinik WHERE Durum='true'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbPoliklinik.DisplayMember = "PoliklinikAdi";
            cmbPoliklinik.ValueMember = "PoliklinikID";
            cmbPoliklinik.DataSource = dt;
            cmbPoliklinik.SelectedIndex = -1; 

           
            lblToplamTutar.Text = "Toplam Tutar: 0 TL";

        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedIndex != -1)
            {
                try
                {
                   
                    int pID = Convert.ToInt32(cmbPoliklinik.SelectedValue);

                    SqlConnection baglanti = SQLBaglantisi.Baglan();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doktor WHERE PoliklinikID=" + pID, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbDoktor.DisplayMember = "Ad";
                    cmbDoktor.ValueMember = "DoktorKodu";
                    cmbDoktor.DataSource = dt;
                }
                catch { }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtDosyaNo.Text == "") return;

            SqlConnection baglanti = SQLBaglantisi.Baglan();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta WHERE DosyaNo=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) // HASTA VARSA
            {
                txtHastaAd.Text = dr["Ad"].ToString();
                txtSoyad.Text = dr["Soyad"].ToString();
                txtKurumAdi.Text = dr["SosyalGuvenlikKurumu"].ToString();

                dr.Close(); 

                SqlCommand komutGecmis = new SqlCommand("SELECT SevkID, SevkTarihi FROM Sevk WHERE DosyaNo=@p1 ORDER BY SevkTarihi DESC", baglanti);
                komutGecmis.Parameters.AddWithValue("@p1", txtDosyaNo.Text);

                SqlDataAdapter da = new SqlDataAdapter(komutGecmis);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOncekiIslemler.DisplayMember = "SevkTarihi"; 
                cmbOncekiIslemler.ValueMember = "SevkID";     
                cmbOncekiIslemler.DataSource = dt;
             
                string sql = "INSERT INTO Sevk (DosyaNo, SevkTarihi, Saat, ToplamTutar, Taburcu) VALUES (@p1, @p2, @p3, 0, 'H'); SELECT SCOPE_IDENTITY();";
                SqlCommand komutSevk = new SqlCommand(sql, baglanti);
                komutSevk.Parameters.AddWithValue("@p1", txtDosyaNo.Text);
                komutSevk.Parameters.AddWithValue("@p2", dtpSevkTarihi.Value);
                komutSevk.Parameters.AddWithValue("@p3", DateTime.Now.ToShortTimeString());

                object sonuc = komutSevk.ExecuteScalar();
                mevcutSevkID = Convert.ToInt32(sonuc);

                dgvIslemler.DataSource = null;
                lblToplamTutar.Text = "Toplam Tutar: 0 TL";
            }
            else 
            {
                DialogResult cevap = MessageBox.Show("Hasta bulunamadı. Yeni kayıt oluşturmak ister misiniz?", "Kayıt Yok", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    HastaBilgileriF yeniForm = new HastaBilgileriF();
                    yeniForm.ShowDialog(); 
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (mevcutSevkID == 0)
            {
                MessageBox.Show("Lütfen önce 'Bul' butonuna basarak bir hasta seçiniz.");
                return;
            }

            SqlConnection baglanti = SQLBaglantisi.Baglan();
            string sql = "INSERT INTO YapilanIslem (SevkID, IslemAdi, DrKodu, Miktar, BirimFiyat) VALUES (@p1, @p2, @p3, @p4, @p5)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@p1", mevcutSevkID);
            komut.Parameters.AddWithValue("@p2", cmbIslem.Text);
            komut.Parameters.AddWithValue("@p3", cmbDoktor.SelectedValue ?? 0);
            komut.Parameters.AddWithValue("@p4", numMiktar.Value);
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtBirimFiyat.Text));

            komut.ExecuteNonQuery();

            GridDoldurVeHesapla();

        }
        void GridDoldurVeHesapla()
        {
            SqlConnection baglanti = SQLBaglantisi.Baglan();

            // 1. Listeyi Getir
            string sql = "SELECT IslemAdi as [İşlem], Miktar, BirimFiyat, (Miktar*BirimFiyat) as [Tutar] FROM YapilanIslem WHERE SevkID=@p1";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p1", mevcutSevkID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIslemler.DataSource = dt;

            decimal toplam = 0;
            for (int i = 0; i < dgvIslemler.Rows.Count; i++)
            {
                try { toplam += Convert.ToDecimal(dgvIslemler.Rows[i].Cells["Tutar"].Value); } catch { }
            }
            lblToplamTutar.Text = "Toplam Tutar: " + toplam.ToString("C2");

            SqlCommand komut = new SqlCommand("UPDATE Sevk SET ToplamTutar=@p1 WHERE SevkID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", toplam);
            komut.Parameters.AddWithValue("@p2", mevcutSevkID);
            komut.ExecuteNonQuery();
        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileriF form = new HastaBilgileriF();
            if (txtDosyaNo.Text != "")
                form.GelenDosyaNo = Convert.ToInt32(txtDosyaNo.Text);
            form.ShowDialog();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            mevcutSevkID = 0;
            txtDosyaNo.Text = "";
            txtHastaAd.Text = ""; txtSoyad.Text = ""; txtKurumAdi.Text = "";
            dgvIslemler.DataSource = null;
            lblToplamTutar.Text = "Toplam Tutar: 0 TL";
            txtDosyaNo.Focus();
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (mevcutSevkID > 0)
            {
                SqlConnection baglanti = SQLBaglantisi.Baglan();
                SqlCommand komut = new SqlCommand("UPDATE Sevk SET Taburcu='E' WHERE SevkID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", mevcutSevkID);
                komut.ExecuteNonQuery();
                MessageBox.Show("Hasta taburcu edildi.");

                btnYeni.PerformClick();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            if (cmbOncekiIslemler.SelectedIndex != -1)
            {
              
                mevcutSevkID = Convert.ToInt32(cmbOncekiIslemler.SelectedValue);
               
                GridDoldurVeHesapla(); 

                MessageBox.Show("Seçilen geçmiş tarihli kayıt ekrana yüklendi.\nDikkat: Şu an geçmiş bir kaydı görüntülüyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
