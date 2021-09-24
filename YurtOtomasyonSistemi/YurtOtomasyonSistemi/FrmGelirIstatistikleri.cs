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
    public partial class FrmGelirIstatistikleri : Form
    {
        public FrmGelirIstatistikleri()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi baglan = new VeritabaniBaglantisi();
        private void FrmGelirIstatistikleri_Load(object sender, EventArgs e)
        {
            SqlCommand KasadakiPara = new SqlCommand("Select Sum(OdenenMiktar) from Kasa", baglan.baglanti());
            SqlDataReader oku = KasadakiPara.ExecuteReader();
            while (oku.Read())
            {
                label1.Text = oku[0].ToString() + "TL";
            }
            baglan.baglanti().Close();
            //Tekrarsız olarak ayları listeleme
            SqlCommand komut = new SqlCommand("Select distinct(OdemeAy) from Kasa", baglan.baglanti());
            SqlDataReader oku2 = komut.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            baglan.baglanti().Close();
            SqlCommand AylıkListeleme = new SqlCommand("select OdemeAy, sum(OdenenMiktar) from Kasa group by OdemeAy",baglan.baglanti());

            SqlDataReader oku3 = AylıkListeleme.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            baglan.baglanti().Close();
        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand OdemeHesap = new SqlCommand("select sum(OdenenMiktar) from Kasa where OdemeAy=@k1", baglan.baglanti());
            OdemeHesap.Parameters.AddWithValue("@k1", CmbAy.Text);
            SqlDataReader oku = OdemeHesap.ExecuteReader();
            while (oku.Read())
            {
                LblAy.Text = oku[0].ToString();
            }
            baglan.baglanti().Close();
        }
    }
}
