using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // SQL kütüphanesini ekledik
using System.Data;

namespace SOHATS
{
    class SQLBaglantisi
    {
        // BURAYA DİKKAT: "Data Source" kısmını kendi bilgisayarına göre düzenle.
        // Genelde sadece nokta (.) veya (localdb)\MSSQLLocalDB veya DESKTOP-ADIN\SQLEXPRESS olur.
        public static string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=SOHATS_DB;Integrated Security=True";

        public static SqlConnection Baglan()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            if (baglanti.State == ConnectionState.Closed)
            {
                try
                {
                    baglanti.Open();
                }
                catch (Exception ex)
                {
                    // Bağlantı hatası olursa görelim
                    System.Windows.Forms.MessageBox.Show("Veritabanı Bağlantı Hatası: " + ex.Message);
                }
            }
            return baglanti;
        }
    }
}