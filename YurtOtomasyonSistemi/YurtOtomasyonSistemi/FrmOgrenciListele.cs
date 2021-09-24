using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonSistemi
{
    public partial class FrmOgrenciListele : Form
    {
        public FrmOgrenciListele()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet4.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Ogrenci);

        }
        int sec;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sec = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            fr.bolum= dataGridView1.Rows[sec].Cells[6].Value.ToString();
            fr.mail= dataGridView1.Rows[sec].Cells[7].Value.ToString();
            fr.oda= dataGridView1.Rows[sec].Cells[8].Value.ToString();
            fr.veliadsoyad= dataGridView1.Rows[sec].Cells[9].Value.ToString();
            fr.velitelefon= dataGridView1.Rows[sec].Cells[10].Value.ToString();
            fr.adres = dataGridView1.Rows[sec].Cells[11].Value.ToString();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Ogrenci);
            fr.Show();
         


        }
    }
}
