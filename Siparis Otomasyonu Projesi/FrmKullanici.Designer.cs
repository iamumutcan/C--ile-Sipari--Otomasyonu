
namespace Siparis_Otomasyonu_Projesi
{
    partial class FrmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanici));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDetayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSiparisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTablosuV3 = new Siparis_Otomasyonu_Projesi.SiparisTablosuV3();
            this.tblSiparisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTablosuDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTablosuDataSet5 = new Siparis_Otomasyonu_Projesi.SiparisTablosuDataSet5();
            this.tblSiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisOtomasyonuDataSet1 = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet1();
            this.tbl_SiparisTableAdapter = new Siparis_Otomasyonu_Projesi.SiparisOtomasyonuDataSet1TableAdapters.Tbl_SiparisTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_SiparisTableAdapter1 = new Siparis_Otomasyonu_Projesi.SiparisTablosuDataSet5TableAdapters.Tbl_SiparisTableAdapter();
            this.BtnDetay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.siparisTablosuV3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SiparisTableAdapter2 = new Siparis_Otomasyonu_Projesi.SiparisTablosuV3TableAdapters.Tbl_SiparisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuV3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(79, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sipariş Oluştur";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "CikisYap.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "Kullanicilar.png");
            this.ımageList1.Images.SetKeyName(3, "Siparisler.png");
            this.ımageList1.Images.SetKeyName(4, "SiparisVer.png");
            this.ımageList1.Images.SetKeyName(5, "detay.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisKodDataGridViewTextBoxColumn,
            this.siparisTarihDataGridViewTextBoxColumn,
            this.siparisDurumDataGridViewTextBoxColumn,
            this.siparisTutarDataGridViewTextBoxColumn,
            this.siparisDesiDataGridViewTextBoxColumn,
            this.siparisDetayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSiparisBindingSource2;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(79, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // siparisKodDataGridViewTextBoxColumn
            // 
            this.siparisKodDataGridViewTextBoxColumn.DataPropertyName = "SiparisKod";
            this.siparisKodDataGridViewTextBoxColumn.HeaderText = "SiparisKod";
            this.siparisKodDataGridViewTextBoxColumn.Name = "siparisKodDataGridViewTextBoxColumn";
            this.siparisKodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTarihDataGridViewTextBoxColumn
            // 
            this.siparisTarihDataGridViewTextBoxColumn.DataPropertyName = "SiparisTarih";
            this.siparisTarihDataGridViewTextBoxColumn.HeaderText = "SiparisTarih";
            this.siparisTarihDataGridViewTextBoxColumn.Name = "siparisTarihDataGridViewTextBoxColumn";
            this.siparisTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisDurumDataGridViewTextBoxColumn
            // 
            this.siparisDurumDataGridViewTextBoxColumn.DataPropertyName = "SiparisDurum";
            this.siparisDurumDataGridViewTextBoxColumn.HeaderText = "SiparisDurum";
            this.siparisDurumDataGridViewTextBoxColumn.Name = "siparisDurumDataGridViewTextBoxColumn";
            this.siparisDurumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTutarDataGridViewTextBoxColumn
            // 
            this.siparisTutarDataGridViewTextBoxColumn.DataPropertyName = "SiparisTutar";
            this.siparisTutarDataGridViewTextBoxColumn.HeaderText = "SiparisTutar";
            this.siparisTutarDataGridViewTextBoxColumn.Name = "siparisTutarDataGridViewTextBoxColumn";
            this.siparisTutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisDesiDataGridViewTextBoxColumn
            // 
            this.siparisDesiDataGridViewTextBoxColumn.DataPropertyName = "SiparisDesi";
            this.siparisDesiDataGridViewTextBoxColumn.HeaderText = "SiparisDesi";
            this.siparisDesiDataGridViewTextBoxColumn.Name = "siparisDesiDataGridViewTextBoxColumn";
            this.siparisDesiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisDetayDataGridViewTextBoxColumn
            // 
            this.siparisDetayDataGridViewTextBoxColumn.DataPropertyName = "SiparisDetay";
            this.siparisDetayDataGridViewTextBoxColumn.HeaderText = "SiparisDetay";
            this.siparisDetayDataGridViewTextBoxColumn.Name = "siparisDetayDataGridViewTextBoxColumn";
            this.siparisDetayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblSiparisBindingSource2
            // 
            this.tblSiparisBindingSource2.DataMember = "Tbl_Siparis";
            this.tblSiparisBindingSource2.DataSource = this.siparisTablosuV3;
            // 
            // siparisTablosuV3
            // 
            this.siparisTablosuV3.DataSetName = "SiparisTablosuV3";
            this.siparisTablosuV3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSiparisBindingSource1
            // 
            this.tblSiparisBindingSource1.DataMember = "Tbl_Siparis";
            this.tblSiparisBindingSource1.DataSource = this.siparisTablosuDataSet5BindingSource;
            // 
            // siparisTablosuDataSet5BindingSource
            // 
            this.siparisTablosuDataSet5BindingSource.DataSource = this.siparisTablosuDataSet5;
            this.siparisTablosuDataSet5BindingSource.Position = 0;
            // 
            // siparisTablosuDataSet5
            // 
            this.siparisTablosuDataSet5.DataSetName = "SiparisTablosuDataSet5";
            this.siparisTablosuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSiparisBindingSource
            // 
            this.tblSiparisBindingSource.DataMember = "Tbl_Siparis";
            this.tblSiparisBindingSource.DataSource = this.siparisOtomasyonuDataSet1;
            // 
            // siparisOtomasyonuDataSet1
            // 
            this.siparisOtomasyonuDataSet1.DataSetName = "SiparisOtomasyonuDataSet1";
            this.siparisOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_SiparisTableAdapter
            // 
            this.tbl_SiparisTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geçmiş Siparişleriniz:";
            // 
            // tbl_SiparisTableAdapter1
            // 
            this.tbl_SiparisTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnDetay
            // 
            this.BtnDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDetay.ImageIndex = 5;
            this.BtnDetay.ImageList = this.ımageList1;
            this.BtnDetay.Location = new System.Drawing.Point(192, 12);
            this.BtnDetay.Name = "BtnDetay";
            this.BtnDetay.Size = new System.Drawing.Size(109, 76);
            this.BtnDetay.TabIndex = 3;
            this.BtnDetay.Text = "Detayları Gör";
            this.BtnDetay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDetay.UseVisualStyleBackColor = true;
            this.BtnDetay.Click += new System.EventHandler(this.BtnDetay_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(307, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 76);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çıkış Yap";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // siparisTablosuV3BindingSource
            // 
            this.siparisTablosuV3BindingSource.DataSource = this.siparisTablosuV3;
            this.siparisTablosuV3BindingSource.Position = 0;
            // 
            // tbl_SiparisTableAdapter2
            // 
            this.tbl_SiparisTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnDetay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESU | KULLANICI PANELİ";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSiparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTablosuV3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SiparisOtomasyonuDataSet1 siparisOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tblSiparisBindingSource;
        private SiparisOtomasyonuDataSet1TableAdapters.Tbl_SiparisTableAdapter tbl_SiparisTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource siparisTablosuDataSet5BindingSource;
        private SiparisTablosuDataSet5 siparisTablosuDataSet5;
        private System.Windows.Forms.BindingSource tblSiparisBindingSource1;
        private SiparisTablosuDataSet5TableAdapters.Tbl_SiparisTableAdapter tbl_SiparisTableAdapter1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnDetay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource siparisTablosuV3BindingSource;
        private SiparisTablosuV3 siparisTablosuV3;
        private System.Windows.Forms.BindingSource tblSiparisBindingSource2;
        private SiparisTablosuV3TableAdapters.Tbl_SiparisTableAdapter tbl_SiparisTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDetayDataGridViewTextBoxColumn;
    }
}