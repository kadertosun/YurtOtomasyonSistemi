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
    public partial class FrmGider : Form
    {
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();
        public FrmGider()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand GiderEkle = new SqlCommand("insert into Giderler(Elektrik,Su,Dogalgaz,internet,Gıda,Personel,Diger) values(@k1,@k2,@k3,@k4,@k5,@k6,@k7)", bagla.baglanti());
            GiderEkle.Parameters.AddWithValue("@k1", TxtElektrik.Text);
            GiderEkle.Parameters.AddWithValue("@k2", TxtSu.Text);
            GiderEkle.Parameters.AddWithValue("@k3", TxtDogalGaz.Text);
            GiderEkle.Parameters.AddWithValue("@k4", TxtInternet.Text);
            GiderEkle.Parameters.AddWithValue("@k5", TxtGida.Text);
            GiderEkle.Parameters.AddWithValue("@k6", TxtPersonel.Text);
            GiderEkle.Parameters.AddWithValue("@k7", TxtGider.Text);
            GiderEkle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Gider Kaydı Eklendi");
            TxtElektrik.Clear();
            TxtSu.Clear();
            TxtDogalGaz.Clear();
            TxtInternet.Clear();
            TxtGida.Clear();
            TxtPersonel.Clear();
            TxtGider.Clear();
            
            


        }
    }
}
