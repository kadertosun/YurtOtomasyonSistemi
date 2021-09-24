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

namespace YurtOtomasyonSistemi
{
    public partial class FrmAdminGris : Form
    {
        public FrmAdminGris()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();

        private void FrmAdminGris_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand Giris = new SqlCommand("select *from Admin  where YoneticiAd=@p1 and YoneticiSifre=@p2", bagla.baglanti());
            Giris.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            Giris.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = Giris.ExecuteReader();
            
            if (oku.Read())
            {
                FrmAnasayfa frmA= new FrmAnasayfa();
                frmA.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
                TxtKullaniciAdi.Clear();
                TxtSifre.Clear();
            }
            bagla.baglanti().Close();


        }
    }
}
