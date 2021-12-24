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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }
        public string OturumKullaniciAd;
        public int OturumKullaniciId;
        VeriTabaniBaglantisi bgl = new VeriTabaniBaglantisi();
        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siparisTablosuV3.Tbl_Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SiparisTableAdapter2.Fill(this.siparisTablosuV3.Tbl_Siparis);
            // TODO: Bu kod satırı 'siparisTablosuDataSet5.Tbl_Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_SiparisTableAdapter1.Fill(this.siparisTablosuDataSet5.Tbl_Siparis);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Siparis where SiparisKullaniciId=" + OturumKullaniciId, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullaniciSiparis GoFrm = new FrmKullaniciSiparis();
            GoFrm.OturumKullaniciId = OturumKullaniciId;
            GoFrm.OturumKullaniciAd = OturumKullaniciAd;
            GoFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
        
            MessageBox.Show("Sipariş kodunuz: "+ dataGridView1.Rows[secilen].Cells[0].Value+
               "\nSipariş Tarihiniz: " + dataGridView1.Rows[secilen].Cells[1].Value +
               "\nSipariş Durumunuz: " + dataGridView1.Rows[secilen].Cells[2].Value +
               "\nSipariş Tutarınız: " + dataGridView1.Rows[secilen].Cells[3].Value +
               "\nSipariş Desiniz: " + dataGridView1.Rows[secilen].Cells[4].Value +
               "\nSipariş Ürünleriniz: " + dataGridView1.Rows[secilen].Cells[5].Value);
        }
    }
}
