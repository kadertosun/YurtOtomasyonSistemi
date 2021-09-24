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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        VeritabaniBaglantisi baglan = new VeritabaniBaglantisi();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet10.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonuDataSet10.Borclar);
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec;
            string ogrenciId, ogrenciAd, ogrenciSoyad, kalan;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            ogrenciId = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            ogrenciAd = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            ogrenciSoyad = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            TxtID.Text = ogrenciId;
            TxtAdi.Text = ogrenciAd;
            TxtSoyadi.Text = ogrenciSoyad;
            TxtKalan.Text = kalan;
        
        
        }

        private void PcOdemeAl_Click(object sender, EventArgs e)
        {
            int odenenBorc, kalanBorc, yeniBorc;
            odenenBorc = Convert.ToInt16(TxtOdenen.Text);
            kalanBorc = Convert.ToInt16(TxtKalan.Text);
            yeniBorc = kalanBorc - odenenBorc;
            TxtKalan.Text = yeniBorc.ToString();

            SqlCommand OdemeHesap = new SqlCommand("update Borclar set OgrKalanBorc=@k1 where Ogrid=@k2", baglan.baglanti());
            OdemeHesap.Parameters.AddWithValue("@k2", TxtID.Text);
            OdemeHesap.Parameters.AddWithValue("@k1", TxtKalan.Text);
            OdemeHesap.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Borc Ödendi");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

            //Kasa Tablosuna ekleme
            SqlCommand KasaEkleme = new SqlCommand("insert into Kasa(OdemeAy,OdenenMiktar) values(@k1,@k2)", baglan.baglanti());
            KasaEkleme.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            KasaEkleme.Parameters.AddWithValue("@K2", TxtOdenen.Text);
            KasaEkleme.ExecuteNonQuery();
            baglan.baglanti().Close();

        }
    }
}
