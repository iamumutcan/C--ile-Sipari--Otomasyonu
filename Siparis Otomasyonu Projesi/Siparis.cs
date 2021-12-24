using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Siparis_Otomasyonu_Projesi
{

    class Siparis
    {
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        // bir dizi oluşturup dizinin kaç kez çalıstıgını bır deıgskenle tutup 
        //siparis detayda her bır verı dızının bır elemanı olur
        public int SiparisId { get; set; }               // siparis kısmındakı metotlarda ise bu dızının veya lıstenın elmanları 
        public int SiparisKullaniciId { get; set; }    // siparisin hangi kullanıcı tarafından verildiğini görmek için
        public DateTime SiparisTarih { get; set; }       // toplanıp vergı hesaplanır
        public string SiparisDurum { get; set; }
        public float SiparisTotal { get; set; }
        public float SiparisAgirlik { get; set; }          //uruntotal*urunadet  sss
        public float SiparisTotalVergili { get; set; }
        public string SiparisDetayAciklama { get; set; }   // siparişte hangi ürünlerin kaç adet ve topam ücreti yazacak
        public string SiparisKod { get; set; }

        public float[] ToplamTutar = new float[30];
        public float[] ToplamAgirlik = new float[30];


        SiparisDetay _SiparisDetay = new SiparisDetay();
        public Siparis()
            {
            this.SiparisDurum = "Ödeme Bekliyor";
            // siparis kodu oluşturyorumz
            bool durum=true;
            while(durum==true)
            { 
            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(65, 91);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            SqlCommand komutkontrol = new SqlCommand("select * from tbl_siparis where SiparisKod=@kt1", bgl.baglanti());
            komutkontrol.Parameters.AddWithValue("@kt1", sb.ToString());
            SqlDataReader kt = komutkontrol.ExecuteReader();
            if(kt.Read())
            {

            }
                else
                {
                    durum = false;
                    SiparisKod = sb.ToString();
                }
            }
            
        }
        public float BirimVergiHesapla()
        {
            SiparisTotalVergili = SiparisTotal + (SiparisTotal * SiparisDetay.VergiYuzdesi);
            return SiparisTotalVergili;
        }
        public float ToplamFiyatHesapla(SiparisDetay s, int sayac)
        {
            SiparisTotal = 0;
            foreach (int eleman in ToplamTutar)
            { SiparisTotal += eleman; }
            return SiparisTotal;
        }

        public float agirlikhesapla(SiparisDetay s)
        {
            SiparisAgirlik = 0;
            foreach (int elemanagirlik in ToplamAgirlik)
            { SiparisAgirlik += elemanagirlik; }

            return SiparisAgirlik;
        }
      

        public void SepetTemizle()
        {
            Array.Clear(ToplamTutar, 0, ToplamTutar.Length);
            Array.Clear(ToplamAgirlik, 0, ToplamAgirlik.Length);

        }

        // Umut can
        public void SiparisEkleToVT()
        {
           
            SqlCommand komut = new SqlCommand("insert into tbl_Siparis(SiparisDurum,SiparisTutar,SiparisDesi,SiparisDetay,SiparisKullaniciId,SiparisTarih,SiparisKod) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti()); // veritabanına ekleme işlemi

            komut.Parameters.AddWithValue("@p1", this.SiparisDurum); // parametrelere sınıftan alınan değerleri aktarıyor
            komut.Parameters.AddWithValue("@p2", this.SiparisTotalVergili);
            komut.Parameters.AddWithValue("@p3", this.SiparisAgirlik);
            komut.Parameters.AddWithValue("@p4", this.SiparisDetayAciklama);
            komut.Parameters.AddWithValue("@p5", this.SiparisKullaniciId);
            komut.Parameters.AddWithValue("@p6", this.SiparisTarih);
            komut.Parameters.AddWithValue("@p7", this.SiparisKod);
            komut.ExecuteNonQuery(); // sorguyu çalıştır
            bgl.baglanti().Close();
        }
        public void SiparisGuncelleToVT()
        {
            SqlCommand komutguncelle = new SqlCommand("Update tbl_Siparis set SiparisDurum=@a1,SiparisTutar=@a2,SiparisDesi=@a3,SiparisDetay=@a4,SiparisTarih=@a5,SiparisKod=@a6 WHERE SiparisId=@a0", bgl.baglanti()); // Guncelleme komutu
            komutguncelle.Parameters.AddWithValue("@a0", SiparisId);
            komutguncelle.Parameters.AddWithValue("@a1", SiparisDurum); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a2", SiparisTotalVergili); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a3", SiparisAgirlik);
            komutguncelle.Parameters.AddWithValue("@a4", SiparisDetayAciklama);
            komutguncelle.Parameters.AddWithValue("@a5", SiparisTarih);
            komutguncelle.Parameters.AddWithValue("@a6", SiparisKod);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void SiparisOdemeAlindiToVT(string Skod,string OdemeAlindiMi)
        {
            SqlCommand komutguncelle = new SqlCommand("Update tbl_Siparis set SiparisDurum=@c1 WHERE SiparisKod=@c0", bgl.baglanti()); // Guncelleme komutu
            komutguncelle.Parameters.AddWithValue("@c1", OdemeAlindiMi);
            komutguncelle.Parameters.AddWithValue("@c0", Skod);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void SiparisSilToVT()
        {
            SqlCommand komutsil = new SqlCommand("Delete From tbl_Siparis Where SiparisId=@k1", bgl.baglanti()); // silme komutu
            komutsil.Parameters.AddWithValue("@k1", SiparisId);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
   

    }
    class SiparisDetay : Urun
    {
        public const float VergiYuzdesi = 0.18f;
        public int UrunMiktar { get; set; }
        public float Fiyat { get; set; }                  //geçici değişken
        public float Agirlik1 { get; set; }          //geçici değişken

        public float AraToplam(Urun u, int sayac, Siparis TT)
        {
            Fiyat = u.UrunFiyat * UrunMiktar;
            TT.ToplamTutar[sayac] = Fiyat;
            return Fiyat;
        }
        public float Agirlik(Urun s, int sayac, Siparis TA)
        {
            Agirlik1 = UrunMiktar * s.UrunAgirlik;
            TA.ToplamAgirlik[sayac] = Agirlik1;
            return Agirlik1;
        }
        public float AraToplamCikar(Urun u, int sayac, Siparis TT)
        {
            Fiyat = u.UrunFiyat * UrunMiktar;
            TT.ToplamTutar[sayac] = Fiyat;
            return Fiyat;
        }
        public float AgirlikCikar(Urun s, int sayac, Siparis TA)
        {
            Agirlik1 = UrunMiktar * s.UrunAgirlik;
            TA.ToplamAgirlik[sayac] = Agirlik1;
            return Agirlik1;
        }
    }
}
