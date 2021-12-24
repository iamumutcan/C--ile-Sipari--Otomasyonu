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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminUrun GoFrm = new FrmAdminUrun();
            GoFrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminKullanici GoFrm = new FrmAdminKullanici();
            GoFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAdminSiparis GoFrm = new FrmAdminSiparis();
            GoFrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            SqlCommand komutg1 = new SqlCommand("Select SiparisTarih,Avg(SiparisTutar) From tbl_Siparis Group By SiparisTarih", bgl.baglanti());
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Gunler"].Points.AddXY(dr1[0], dr1[1]);
            }
            bgl.baglanti().Close();

            SqlCommand komutg2 = new SqlCommand("Select Siparisdurum,Count(*) From tbl_Siparis Group By Siparisdurum", bgl.baglanti());
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Durum"].Points.AddXY(dr2[0], dr2[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
