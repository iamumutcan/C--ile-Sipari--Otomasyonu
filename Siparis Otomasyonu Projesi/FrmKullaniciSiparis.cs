using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyonu_Projesi
{
    public partial class FrmKullaniciSiparis : Form
    {
        public FrmKullaniciSiparis()
        {
            InitializeComponent();
        }
        public string OturumKullaniciAd;
        public int OturumKullaniciId;
        public float toplamFiyat=0;
        public int sayac = -1;
        Siparis _siparis = new Siparis();
        SiparisDetay _siparisDetay = new SiparisDetay();
        
        private void FrmKullaniciSiparis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerTablosuDataSet5.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter1.Fill(this.urunlerTablosuDataSet5.Tbl_Urun);
            // TODO: Bu kod satırı 'siparisOtomasyonuDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.siparisOtomasyonuDataSet.Tbl_Urun);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKullaniciPay GoFrm = new FrmKullaniciPay();
            GoFrm.OdenecekTutar = _siparis.SiparisTotalVergili;
            GoFrm.OturumKullaniciAd = OturumKullaniciAd;
            GoFrm.OturumKullaniciId = OturumKullaniciId;
            GoFrm.SipariKodu = _siparis.SiparisKod;
            string siparisdetayaciklama = "";
            string SepetDetay= "Ürünler: \n";
            for (int ucyi = 0; ucyi < listBox1.Items.Count; ucyi++)
            {
                siparisdetayaciklama += listBox1.Items[ucyi] + "\n";
            }
            siparisdetayaciklama+= "AraToplam: " + _siparis.SiparisTotal + " TL\n" + "Kdv Dahil: " + _siparis.SiparisTotalVergili + " TL";
            _siparis.SiparisDetayAciklama = siparisdetayaciklama;
            DateTime siparisTarihi = DateTime.Now;
            _siparis.SiparisTarih = siparisTarihi;
            _siparis.SiparisKullaniciId = OturumKullaniciId;
            MessageBox.Show("Sipariş Kodunuz:"+_siparis.SiparisKod+"\n"+
                "Tarih " + _siparis.SiparisTarih + "\n" +
                "Durum " +_siparis.SiparisDurum +"\n"+
                    "Tutar " + _siparis.SiparisTotalVergili + "\n" +
                    "Desi " + _siparis.SiparisAgirlik + "\n" +
                    "Detay " + _siparis.SiparisDetayAciklama + "\n" 
                            );
            
            _siparis.SiparisEkleToVT();
          //  MessageBox.Show(siparisdetayaciklama);
            GoFrm.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SepeteEkleFonk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SepeteEkleFonk();
            /*
           */

        }

        private void SepeteEkleFonk()
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            /* datagrid in sutunları
            0 UrunId GÖRÜNÜMÜ GİZLİ
            1 UrunAd
            2 UrunFiyat
            3 UrunAciklama
            4 UrunDesi GÖRÜNÜMÜ GİZLİ
            */
            float BirimFiyat = (float)Convert.ToDouble(dataGridView1.Rows[secilen].Cells[2].Value);
            int BirimAdet = (int)Convert.ToInt16(comboBox1.SelectedItem);
            float BirimAgirlik = (float)Convert.ToDouble(dataGridView1.Rows[secilen].Cells[4].Value);

            // ++ Enes button2 click
            Urun _urun = new Urun();
            sayac++;
            _urun.UrunFiyat = BirimFiyat;
            _siparisDetay.UrunMiktar = BirimAdet;
            _urun.UrunAgirlik = BirimAgirlik;
            _siparisDetay.AraToplam(_urun, sayac, _siparis);
            _siparisDetay.Agirlik(_urun, sayac, _siparis);

            // button1 click
            _siparis.ToplamFiyatHesapla(_siparisDetay, sayac);
            _siparis.BirimVergiHesapla();
            _siparis.agirlikhesapla(_siparisDetay);
            // - Enes
            toplamFiyat += _siparis.SiparisTotalVergili;
            listBox1.Items.Add(BirimAdet + " x " + dataGridView1.Rows[secilen].Cells[1].Value.ToString() + " " + BirimFiyat + " TL");
            label2.Text = "AraToplam: " + _siparis.SiparisTotal + " TL \n" + "Kdv Dahil: " + _siparis.SiparisTotalVergili + " TL";

            //
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKullanici GoFrm = new FrmKullanici();
            GoFrm.OturumKullaniciId = OturumKullaniciId;
            GoFrm.OturumKullaniciAd = OturumKullaniciAd;
            GoFrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _siparis.SepetTemizle();
            toplamFiyat = 0;
            label2.Text = "Ara toplam: \n KDV dahil:";
            MessageBox.Show("Sepetiniz boşaltıldı.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
