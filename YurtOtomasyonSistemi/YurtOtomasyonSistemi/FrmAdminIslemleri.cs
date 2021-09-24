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
    public partial class FrmAdminIslemleri : Form
    {
        public FrmAdminIslemleri()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();
        private void FrmAdminIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, sifre;
            id = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[sec].Cells[2].Value.ToString();

            TxtKullanici.Text = ad;
            TxtSifre.Text = sifre;
            TxtPersonelId.Text = id;

        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            SqlCommand PersonelEkle = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values (@k1,@k2)",bagla.baglanti());
            PersonelEkle.Parameters.AddWithValue("@k1", TxtKullanici.Text);
            PersonelEkle.Parameters.AddWithValue("@k2", TxtSifre.Text);
            PersonelEkle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Yönetici Kaydı Eklendi");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);


        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            SqlCommand PersonelSil = new SqlCommand("delete from Admin where Yoneticiid=@p1", bagla.baglanti());
            PersonelSil.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
            PersonelSil.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Yönetici Kaydı Silindi");
            TxtKullanici.Clear();
            TxtSifre.Clear();
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }

        private void PcbGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand PersonelGuncelle = new SqlCommand("update Admin Set YoneticiAd=@k1, YoneticiSifre=@k2 where Yoneticiid=@k3", bagla.baglanti());
            PersonelGuncelle.Parameters.AddWithValue("@k1", TxtKullanici.Text);
            PersonelGuncelle.Parameters.AddWithValue("@k2", TxtSifre.Text);
            PersonelGuncelle.Parameters.AddWithValue("@k3", TxtPersonelId.Text);
            PersonelGuncelle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Personel Güncelleme İşlemi Başarılı");
            TxtKullanici.Clear();
            TxtSifre.Clear();
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Admin);
        }
    }
}
