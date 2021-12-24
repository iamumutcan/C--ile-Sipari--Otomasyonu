using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Otomasyonu_Projesi
{
    abstract class Odeme
    {
        public float Tutar { get; set; }
        public abstract void OdemeMethodu(float GelenTutar);

    }
    class Kart : Odeme
    {

        public double KartNumarasi { get; set; }
        public string KartSahibiAd { get; set; }
        public int Cvc { get; set; }
        public int SonkullanmaTarihi { get; set; }
        public string DogrulamaKodu { get; set; }
        public bool DogrulamaOnay { get; set; }
        
            
        public Kart()
        {
            Random rastgele = new Random();
            int dogras = rastgele.Next(99999, 1000000);
            DogrulamaKodu = Convert.ToString(dogras);
        }
     
        public override void OdemeMethodu(float GelenTutar)
        {
            Tutar = GelenTutar;
        }
        public void  Authorized(string GelenKod)
        {
            if(DogrulamaKodu==GelenKod)
            {
                DogrulamaOnay = true;
            }
            else
            {
                DogrulamaOnay = false;
            }
        }
       
    }

    class Nakit : Odeme
    {
        public float NakitTeklif { get; set; }
        public override void OdemeMethodu(float GelenTutar)
        {
            Tutar = GelenTutar;
            NakitTeklif = GelenTutar+12; // +12kapıda ödeme tutarı
        }
      
    }
    class Check : Odeme
    {
        public string Ad { get; set; }
        public double BankaID { get; set; }
        public bool DogrulamaOnay { get; set; }
        public override void OdemeMethodu(float GelenTutar)
        {
            Tutar = GelenTutar;
        }
        public void Authorized()
        {
            DogrulamaOnay = true; 
        }
    }
}
