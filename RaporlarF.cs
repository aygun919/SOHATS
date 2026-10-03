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
    public partial class RaporlarF : Form
    {
        public RaporlarF()
        {
            InitializeComponent();
        }

        private void RaporlarF_Load(object sender, EventArgs e)
        {
           
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;

            
            rbHepsi.Checked = true;

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = SQLBaglantisi.Baglan();

       
            string sql = @"
        SELECT 
            H.DosyaNo AS [Dosya No],
            H.Ad AS [Hasta Adı],
            H.Soyad AS [Hasta Soyadı],
            S.SevkTarihi AS [Sevk Tarihi],
            P.PoliklinikAdi AS [Poliklinik],
            D.Ad AS [Doktor Adı],
            D.Soyad AS [Doktor Soyadı],
            S.ToplamTutar AS [Tutar],
            S.Taburcu AS [Taburcu?]
        FROM Sevk S
        LEFT JOIN Hasta H ON S.DosyaNo = H.DosyaNo
        LEFT JOIN YapilanIslem YI ON S.SevkID = YI.SevkID
        LEFT JOIN Doktor D ON YI.DrKodu = D.DoktorKodu
        LEFT JOIN Poliklinik P ON D.PoliklinikID = P.PoliklinikID
        WHERE S.SevkTarihi BETWEEN @p1 AND @p2";

            
            if (rbTaburcuOlmus.Checked)
            {
                sql += " AND S.Taburcu = 'E'"; 
            }
            else if (rbTaburcuOlmamis.Checked)
            {
                sql += " AND (S.Taburcu = 'H' OR S.Taburcu IS NULL)"; 
            }

            
            sql += @" GROUP BY H.DosyaNo, H.Ad, H.Soyad, S.SevkTarihi, P.PoliklinikAdi, D.Ad, D.Soyad, S.ToplamTutar, S.Taburcu
              ORDER BY S.SevkTarihi DESC";

            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@p1", dtpBaslangic.Value.Date);

            // Bitiş tarihinin gün sonunu (23:59:59) kapsamak için
            DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);
            komut.Parameters.AddWithValue("@p2", bitisTarihi);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRapor.DataSource = dt;

            // Sütun genişliklerini otomatik ayarla
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            rbHepsi.Checked = true;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rapor yazıcıya gönderiliyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
