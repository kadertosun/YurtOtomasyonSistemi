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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi baglan = new VeritabaniBaglantisi();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet1.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);

        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand BolumEkle = new SqlCommand("insert into Bolumler (BolumAd) values (@k1)",baglan.baglanti());
                BolumEkle.Parameters.AddWithValue("@k1", TxtBolumAd.Text);
                BolumEkle.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Bölüm eklendi");
                TxtBolumAd.Clear();
                TxtBolumId.Clear();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show ("Hatta! Lütfen Tekrar Deneyiniz");
            }


        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand BolumSil = new SqlCommand("delete from Bolumler where Bolumid=@p1", baglan.baglanti());
                BolumSil.Parameters.AddWithValue("@p1", TxtBolumId.Text);
                BolumSil.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Bölüm Silindi");
                TxtBolumAd.Clear();
                TxtBolumId.Clear();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Tekrar Deneyiniz");
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec;
            string id, bolumad;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            TxtBolumId.Text = id;
            TxtBolumAd.Text = bolumad;


        }

        private void PcbGuncelle_Click(object sender, EventArgs e)
            
        {
            try
            {

                
                SqlCommand BolumGuncelle = new SqlCommand("update Bolumler Set BolumAd=@k1 where Bolumid=@k2", baglan.baglanti());
                BolumGuncelle.Parameters.AddWithValue("@k2", TxtBolumId.Text);
                BolumGuncelle.Parameters.AddWithValue("@k1", TxtBolumAd.Text);
                BolumGuncelle.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Bölüm Güncelleme İşlemi Başarılı");
                TxtBolumAd.Clear();
                TxtBolumId.Clear();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata! İşlem Gerçekleşemedi");
            }
        }

        private void TxtBolumId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBolumAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
