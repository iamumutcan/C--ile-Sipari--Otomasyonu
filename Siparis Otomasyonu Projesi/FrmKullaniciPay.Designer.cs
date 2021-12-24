
namespace Siparis_Otomasyonu_Projesi
{
    partial class FrmKullaniciPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciPay));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKart = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKartSahibiAd = new System.Windows.Forms.TextBox();
            this.CmbSktYil = new System.Windows.Forms.ComboBox();
            this.CmbSktAy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKartNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKartCvc = new System.Windows.Forms.TextBox();
            this.panelKartOnay = new System.Windows.Forms.Panel();
            this.BtnOnayKoduOnay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOnayKodu = new System.Windows.Forms.TextBox();
            this.BtnKartPanelOde = new System.Windows.Forms.Button();
            this.panelNakit = new System.Windows.Forms.Panel();
            this.btnNakitOnay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBankCek = new System.Windows.Forms.Panel();
            this.BtnCheckOnay = new System.Windows.Forms.Button();
            this.txtCheckBankId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCheckAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelKartOnay.SuspendLayout();
            this.panelNakit.SuspendLayout();
            this.panelBankCek.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Tutar:";
            // 
            // BtnKart
            // 
            this.BtnKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKart.ImageKey = "credit-card.png";
            this.BtnKart.ImageList = this.ımageList1;
            this.BtnKart.Location = new System.Drawing.Point(176, 12);
            this.BtnKart.Name = "BtnKart";
            this.BtnKart.Size = new System.Drawing.Size(97, 85);
            this.BtnKart.TabIndex = 1;
            this.BtnKart.Text = "Kart ile Öde";
            this.BtnKart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKart.UseVisualStyleBackColor = true;
            this.BtnKart.Click += new System.EventHandler(this.BtnKart_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cheque.png");
            this.ımageList1.Images.SetKeyName(1, "credit-card.png");
            this.ımageList1.Images.SetKeyName(2, "money.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageKey = "money.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(279, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nakit ile Öde";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageKey = "cheque.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(382, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çek ile Öde";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelKartOnay);
            this.panel2.Controls.Add(this.BtnKartPanelOde);
            this.panel2.Location = new System.Drawing.Point(152, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 334);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtKartSahibiAd);
            this.panel1.Controls.Add(this.CmbSktYil);
            this.panel1.Controls.Add(this.CmbSktAy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtKartNumarasi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 141);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "/";
            // 
            // TxtKartSahibiAd
            // 
            this.TxtKartSahibiAd.Location = new System.Drawing.Point(112, 109);
            this.TxtKartSahibiAd.Name = "TxtKartSahibiAd";
            this.TxtKartSahibiAd.Size = new System.Drawing.Size(101, 20);
            this.TxtKartSahibiAd.TabIndex = 3;
            // 
            // CmbSktYil
            // 
            this.CmbSktYil.FormattingEnabled = true;
            this.CmbSktYil.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.CmbSktYil.Location = new System.Drawing.Point(50, 108);
            this.CmbSktYil.Name = "CmbSktYil";
            this.CmbSktYil.Size = new System.Drawing.Size(35, 21);
            this.CmbSktYil.TabIndex = 12;
            // 
            // CmbSktAy
            // 
            this.CmbSktAy.FormattingEnabled = true;
            this.CmbSktAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.CmbSktAy.Location = new System.Drawing.Point(7, 108);
            this.CmbSktAy.Name = "CmbSktAy";
            this.CmbSktAy.Size = new System.Drawing.Size(35, 21);
            this.CmbSktAy.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kart Sahibinin Adı:";
            // 
            // TxtKartNumarasi
            // 
            this.TxtKartNumarasi.Location = new System.Drawing.Point(10, 71);
            this.TxtKartNumarasi.MaxLength = 16;
            this.TxtKartNumarasi.Name = "TxtKartNumarasi";
            this.TxtKartNumarasi.Size = new System.Drawing.Size(203, 20);
            this.TxtKartNumarasi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kart Numarasını Giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SKT";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtKartCvc);
            this.panel3.Location = new System.Drawing.Point(11, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 142);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CVC";
            // 
            // TxtKartCvc
            // 
            this.TxtKartCvc.Location = new System.Drawing.Point(165, 65);
            this.TxtKartCvc.MaxLength = 3;
            this.TxtKartCvc.Name = "TxtKartCvc";
            this.TxtKartCvc.Size = new System.Drawing.Size(45, 20);
            this.TxtKartCvc.TabIndex = 5;
            // 
            // panelKartOnay
            // 
            this.panelKartOnay.Controls.Add(this.BtnOnayKoduOnay);
            this.panelKartOnay.Controls.Add(this.label6);
            this.panelKartOnay.Controls.Add(this.TxtOnayKodu);
            this.panelKartOnay.Location = new System.Drawing.Point(260, 99);
            this.panelKartOnay.Name = "panelKartOnay";
            this.panelKartOnay.Size = new System.Drawing.Size(161, 100);
            this.panelKartOnay.TabIndex = 6;
            this.panelKartOnay.Visible = false;
            // 
            // BtnOnayKoduOnay
            // 
            this.BtnOnayKoduOnay.Location = new System.Drawing.Point(40, 65);
            this.BtnOnayKoduOnay.Name = "BtnOnayKoduOnay";
            this.BtnOnayKoduOnay.Size = new System.Drawing.Size(75, 23);
            this.BtnOnayKoduOnay.TabIndex = 10;
            this.BtnOnayKoduOnay.Text = "Onayla";
            this.BtnOnayKoduOnay.UseVisualStyleBackColor = true;
            this.BtnOnayKoduOnay.Click += new System.EventHandler(this.BtnOnayKoduOnay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SMS\'de gelen şifreyi giriniz:";
            // 
            // TxtOnayKodu
            // 
            this.TxtOnayKodu.Location = new System.Drawing.Point(13, 36);
            this.TxtOnayKodu.Name = "TxtOnayKodu";
            this.TxtOnayKodu.Size = new System.Drawing.Size(131, 20);
            this.TxtOnayKodu.TabIndex = 8;
            // 
            // BtnKartPanelOde
            // 
            this.BtnKartPanelOde.Location = new System.Drawing.Point(52, 304);
            this.BtnKartPanelOde.Name = "BtnKartPanelOde";
            this.BtnKartPanelOde.Size = new System.Drawing.Size(154, 23);
            this.BtnKartPanelOde.TabIndex = 6;
            this.BtnKartPanelOde.Text = "Ödeme Yap";
            this.BtnKartPanelOde.UseVisualStyleBackColor = true;
            this.BtnKartPanelOde.Click += new System.EventHandler(this.BtnKartPanelOde_Click);
            // 
            // panelNakit
            // 
            this.panelNakit.Controls.Add(this.btnNakitOnay);
            this.panelNakit.Controls.Add(this.label8);
            this.panelNakit.Location = new System.Drawing.Point(259, 103);
            this.panelNakit.Name = "panelNakit";
            this.panelNakit.Size = new System.Drawing.Size(232, 217);
            this.panelNakit.TabIndex = 6;
            this.panelNakit.Visible = false;
            // 
            // btnNakitOnay
            // 
            this.btnNakitOnay.Location = new System.Drawing.Point(90, 90);
            this.btnNakitOnay.Name = "btnNakitOnay";
            this.btnNakitOnay.Size = new System.Drawing.Size(75, 23);
            this.btnNakitOnay.TabIndex = 1;
            this.btnNakitOnay.Text = "Onayla";
            this.btnNakitOnay.UseVisualStyleBackColor = true;
            this.btnNakitOnay.Click += new System.EventHandler(this.btnNakitOnay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kapıda ödeme için +12TL \r\nalıncaktır onaylıyor musunuz?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBankCek
            // 
            this.panelBankCek.Controls.Add(this.BtnCheckOnay);
            this.panelBankCek.Controls.Add(this.txtCheckBankId);
            this.panelBankCek.Controls.Add(this.label10);
            this.panelBankCek.Controls.Add(this.TxtCheckAd);
            this.panelBankCek.Controls.Add(this.label9);
            this.panelBankCek.Location = new System.Drawing.Point(259, 101);
            this.panelBankCek.Name = "panelBankCek";
            this.panelBankCek.Size = new System.Drawing.Size(243, 238);
            this.panelBankCek.TabIndex = 7;
            this.panelBankCek.Visible = false;
            // 
            // BtnCheckOnay
            // 
            this.BtnCheckOnay.Location = new System.Drawing.Point(20, 141);
            this.BtnCheckOnay.Name = "BtnCheckOnay";
            this.BtnCheckOnay.Size = new System.Drawing.Size(154, 23);
            this.BtnCheckOnay.TabIndex = 18;
            this.BtnCheckOnay.Text = "Çeki Onayla";
            this.BtnCheckOnay.UseVisualStyleBackColor = true;
            this.BtnCheckOnay.Click += new System.EventHandler(this.BtnCheckOnay_Click);
            // 
            // txtCheckBankId
            // 
            this.txtCheckBankId.Location = new System.Drawing.Point(20, 78);
            this.txtCheckBankId.MaxLength = 16;
            this.txtCheckBankId.Name = "txtCheckBankId";
            this.txtCheckBankId.Size = new System.Drawing.Size(154, 20);
            this.txtCheckBankId.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Çek Sahibi Adı:";
            // 
            // TxtCheckAd
            // 
            this.TxtCheckAd.Location = new System.Drawing.Point(20, 39);
            this.TxtCheckAd.Name = "TxtCheckAd";
            this.TxtCheckAd.Size = new System.Drawing.Size(154, 20);
            this.TxtCheckAd.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bank ID:";
            // 
            // FrmKullaniciPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 518);
            this.Controls.Add(this.panelBankCek);
            this.Controls.Add(this.panelNakit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnKart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKullaniciPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESU | ÖDEME SAYFASI";
            this.Load += new System.EventHandler(this.FrmKullaniciPay_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelKartOnay.ResumeLayout(false);
            this.panelKartOnay.PerformLayout();
            this.panelNakit.ResumeLayout(false);
            this.panelNakit.PerformLayout();
            this.panelBankCek.ResumeLayout(false);
            this.panelBankCek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnKartPanelOde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKartCvc;
        private System.Windows.Forms.TextBox TxtKartSahibiAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelKartOnay;
        private System.Windows.Forms.Button BtnOnayKoduOnay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOnayKodu;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbSktYil;
        private System.Windows.Forms.ComboBox CmbSktAy;
        private System.Windows.Forms.Panel panelNakit;
        private System.Windows.Forms.Button btnNakitOnay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelBankCek;
        private System.Windows.Forms.Button BtnCheckOnay;
        private System.Windows.Forms.TextBox txtCheckBankId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCheckAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtKartNumarasi;
    }
}