
namespace Siparis_Otomasyonu_Projesi
{
    partial class FrmAdminUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminUrun));
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtUrunAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunDesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisOtomasyonuDataSet3 = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet3();
            this.tbl_UrunTableAdapter = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet3TableAdapters.Tbl_UrunTableAdapter();
            this.TxtUrunDesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuAdminSiparisler = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAdminKullancilar = new System.Windows.Forms.Button();
            this.MenuAdminUrunler = new System.Windows.Forms.Button();
            this.MenuAdminAnasayfa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(28, 428);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(164, 23);
            this.BtnUrunGuncelle.TabIndex = 26;
            this.BtnUrunGuncelle.Text = "Ürün Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(28, 399);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(164, 23);
            this.BtnUrunSil.TabIndex = 25;
            this.BtnUrunSil.Text = "Ürün Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(28, 370);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(164, 23);
            this.BtnUrunEkle.TabIndex = 24;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ürünleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtUrunAciklama
            // 
            this.TxtUrunAciklama.Location = new System.Drawing.Point(13, 267);
            this.TxtUrunAciklama.Multiline = true;
            this.TxtUrunAciklama.Name = "TxtUrunAciklama";
            this.TxtUrunAciklama.Size = new System.Drawing.Size(180, 54);
            this.TxtUrunAciklama.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ürün Açıklama";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtUrunFiyat
            // 
            this.TxtUrunFiyat.Location = new System.Drawing.Point(92, 197);
            this.TxtUrunFiyat.Name = "TxtUrunFiyat";
            this.TxtUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunFiyat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ürün Fiyatı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(92, 171);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunAd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(92, 145);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.urunDesiDataGridViewTextBoxColumn,
            this.urunAciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 277);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            // 
            // urunDesiDataGridViewTextBoxColumn
            // 
            this.urunDesiDataGridViewTextBoxColumn.DataPropertyName = "UrunDesi";
            this.urunDesiDataGridViewTextBoxColumn.HeaderText = "UrunDesi";
            this.urunDesiDataGridViewTextBoxColumn.Name = "urunDesiDataGridViewTextBoxColumn";
            // 
            // urunAciklamaDataGridViewTextBoxColumn
            // 
            this.urunAciklamaDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklama";
            this.urunAciklamaDataGridViewTextBoxColumn.HeaderText = "UrunAciklama";
            this.urunAciklamaDataGridViewTextBoxColumn.Name = "urunAciklamaDataGridViewTextBoxColumn";
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "Tbl_Urun";
            this.tblUrunBindingSource.DataSource = this.siparisOtomasyonuDataSet3;
            // 
            // siparisOtomasyonuDataSet3
            // 
            this.siparisOtomasyonuDataSet3.DataSetName = "SiparisOtomasyonuDataSet3";
            this.siparisOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UrunTableAdapter
            // 
            this.tbl_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // TxtUrunDesi
            // 
            this.TxtUrunDesi.Location = new System.Drawing.Point(92, 223);
            this.TxtUrunDesi.Name = "TxtUrunDesi";
            this.TxtUrunDesi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunDesi.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Desi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MenuAdminSiparisler
            // 
            this.MenuAdminSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminSiparisler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminSiparisler.ImageKey = "Siparisler.png";
            this.MenuAdminSiparisler.ImageList = this.ımageList1;
            this.MenuAdminSiparisler.Location = new System.Drawing.Point(300, 12);
            this.MenuAdminSiparisler.Name = "MenuAdminSiparisler";
            this.MenuAdminSiparisler.Size = new System.Drawing.Size(90, 75);
            this.MenuAdminSiparisler.TabIndex = 33;
            this.MenuAdminSiparisler.Text = "Siparişler";
            this.MenuAdminSiparisler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuAdminSiparisler.UseVisualStyleBackColor = true;
            this.MenuAdminSiparisler.Click += new System.EventHandler(this.MenuAdminSiparisler_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Anasayfa.png");
            this.ımageList1.Images.SetKeyName(1, "CikisYap.png");
            this.ımageList1.Images.SetKeyName(2, "Siparisler.png");
            this.ımageList1.Images.SetKeyName(3, "urunler.png");
            this.ımageList1.Images.SetKeyName(4, "user.png");
            // 
            // MenuAdminKullancilar
            // 
            this.MenuAdminKullancilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminKullancilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminKullancilar.ImageKey = "user.png";
            this.MenuAdminKullancilar.ImageList = this.ımageList1;
            this.MenuAdminKullancilar.Location = new System.Drawing.Point(204, 12);
            this.MenuAdminKullancilar.Name = "MenuAdminKullancilar";
            this.MenuAdminKullancilar.Size = new System.Drawing.Size(90, 75);
            this.MenuAdminKullancilar.TabIndex = 32;
            this.MenuAdminKullancilar.Text = "Kullanıcılar";
            this.MenuAdminKullancilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuAdminKullancilar.UseVisualStyleBackColor = true;
            this.MenuAdminKullancilar.Click += new System.EventHandler(this.MenuAdminKullancilar_Click);
            // 
            // MenuAdminUrunler
            // 
            this.MenuAdminUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminUrunler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminUrunler.ImageKey = "urunler.png";
            this.MenuAdminUrunler.ImageList = this.ımageList1;
            this.MenuAdminUrunler.Location = new System.Drawing.Point(108, 12);
            this.MenuAdminUrunler.Name = "MenuAdminUrunler";
            this.MenuAdminUrunler.Size = new System.Drawing.Size(90, 75);
            this.MenuAdminUrunler.TabIndex = 31;
            this.MenuAdminUrunler.Text = "Urunler";
            this.MenuAdminUrunler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuAdminUrunler.UseVisualStyleBackColor = true;
            this.MenuAdminUrunler.Click += new System.EventHandler(this.MenuAdminUrunler_Click);
            // 
            // MenuAdminAnasayfa
            // 
            this.MenuAdminAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminAnasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminAnasayfa.ImageKey = "Anasayfa.png";
            this.MenuAdminAnasayfa.ImageList = this.ımageList1;
            this.MenuAdminAnasayfa.Location = new System.Drawing.Point(12, 12);
            this.MenuAdminAnasayfa.Name = "MenuAdminAnasayfa";
            this.MenuAdminAnasayfa.Size = new System.Drawing.Size(90, 75);
            this.MenuAdminAnasayfa.TabIndex = 30;
            this.MenuAdminAnasayfa.Text = "Anasayfa";
            this.MenuAdminAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuAdminAnasayfa.UseVisualStyleBackColor = true;
            this.MenuAdminAnasayfa.Click += new System.EventHandler(this.MenuAdminAnasayfa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ürünler Sayfası";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "CikisYap.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(396, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 75);
            this.button2.TabIndex = 56;
            this.button2.Text = "Çıkış Yap";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAdminUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MenuAdminSiparisler);
            this.Controls.Add(this.MenuAdminKullancilar);
            this.Controls.Add(this.MenuAdminUrunler);
            this.Controls.Add(this.MenuAdminAnasayfa);
            this.Controls.Add(this.TxtUrunDesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUrunGuncelle);
            this.Controls.Add(this.BtnUrunSil);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtUrunAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUrunFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESU | ADMİN | ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmAdminUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtUrunAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUrunFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SiparisOtomasyonuDataSet3 siparisOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private SiparisOtomasyonuDataSet3TableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.TextBox TxtUrunDesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MenuAdminSiparisler;
        private System.Windows.Forms.Button MenuAdminKullancilar;
        private System.Windows.Forms.Button MenuAdminUrunler;
        private System.Windows.Forms.Button MenuAdminAnasayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
    }
}