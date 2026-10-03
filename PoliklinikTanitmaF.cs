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
    public partial class PoliklinikTanitmaF : Form
    {
        
        bool kayitVarMi = false;
        int guncellenecekID = 0;
        public PoliklinikTanitmaF()
        {
            InitializeComponent();
        }
        private void txtPoliklinikAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string aranan = txtPoliklinikAdi.Text.Trim();
                if (string.IsNullOrEmpty(aranan)) return;

                SqlConnection baglanti = SQLBaglantisi.Baglan();
                SqlCommand komut = new SqlCommand("SELECT * FROM Poliklinik WHERE PoliklinikAdi=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", aranan);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    kayitVarMi = true;
                    guncellenecekID = Convert.ToInt32(dr["PoliklinikID"]);
                    chbGecerlilik.Checked = (dr["Durum"].ToString() == "true");
                    btnKaydet.Text = "Güncelle";
                    btnSil.Enabled = true;
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("Böyle bir poliklinik bulunamadı. Yeni kayıt açmak ister misiniz?", "Kayıt Yok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        kayitVarMi = false;
                        guncellenecekID = 0;
                        btnKaydet.Text = "Ekle";
                        btnSil.Enabled = false;
                        chbGecerlilik.Focus();
                    }
                    else
                    {
                        txtPoliklinikAdi.Text = "";
                    }
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SQLBaglantisi.Baglan();

            if (kayitVarMi)
            {
                string sql = "UPDATE Poliklinik SET PoliklinikAdi=@p1, Durum=@p2 WHERE PoliklinikID=@p3";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtPoliklinikAdi.Text);
                komut.Parameters.AddWithValue("@p2", chbGecerlilik.Checked ? "true" : "false");
                komut.Parameters.AddWithValue("@p3", guncellenecekID);
                komut.ExecuteNonQuery();
                MessageBox.Show("Poliklinik güncellendi.");
            }
            else
            {
                string sql = "INSERT INTO Poliklinik (PoliklinikAdi, Durum) VALUES (@p1, @p2)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtPoliklinikAdi.Text);
                komut.Parameters.AddWithValue("@p2", chbGecerlilik.Checked ? "true" : "false");
                komut.ExecuteNonQuery();
                MessageBox.Show("Poliklinik eklendi.");
                kayitVarMi = true;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kayitVarMi)
            {
                DialogResult cevap = MessageBox.Show("Bu polikliniği silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection baglanti = SQLBaglantisi.Baglan();
                        SqlCommand komut = new SqlCommand("DELETE FROM Poliklinik WHERE PoliklinikID=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", guncellenecekID);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Silindi.");
                        txtPoliklinikAdi.Text = "";
                        chbGecerlilik.Checked = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bu polikliniği silemezsiniz çünkü doktor veya hasta kaydı var.");
                    }
                }
            }
        }

        private void PoliklinikTanitmaF_Load(object sender, EventArgs e)
        {

        }
    }
}
