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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            Kullanicilar KulKayit = new Kullanicilar(); // musteri nesnesini oluşturdum
            KulKayit.KullaniciAd = TxtKayitAd.Text; // musteri nesnesini nesnesine parametreleri gönderiyorum
            KulKayit.KullaniciSifre = TxtKayitSifre.Text;
            KulKayit.KullaniciAdres = TxtKayitAdres.Text;
            KulKayit.KullaniciKayitYap(); // musteri kaydı yapmak için musteri nesnesinde kayıt methodunu çalıştırdım
            MessageBox.Show("Başarı ile kayıt oldunuz");
            this.Close();
        }
    }
}
