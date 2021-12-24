
namespace Siparis_Otomasyonu_Projesi
{
    partial class FrmKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKayitAd = new System.Windows.Forms.TextBox();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.TxtKayitAdres = new System.Windows.Forms.TextBox();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifreniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adresiniz:";
            // 
            // TxtKayitAd
            // 
            this.TxtKayitAd.BackColor = System.Drawing.Color.Linen;
            this.TxtKayitAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKayitAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitAd.ForeColor = System.Drawing.Color.Black;
            this.TxtKayitAd.Location = new System.Drawing.Point(16, 32);
            this.TxtKayitAd.Name = "TxtKayitAd";
            this.TxtKayitAd.Size = new System.Drawing.Size(171, 22);
            this.TxtKayitAd.TabIndex = 3;
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.BackColor = System.Drawing.Color.Linen;
            this.TxtKayitSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKayitSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitSifre.ForeColor = System.Drawing.Color.Black;
            this.TxtKayitSifre.Location = new System.Drawing.Point(16, 80);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(171, 22);
            this.TxtKayitSifre.TabIndex = 4;
            // 
            // TxtKayitAdres
            // 
            this.TxtKayitAdres.BackColor = System.Drawing.Color.Linen;
            this.TxtKayitAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKayitAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayitAdres.ForeColor = System.Drawing.Color.Black;
            this.TxtKayitAdres.Location = new System.Drawing.Point(16, 128);
            this.TxtKayitAdres.Multiline = true;
            this.TxtKayitAdres.Name = "TxtKayitAdres";
            this.TxtKayitAdres.Size = new System.Drawing.Size(171, 69);
            this.TxtKayitAdres.TabIndex = 5;
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnKayitYap.ForeColor = System.Drawing.Color.White;
            this.BtnKayitYap.Location = new System.Drawing.Point(16, 203);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(171, 23);
            this.BtnKayitYap.TabIndex = 6;
            this.BtnKayitYap.Text = "Kayıt Ol";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(209, 262);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.TxtKayitAdres);
            this.Controls.Add(this.TxtKayitSifre);
            this.Controls.Add(this.TxtKayitAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESU | KAYIT PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKayitAd;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.TextBox TxtKayitAdres;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}