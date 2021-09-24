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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string giderid,elektrik, su, dogalgaz, gida, internet, personel, diger;
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand GiderGuncelle = new SqlCommand("update Giderler set Elektrik=@k1,Su=@k2,Dogalgaz=@k3,internet=@k4,Gıda=@k5,Personel=@k6,Diger=@k7 where Odemeid=@k8", bagla.baglanti());
            GiderGuncelle.Parameters.AddWithValue("@k8", TxtGiderId.Text);
            GiderGuncelle.Parameters.AddWithValue("@k1", TxtElektrik.Text);
            GiderGuncelle.Parameters.AddWithValue("@k2", TxtSu.Text);
            GiderGuncelle.Parameters.AddWithValue("@k3", TxtDogalGaz.Text);
            GiderGuncelle.Parameters.AddWithValue("@k4", TxtInternet.Text);
            GiderGuncelle.Parameters.AddWithValue("@k5", TxtGida.Text);
            GiderGuncelle.Parameters.AddWithValue("@k6", TxtPersonel.Text);
            GiderGuncelle.Parameters.AddWithValue("@k7", TxtGider.Text);
            GiderGuncelle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi başarılı");
            TxtGiderId.Clear();
            TxtElektrik.Clear();
            TxtSu.Clear();
            TxtDogalGaz.Clear();
            TxtInternet.Clear();
            TxtGida.Clear();
            TxtPersonel.Clear();
            TxtGider.Clear();
        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderId.Text = giderid;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalGaz.Text = dogalgaz;
            TxtInternet.Text = internet;
            TxtGida.Text = gida;
            TxtPersonel.Text = personel;
            TxtGider.Text = diger;
            
           
            

        }
    }
}
