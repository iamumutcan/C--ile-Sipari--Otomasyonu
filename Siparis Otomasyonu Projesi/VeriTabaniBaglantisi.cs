using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Siparis_Otomasyonu_Projesi
{
    class VeriTabaniBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HRC1BT6\\;Initial Catalog=SiparisOtomasyonu;Integrated Security=True"); //Veri tabanına bağlanıyor
            baglan.Open();
            return baglan;
        }
    }
}
