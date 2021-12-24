using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Siparis_Otomasyonu_Projesi
{
    class Urun
    {
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public float UrunFiyat { get; set; }
        public string UrunTanim { get; set; }                 //urun acıklaması 
        public float UrunAgirlik { get; set; }

        public void UrunEkle()
        {
            // this.KullaniciAd bu hazır veritabanına eklenebilir
            SqlCommand komut = new SqlCommand("insert into tbl_Urun(UrunAd,UrunFiyat,UrunAciklama,UrunDesi) values (@p1,@p2,@p3,@p4)", bgl.baglanti()); // veritabanına ekleme işlemi

            komut.Parameters.AddWithValue("@p1", this.UrunAd); // parametrelere sınıftan alınan değerleri aktarıyor
            komut.Parameters.AddWithValue("@p2", this.UrunFiyat);
            komut.Parameters.AddWithValue("@p3", this.UrunTanim);
            komut.Parameters.AddWithValue("@p4", this.UrunAgirlik);
            komut.ExecuteNonQuery(); // sorguyu çalıştır
            bgl.baglanti().Close();
        }
        public void UrunSil()
        {
            SqlCommand komutsil = new SqlCommand("Delete From tbl_Urun Where UrunId=@k1", bgl.baglanti()); // silme komutu
            komutsil.Parameters.AddWithValue("@k1", UrunId);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void UrunGuncelle()
        {
            SqlCommand komutguncelle = new SqlCommand("Update tbl_Urun set UrunAd=@a1,UrunFiyat=@a2,UrunAciklama=@a3,UrunDesi=@a4 WHERE UrunId=@a0", bgl.baglanti()); // Guncelleme komutu
            komutguncelle.Parameters.AddWithValue("@a0", UrunId);
            komutguncelle.Parameters.AddWithValue("@a1", UrunAd); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a2", UrunFiyat); // parametrelere formdan alınan değerleri aktarıyor
            komutguncelle.Parameters.AddWithValue("@a3", UrunTanim);
            komutguncelle.Parameters.AddWithValue("@a4", UrunAgirlik);

            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
