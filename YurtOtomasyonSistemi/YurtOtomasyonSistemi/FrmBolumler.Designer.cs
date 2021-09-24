
namespace YurtOtomasyonSistemi
{
    partial class FrmBolumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbGuncelle = new System.Windows.Forms.PictureBox();
            this.PcbSil = new System.Windows.Forms.PictureBox();
            this.PcbEkle = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet1 = new YurtOtomasyonSistemi.YurtOtomasyonuDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumId = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.bolumlerTableAdapter = new YurtOtomasyonSistemi.YurtOtomasyonuDataSet1TableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbGuncelle
            // 
            this.PcbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbGuncelle.Image")));
            this.PcbGuncelle.Location = new System.Drawing.Point(324, 33);
            this.PcbGuncelle.Name = "PcbGuncelle";
            this.PcbGuncelle.Size = new System.Drawing.Size(38, 50);
            this.PcbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbGuncelle.TabIndex = 0;
            this.PcbGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbGuncelle, "Bölüm güncelle");
            this.PcbGuncelle.Click += new System.EventHandler(this.PcbGuncelle_Click);
            // 
            // PcbSil
            // 
            this.PcbSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbSil.Image")));
            this.PcbSil.Location = new System.Drawing.Point(368, 33);
            this.PcbSil.Name = "PcbSil";
            this.PcbSil.Size = new System.Drawing.Size(37, 50);
            this.PcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbSil.TabIndex = 1;
            this.PcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbSil, "Bölüm sil");
            this.PcbSil.Click += new System.EventHandler(this.PcbSil_Click);
            // 
            // PcbEkle
            // 
            this.PcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbEkle.Image")));
            this.PcbEkle.Location = new System.Drawing.Point(289, 33);
            this.PcbEkle.Name = "PcbEkle";
            this.PcbEkle.Size = new System.Drawing.Size(29, 50);
            this.PcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbEkle.TabIndex = 2;
            this.PcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbEkle, "Bölüm ekle");
            this.PcbEkle.Click += new System.EventHandler(this.PcbEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 171);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet1;
            // 
            // yurtOtomasyonuDataSet1
            // 
            this.yurtOtomasyonuDataSet1.DataSetName = "YurtOtomasyonuDataSet1";
            this.yurtOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölüm ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBolumId
            // 
            this.TxtBolumId.Enabled = false;
            this.TxtBolumId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumId.Location = new System.Drawing.Point(127, 48);
            this.TxtBolumId.Name = "TxtBolumId";
            this.TxtBolumId.Size = new System.Drawing.Size(134, 26);
            this.TxtBolumId.TabIndex = 6;
            this.TxtBolumId.TextChanged += new System.EventHandler(this.TxtBolumId_TextChanged);
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(127, 85);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(134, 26);
            this.TxtBolumAd.TabIndex = 7;
            this.TxtBolumAd.TextChanged += new System.EventHandler(this.TxtBolumAd_TextChanged);
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.TxtBolumId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PcbEkle);
            this.Controls.Add(this.PcbSil);
            this.Controls.Add(this.PcbGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölüm Ekleme Formu";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbGuncelle;
        private System.Windows.Forms.PictureBox PcbSil;
        private System.Windows.Forms.PictureBox PcbEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumId;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private YurtOtomasyonuDataSet1 yurtOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSet1TableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}