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
//Data Source=.;Initial Catalog=YurtOtomasyonu;Integrated Security=True

namespace YurtOtomasyonSistemi
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi baglan = new VeritabaniBaglantisi();
        
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri comboboxa çekme işlemi
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", baglan.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglan.baglanti().Close();
            //Boş Odaları Listeleme
           
            SqlCommand komut2 = new SqlCommand("select OdaNo From Odalar where OdaKapasite !=OdaAktif",baglan.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOda.Items.Add(oku2[0].ToString());
            }
            baglan.baglanti().Close();
        }

      
           

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlCommand OgrenciKayit = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOda,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan.baglanti());

                OgrenciKayit.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                OgrenciKayit.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                OgrenciKayit.Parameters.AddWithValue("@p3", MaskTC.Text);
                OgrenciKayit.Parameters.AddWithValue("@p4", MaskOgrTelefon.Text);
                OgrenciKayit.Parameters.AddWithValue("@p5", MaskDogum.Text);
                OgrenciKayit.Parameters.AddWithValue("@p6", CmbBolum.Text);
                OgrenciKayit.Parameters.AddWithValue("@p7", TxtMail.Text);
                OgrenciKayit.Parameters.AddWithValue("@p8", CmbOda.Text);
                OgrenciKayit.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                OgrenciKayit.Parameters.AddWithValue("@p10", MaskVeliTelefon.Text);
                OgrenciKayit.Parameters.AddWithValue("@p11", rchAdres.Text);
                OgrenciKayit.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Öğrenci Kaydı Eklendi");
                TxtMail.Clear();
                TxtOgrAd.Clear();
                rchAdres.Clear();
                CmbBolum.Text = "";
                CmbOda.Text = "";
                TxtOgrSoyad.Clear();
                TxtVeliAdSoyad.Clear();
                MaskDogum.Clear();
                MaskOgrTelefon.Clear();
                MaskTC.Clear();
                MaskVeliTelefon.Clear();
                

                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", baglan.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                baglan.baglanti().Close();
                
                
                //Ogrenci Borc Alanı olusturma
                SqlCommand OgrenciKayit2 = new SqlCommand("insert into Borclar(Ogrid,OgrAd,OgrSoyad) values(@p1,@p2,@p3)", baglan.baglanti());
                OgrenciKayit2.Parameters.AddWithValue("@p1", label12.Text);
                OgrenciKayit2.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                OgrenciKayit2.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                OgrenciKayit2.ExecuteNonQuery();
                baglan.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Lütfen tekrar deneyiniz");
            }
            //Öğrenci Oda Kontejanı Arttırma
            SqlCommand OdaKontejan = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", baglan.baglanti());
            OdaKontejan.Parameters.AddWithValue("@oda1", CmbOda.Text);
            OdaKontejan.ExecuteNonQuery();
            baglan.baglanti().Close();
        }
    }
}
