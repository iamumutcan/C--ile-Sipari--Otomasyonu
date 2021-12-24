using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Siparis_Otomasyonu_Projesi
{
    class Kullanicilar
    {
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();

        public string KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciAdres { get; set; }
        public int KullaniciYoneticiMi { get; set; }

        public Kullanicilar()
        {
            // kurucu method oluşturdum çünkü ilk defa üye olacak kişiler yonetici olarak kayıt olmaması için
            this.KullaniciYoneticiMi = 0;
        }
        public void KullaniciKayitYap()
        {
            // this.KullaniciAd bu hazır veritabanına eklenebilir
            SqlCommand komut = new SqlCommand("insert into tbl_Kullanicilar(KullaniciAd,KullaniciSifre,KullaniciAdres,KullaniciYonetici) values (@p1,@p2,@p3,@p4)", bgl.baglanti()); // veritabanına ekleme işlemi
                
            komut.Parameters.AddWithValue("@p1", this.KullaniciAd); // parametrelere sınıftan alınan değerleri aktarıyor
            komut.Parameters.AddWithValue("@p2", this.KullaniciSifre); 
            komut.Parameters.AddWithValue("@p3", this.KullaniciAdres);
            komut.Parameters.AddWithValue("@p4", this.KullaniciYoneticiMi);
            komut.ExecuteNonQuery(); // sorguyu çalıştır
            bgl.baglanti().Close();

        }
        public void KullaniciGuncele()
        {

            SqlCommand komutguncelle = new SqlCommand("Update tbl_Kullanicilar set KullaniciAd=@a1,KullaniciSifre=@a2,KullaniciAdres=@a3,KullaniciYonetici=@a4 WHERE KullaniciId=@a0", bgl.baglanti()); // Guncelleme komutu
            komutguncelle.Parameters.AddWithValue("@a0", KullaniciId);
            komutguncelle.Parameters.AddWithValue("@a1", KullaniciAd); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a2", KullaniciSifre); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a3", KullaniciAdres);
            komutguncelle.Parameters.AddWithValue("@a4", KullaniciYoneticiMi);

            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void KullaniciSil()
        {
            SqlCommand komutsil = new SqlCommand("Delete From tbl_Kullanicilar Where KullaniciId=@k1", bgl.baglanti()); // silme komutu
            komutsil.Parameters.AddWithValue("@k1", KullaniciId);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
