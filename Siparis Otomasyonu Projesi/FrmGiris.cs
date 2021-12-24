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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            // kulanici girişi
            // ++ Kullanıcı Paneline Gönderiyor
           
            SqlCommand komut = new SqlCommand("Select * FROM tbl_Kullanicilar where kullaniciAd=@p1 and KullaniciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", GirisKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", GirisKullaniciSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmKullanici GoFrm = new FrmKullanici();
                GoFrm.OturumKullaniciId = Convert.ToInt16(dr[0]);
                GoFrm.OturumKullaniciAd = Convert.ToString(dr[1]);
                GoFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();

            // -- Kullanıcı Paneline Gönderiyor

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kayit olma formuna yönlendiriyor
            FrmKayit GoFrm = new FrmKayit();
            GoFrm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
           
            // ++ Admin Paneline Gönderiyor
            SqlCommand komut2 = new SqlCommand("Select * FROM tbl_Kullanicilar where kullaniciAd=@p1 and KullaniciSifre=@p2 and KullaniciYonetici=1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", GirisKullaniciAd.Text);
            komut2.Parameters.AddWithValue("@p2", GirisKullaniciSifre.Text);

            SqlDataReader dry = komut2.ExecuteReader();
            if (dry.Read())
            {
                FrmAdmin GoFrm = new FrmAdmin();
                GoFrm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş \n veya Admin değilsiniz");
            }
            bgl.baglanti().Close();
            // -- Admin Paneline Gönderiyor
        }
    }
}
