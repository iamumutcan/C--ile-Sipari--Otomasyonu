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
    public partial class FrmKullaniciPay : Form
    {
        public FrmKullaniciPay()
        {
            InitializeComponent();
        }

        public float OdenecekTutar;
        public string DogrulamaKodu;
        public string SipariKodu;
        public string OturumKullaniciAd;
        public int OturumKullaniciId;
        private void FrmKullaniciPay_Load(object sender, EventArgs e)
        {
            label1.Text = "Sipariş Kodunuz: "+SipariKodu+"\nSepetinizin Toplamı: "+OdenecekTutar+"₺";
            label2.BackColor= Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;

        }
        public void PanelKapat()
        {
            panel2.Visible = false;
            panelBankCek.Visible = false;
            panelKartOnay.Visible = false;
            panelNakit.Visible = false;
        }
        private void BtnKart_Click(object sender, EventArgs e)
        {
            PanelKapat();
            panel2.Visible = true;
        }

        private void BtnKartPanelOde_Click(object sender, EventArgs e)
        {
          
            if(TxtKartSahibiAd.Text!=""&&TxtKartCvc.TextLength==3&& TxtKartNumarasi.TextLength==16&&CmbSktAy.Text!=""&CmbSktYil.Text!="")
            { 
            Kart _kart = new Kart();
           // _kart.Tutar = OdenecekTutar;
            _kart.KartSahibiAd = TxtKartSahibiAd.Text;
            _kart.KartNumarasi = Convert.ToDouble(TxtKartNumarasi.Text);
            string skttarih = CmbSktAy.Text + CmbSktYil.Text;
            _kart.SonkullanmaTarihi = Convert.ToInt32(skttarih);
            _kart.Cvc = Convert.ToInt32(TxtKartCvc.Text);
            _kart.OdemeMethodu(OdenecekTutar);
            DogrulamaKodu = _kart.DogrulamaKodu;
            FrmMobil GoFrm = new FrmMobil();
            GoFrm.DogrulamaKodu = _kart.DogrulamaKodu;
            GoFrm.OdenecekTutar = _kart.Tutar;
            GoFrm.Show();
            panelKartOnay.Visible = true;
            }

            else
            { MessageBox.Show("Kart Bilgilerinizi kontrol Ediniz"); }
        }

        private void BtnOnayKoduOnay_Click(object sender, EventArgs e)
        {

            Kart _kartOnay = new Kart();
            _kartOnay.DogrulamaKodu = DogrulamaKodu;
            _kartOnay.Authorized(TxtOnayKodu.Text);
            if(_kartOnay.DogrulamaOnay==true)
            {
                Siparis _siparis = new Siparis();
                _siparis.SiparisOdemeAlindiToVT(SipariKodu, "Ödeme Alındı");
                MessageBox.Show("Onaylandı");
                FrmKullanici GoFrm =new FrmKullanici();
                GoFrm.OturumKullaniciAd = OturumKullaniciAd;
                GoFrm.OturumKullaniciId = OturumKullaniciId;
                GoFrm.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Hatalı"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelKapat();
            panelNakit.Visible = true;
        }

        private void btnNakitOnay_Click(object sender, EventArgs e)
        {
            Nakit _nakitOnay = new Nakit();
            _nakitOnay.OdemeMethodu(OdenecekTutar);
            Siparis _siparis = new Siparis();
            _siparis.SiparisOdemeAlindiToVT(SipariKodu, "Ödeme Alınacak");
            MessageBox.Show("Kapıda ödeme yapacaksınız." +
                "Toplam tutar: " + _nakitOnay.NakitTeklif);
            FrmKullanici GoFrm = new FrmKullanici();
            GoFrm.OturumKullaniciAd = OturumKullaniciAd;
            GoFrm.OturumKullaniciId = OturumKullaniciId;
            GoFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelKapat();
            panelBankCek.Visible = true;
          
        }

        private void BtnCheckOnay_Click(object sender, EventArgs e)
        {
            Check _checkOnay = new Check();
            _checkOnay.OdemeMethodu(OdenecekTutar);
            _checkOnay.Authorized();
            if (_checkOnay.DogrulamaOnay == true)
            {
                Siparis _siparis = new Siparis();
                _siparis.SiparisOdemeAlindiToVT(SipariKodu, "Ödeme Alındı");
                MessageBox.Show("Onaylandı");
                FrmKullanici GoFrm = new FrmKullanici();
                GoFrm.OturumKullaniciAd = OturumKullaniciAd;
                GoFrm.OturumKullaniciId = OturumKullaniciId;
                GoFrm.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Hatalı"); }
        }
    }
}
