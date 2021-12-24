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

namespace Siparis_Otomasyonu_Projesi
{
    public partial class FrmAdminKullanici : Form
    {
        public FrmAdminKullanici()
        {
            InitializeComponent();
        }
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        void ListeleDataGrid() // TODO: Bu kod satırı 'siparisOtomasyonuDataSet2.Tbl_Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        {
            this.tbl_KullanicilarTableAdapter.Fill(this.siparisOtomasyonuDataSet2.Tbl_Kullanicilar);
        }
        void Temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSifre.Text = "";
            TxtAdres.Text = "";
            checkBoxYoneticiMi.Checked = false;
        }
        private void FrmAdminKullanici_Load(object sender, EventArgs e)
        {
            ListeleDataGrid();
           
        }

        private void MenuAdminAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin GoFrm = new FrmAdmin();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminUrunler_Click(object sender, EventArgs e)
        {
            FrmAdminUrun GoFrm = new FrmAdminUrun();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminKullancilar_Click(object sender, EventArgs e)
        {
            FrmAdminKullanici GoFrm = new FrmAdminKullanici();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminSiparisler_Click(object sender, EventArgs e)
        {
            FrmAdminSiparis GoFrm = new FrmAdminSiparis();
            GoFrm.Show();
            this.Hide();
        }

        private void BtnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar _kullanicilar = new Kullanicilar();
            _kullanicilar.KullaniciAd = TxtAd.Text;
            _kullanicilar.KullaniciId = Txtid.Text;
            _kullanicilar.KullaniciAdres = TxtAdres.Text;
            _kullanicilar.KullaniciSifre = TxtSifre.Text;
            if(checkBoxYoneticiMi.Checked==true)
            {
                _kullanicilar.KullaniciYoneticiMi = 1;
            }
            else
            {
                _kullanicilar.KullaniciYoneticiMi = 0;
            }
            _kullanicilar.KullaniciGuncele();
            ListeleDataGrid();
            MessageBox.Show("Id:{0} Kullanıcı güncellendi", Txtid.Text);
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if(dataGridView1.Rows[secilen].Cells[4].Value.ToString()=="True")
            {
                checkBoxYoneticiMi.Checked = true;
            }
            else
            {
                checkBoxYoneticiMi.Checked = false;
            }
        }

        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if(Txtid.Text=="")
            { 
            Kullanicilar _kullanicilar = new Kullanicilar(); // musteri nesnesini oluşturdum
            _kullanicilar.KullaniciAd = TxtAd.Text; // musteri nesnesini nesnesine parametreleri gönderiyorum
            _kullanicilar.KullaniciSifre = TxtSifre.Text;
            _kullanicilar.KullaniciAdres = TxtAdres.Text;
            if (checkBoxYoneticiMi.Checked == true)
            {
              _kullanicilar.KullaniciYoneticiMi = 1;
            }
            _kullanicilar.KullaniciKayitYap(); // musteri kaydı yapmak için musteri nesnesinde kayıt methodunu çalıştırdım
            MessageBox.Show("Müşteri başarı ile kayıt edilmiştir.");
            ListeleDataGrid();
            Temizle();
            }
            else
            {
                MessageBox.Show("KULLANICI ID SİSTEM TARAFINDAN OTOMATİK VERİLMEKTEDİR LÜTFEN BOŞ BIRAKINIZ.");
            }
        }

        private void BtnKullaniciSil_Click(object sender, EventArgs e)
        {
            Kullanicilar _kullanicilar = new Kullanicilar(); // musteri nesnesini oluşturdum
            _kullanicilar.KullaniciId = Txtid.Text;
            _kullanicilar.KullaniciSil();
            MessageBox.Show("Müşteri başarı ile silinmiştir.");
            ListeleDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
