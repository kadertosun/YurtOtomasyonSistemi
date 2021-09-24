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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();
        public string id, ad, soyad, tc, telefon, dogum, bolum, mail, oda, veliadsoyad, velitelefon, adres;

       

        private void PcbSil_Click(object sender, EventArgs e)
        {
            SqlCommand OgrenciSil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bagla.baglanti());
            OgrenciSil.Parameters.AddWithValue("@k1", txtOgrId.Text);
            OgrenciSil.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Öğrenci Kaydı Silindi");
            txtOgrId.Clear();
            TxtMail.Clear();
            txtOgrAdi.Clear();
            rchAdres.Clear();
            CmbBolum.Text = "";
            CmbOda.Text = "";
            TxtOgrSoyad.Clear();
            TxtVeliAdSoyad.Clear();
            MaskDogum.Clear();
            MaskOgrTelefon.Clear();
            MaskTC.Clear();
            MaskVeliTelefon.Clear();

            SqlCommand OdaKontejan = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda1", bagla.baglanti());
            OdaKontejan.Parameters.AddWithValue("@oda1", CmbOda.Text);
            OdaKontejan.ExecuteNonQuery();
            bagla.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand OgrenciGuncelle = new SqlCommand("update Ogrenci set OgrAd=@k2,OgrSoyad=@k3,OgrTC=@k4,OgrTelefon=@k5,OgrDogum=@k6,OgrBolum=@k7,OgrMail=@k8,OgrOda=@k9,OgrVeliAdSoyad=@k10,OgrVeliTelefon=@k11,OgrVeliAdres=@k12 where Ogrid=@k1", bagla.baglanti());
            OgrenciGuncelle.Parameters.AddWithValue("@k1", txtOgrId.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k2", txtOgrAdi.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k3", TxtOgrSoyad.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k4", MaskTC.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k5", MaskOgrTelefon.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k6", MaskDogum.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k7", CmbBolum.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k8", TxtMail.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k9", CmbOda.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k10", TxtVeliAdSoyad.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@K11", MaskVeliTelefon.Text);
            OgrenciGuncelle.Parameters.AddWithValue("@k12", rchAdres.Text);
            OgrenciGuncelle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi Başarılı");
            txtOgrId.Clear();
            TxtMail.Clear();
            txtOgrAdi.Clear();
            rchAdres.Clear();
            CmbBolum.Text = "";
            CmbOda.Text = "";
            TxtOgrSoyad.Clear();
            TxtVeliAdSoyad.Clear();
            MaskDogum.Clear();
            MaskOgrTelefon.Clear();
            MaskTC.Clear();
            MaskVeliTelefon.Clear();
        }

        
      

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            

            txtOgrId.Text = id;
            txtOgrAdi.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MaskTC.Text = tc;
            MaskOgrTelefon.Text= telefon;
            MaskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOda.Text = oda;
            TxtVeliAdSoyad.Text = veliadsoyad;
            MaskVeliTelefon.Text = velitelefon;
            rchAdres.Text = adres;
            

        }
    }
}
