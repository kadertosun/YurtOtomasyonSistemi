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
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet7.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec;
            FrmGiderGuncelle frmGüncelle = new FrmGiderGuncelle();
            sec = dataGridView1.SelectedCells[0].RowIndex;
            frmGüncelle.giderid = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            frmGüncelle.elektrik = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            frmGüncelle.su = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            frmGüncelle.dogalgaz = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            frmGüncelle.internet = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            frmGüncelle.gida = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            frmGüncelle.personel = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            frmGüncelle.diger = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            frmGüncelle.Show();
        }
    }
}
