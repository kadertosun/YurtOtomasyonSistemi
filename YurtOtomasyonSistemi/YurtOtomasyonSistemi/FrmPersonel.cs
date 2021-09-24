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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi bagla = new VeritabaniBaglantisi();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet9.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);

        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            SqlCommand PersonelEkle = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@k1,@k2)",bagla.baglanti());
            PersonelEkle.Parameters.AddWithValue("@k1", TxtAdSoyad.Text);
            PersonelEkle.Parameters.AddWithValue("@k2", TxtDepartman.Text);
            PersonelEkle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);
            TxtAdSoyad.Clear();
            TxtDepartman.Clear();



        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            SqlCommand PersonelSil = new SqlCommand("delete from Personel where Personelid=@p1",bagla.baglanti());
           
            PersonelSil.Parameters.AddWithValue("@p1", TxtPersonelId.Text);
            PersonelSil.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Personel Silindi");
            TxtAdSoyad.Clear();
            TxtDepartman.Clear();
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec;
            string id, personelad, personelbolum;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            personelad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            personelbolum = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            TxtPersonelId.Text = id;
            TxtAdSoyad.Text = personelad;
            TxtDepartman.Text = personelbolum;
        }

        private void PcbGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand PersonelGuncelle = new SqlCommand("update Personel Set PersonelAdSoyad=@k1, PersonelDepartman=@K2 where Personelid=@k3 ",bagla.baglanti());

            PersonelGuncelle.Parameters.AddWithValue("@k1", TxtAdSoyad.Text);
            PersonelGuncelle.Parameters.AddWithValue("@k2", TxtDepartman.Text);
            PersonelGuncelle.Parameters.AddWithValue("@k3", TxtPersonelId.Text);
            PersonelGuncelle.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Personel Güncelleme İşlemi Başarılı");
            TxtAdSoyad.Clear();
            TxtDepartman.Clear();
            TxtPersonelId.Clear();
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet9.Personel);
        }
    }
}
