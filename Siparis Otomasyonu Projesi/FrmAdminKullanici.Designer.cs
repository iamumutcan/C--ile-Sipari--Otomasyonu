
namespace Siparis_Otomasyonu_Projesi
{
    partial class FrmAdminKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminKullanici));
            this.MenuAdminSiparisler = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAdminKullancilar = new System.Windows.Forms.Button();
            this.MenuAdminUrunler = new System.Windows.Forms.Button();
            this.MenuAdminAnasayfa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciYoneticiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblKullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisOtomasyonuDataSet2 = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet2();
            this.BtnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.BtnKullaniciSil = new System.Windows.Forms.Button();
            this.BtnKullaniciEkle = new System.Windows.Forms.Button();
            this.BtnKullaniciListele = new System.Windows.Forms.Button();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisOtomasyonuDataSet1 = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet1();
            this.siparisOtomasyonuDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KullanicilarTableAdapter = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet2TableAdapters.Tbl_KullanicilarTableAdapter();
            this.checkBoxYoneticiMi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuAdminSiparisler
            // 
            this.MenuAdminSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminSiparisler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminSiparisler.ImageKey = "Siparisler.png";
            this.MenuAdminSiparisler.ImageList = this.ımageList1;
            this.MenuAdminSiparisler.Location = new System.Drawing.Point(304, 11);
            this.MenuAdminSiparisler.Name = "MenuAdminSiparisler";
            this.MenuAdminSiparisler.Size = new System.Drawing.Size(90, 77);
            this.MenuAdminSiparisler.TabIndex = 52;
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
            this.ımageList1.Images.SetKeyName(1, "Siparisler.png");
            this.ımageList1.Images.SetKeyName(2, "urunler.png");
            this.ımageList1.Images.SetKeyName(3, "user.png");
            this.ımageList1.Images.SetKeyName(4, "CikisYap.png");
            // 
            // MenuAdminKullancilar
            // 
            this.MenuAdminKullancilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuAdminKullancilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAdminKullancilar.ImageKey = "user.png";
            this.MenuAdminKullancilar.ImageList = this.ımageList1;
            this.MenuAdminKullancilar.Location = new System.Drawing.Point(208, 11);
            this.MenuAdminKullancilar.Name = "MenuAdminKullancilar";
            this.MenuAdminKullancilar.Size = new System.Drawing.Size(90, 77);
            this.MenuAdminKullancilar.TabIndex = 51;
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
            this.MenuAdminUrunler.Location = new System.Drawing.Point(112, 11);
            this.MenuAdminUrunler.Name = "MenuAdminUrunler";
            this.MenuAdminUrunler.Size = new System.Drawing.Size(90, 77);
            this.MenuAdminUrunler.TabIndex = 50;
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
            this.MenuAdminAnasayfa.Location = new System.Drawing.Point(16, 11);
            this.MenuAdminAnasayfa.Name = "MenuAdminAnasayfa";
            this.MenuAdminAnasayfa.Size = new System.Drawing.Size(90, 77);
            this.MenuAdminAnasayfa.TabIndex = 49;
            this.MenuAdminAnasayfa.Text = "Anasayfa";
            this.MenuAdminAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuAdminAnasayfa.UseVisualStyleBackColor = true;
            this.MenuAdminAnasayfa.Click += new System.EventHandler(this.MenuAdminAnasayfa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIdDataGridViewTextBoxColumn,
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.kullaniciSifreDataGridViewTextBoxColumn,
            this.kullaniciAdresDataGridViewTextBoxColumn,
            this.kullaniciYoneticiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblKullanicilarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(208, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kullaniciIdDataGridViewTextBoxColumn
            // 
            this.kullaniciIdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.HeaderText = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.Name = "kullaniciIdDataGridViewTextBoxColumn";
            this.kullaniciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdDataGridViewTextBoxColumn
            // 
            this.kullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.HeaderText = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.Name = "kullaniciAdDataGridViewTextBoxColumn";
            // 
            // kullaniciSifreDataGridViewTextBoxColumn
            // 
            this.kullaniciSifreDataGridViewTextBoxColumn.DataPropertyName = "KullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.HeaderText = "KullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.Name = "kullaniciSifreDataGridViewTextBoxColumn";
            // 
            // kullaniciAdresDataGridViewTextBoxColumn
            // 
            this.kullaniciAdresDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdres";
            this.kullaniciAdresDataGridViewTextBoxColumn.HeaderText = "KullaniciAdres";
            this.kullaniciAdresDataGridViewTextBoxColumn.Name = "kullaniciAdresDataGridViewTextBoxColumn";
            // 
            // kullaniciYoneticiDataGridViewCheckBoxColumn
            // 
            this.kullaniciYoneticiDataGridViewCheckBoxColumn.DataPropertyName = "KullaniciYonetici";
            this.kullaniciYoneticiDataGridViewCheckBoxColumn.HeaderText = "KullaniciYonetici";
            this.kullaniciYoneticiDataGridViewCheckBoxColumn.Name = "kullaniciYoneticiDataGridViewCheckBoxColumn";
            // 
            // tblKullanicilarBindingSource
            // 
            this.tblKullanicilarBindingSource.DataMember = "Tbl_Kullanicilar";
            this.tblKullanicilarBindingSource.DataSource = this.siparisOtomasyonuDataSet2;
            // 
            // siparisOtomasyonuDataSet2
            // 
            this.siparisOtomasyonuDataSet2.DataSetName = "SiparisOtomasyonuDataSet2";
            this.siparisOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnKullaniciGuncelle
            // 
            this.BtnKullaniciGuncelle.Location = new System.Drawing.Point(32, 376);
            this.BtnKullaniciGuncelle.Name = "BtnKullaniciGuncelle";
            this.BtnKullaniciGuncelle.Size = new System.Drawing.Size(164, 23);
            this.BtnKullaniciGuncelle.TabIndex = 45;
            this.BtnKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            this.BtnKullaniciGuncelle.UseVisualStyleBackColor = true;
            this.BtnKullaniciGuncelle.Click += new System.EventHandler(this.BtnKullaniciGuncelle_Click);
            // 
            // BtnKullaniciSil
            // 
            this.BtnKullaniciSil.Location = new System.Drawing.Point(32, 347);
            this.BtnKullaniciSil.Name = "BtnKullaniciSil";
            this.BtnKullaniciSil.Size = new System.Drawing.Size(164, 23);
            this.BtnKullaniciSil.TabIndex = 44;
            this.BtnKullaniciSil.Text = "Kullanıcı Sil";
            this.BtnKullaniciSil.UseVisualStyleBackColor = true;
            this.BtnKullaniciSil.Click += new System.EventHandler(this.BtnKullaniciSil_Click);
            // 
            // BtnKullaniciEkle
            // 
            this.BtnKullaniciEkle.Location = new System.Drawing.Point(32, 318);
            this.BtnKullaniciEkle.Name = "BtnKullaniciEkle";
            this.BtnKullaniciEkle.Size = new System.Drawing.Size(164, 23);
            this.BtnKullaniciEkle.TabIndex = 43;
            this.BtnKullaniciEkle.Text = "Kullanıcı  Ekle";
            this.BtnKullaniciEkle.UseVisualStyleBackColor = true;
            this.BtnKullaniciEkle.Click += new System.EventHandler(this.BtnKullaniciEkle_Click);
            // 
            // BtnKullaniciListele
            // 
            this.BtnKullaniciListele.Location = new System.Drawing.Point(32, 289);
            this.BtnKullaniciListele.Name = "BtnKullaniciListele";
            this.BtnKullaniciListele.Size = new System.Drawing.Size(164, 23);
            this.BtnKullaniciListele.TabIndex = 42;
            this.BtnKullaniciListele.Text = "Kullanıcıları Listele";
            this.BtnKullaniciListele.UseVisualStyleBackColor = true;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(96, 225);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(100, 20);
            this.TxtAdres.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kullanıcı Adres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(96, 199);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtSifre.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kullanıcı Şifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(96, 173);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kullanıcı Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(96, 147);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(100, 20);
            this.Txtid.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kullanıcı Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // siparisOtomasyonuDataSet1
            // 
            this.siparisOtomasyonuDataSet1.DataSetName = "SiparisOtomasyonuDataSet1";
            this.siparisOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisOtomasyonuDataSet1BindingSource
            // 
            this.siparisOtomasyonuDataSet1BindingSource.DataSource = this.siparisOtomasyonuDataSet1;
            this.siparisOtomasyonuDataSet1BindingSource.Position = 0;
            // 
            // tbl_KullanicilarTableAdapter
            // 
            this.tbl_KullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxYoneticiMi
            // 
            this.checkBoxYoneticiMi.AutoSize = true;
            this.checkBoxYoneticiMi.Location = new System.Drawing.Point(96, 252);
            this.checkBoxYoneticiMi.Name = "checkBoxYoneticiMi";
            this.checkBoxYoneticiMi.Size = new System.Drawing.Size(83, 17);
            this.checkBoxYoneticiMi.TabIndex = 53;
            this.checkBoxYoneticiMi.Text = "Yönetici mi?";
            this.checkBoxYoneticiMi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Kullanıcılar Sayfası";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "CikisYap.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(400, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 77);
            this.button1.TabIndex = 55;
            this.button1.Text = "Çıkış Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdminKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxYoneticiMi);
            this.Controls.Add(this.MenuAdminSiparisler);
            this.Controls.Add(this.MenuAdminKullancilar);
            this.Controls.Add(this.MenuAdminUrunler);
            this.Controls.Add(this.MenuAdminAnasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnKullaniciGuncelle);
            this.Controls.Add(this.BtnKullaniciSil);
            this.Controls.Add(this.BtnKullaniciEkle);
            this.Controls.Add(this.BtnKullaniciListele);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESU | ADMİN | KULLANICILAR";
            this.Load += new System.EventHandler(this.FrmAdminKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuAdminSiparisler;
        private System.Windows.Forms.Button MenuAdminKullancilar;
        private System.Windows.Forms.Button MenuAdminUrunler;
        private System.Windows.Forms.Button MenuAdminAnasayfa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKullaniciGuncelle;
        private System.Windows.Forms.Button BtnKullaniciSil;
        private System.Windows.Forms.Button BtnKullaniciEkle;
        private System.Windows.Forms.Button BtnKullaniciListele;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource siparisOtomasyonuDataSet1BindingSource;
        private SiparisOtomasyonuDataSet1 siparisOtomasyonuDataSet1;
        private SiparisOtomasyonuDataSet2 siparisOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource tblKullanicilarBindingSource;
        private SiparisOtomasyonuDataSet2TableAdapters.Tbl_KullanicilarTableAdapter tbl_KullanicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kullaniciYoneticiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxYoneticiMi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}