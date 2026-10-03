using System.Data.SqlClient;
namespace SOHATS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            SqlConnection baglanti = SQLBaglantisi.Baglan();

            
            SqlCommand komut = new SqlCommand("SELECT * FROM Kullanici WHERE Ad=@p1 AND Sifre=@p2", baglanti);

            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) 
            {
             
                AnaForm anaEkran = new AnaForm();
                anaEkran.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Yanlýþ kullanýcý adý ve/veya þifre", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
