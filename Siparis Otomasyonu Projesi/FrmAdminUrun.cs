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
    public partial class FrmAdminUrun : Form
    {
        public FrmAdminUrun()
        {
            InitializeComponent();
        }

        private void FrmAdminUrun_Load(object sender, EventArgs e)
        {
            FonkDataGridListele();
        }
        public void FonkDataGridListele()
        {
            // TODO: Bu kod satırı 'siparisOtomasyonuDataSet3.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.siparisOtomasyonuDataSet3.Tbl_Urun);

        }
        private void MenuAdminAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAdmin GoFrm = new FrmAdmin();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminUrunler_Click(object sender, EventArgs e)
        {
            FrmAdminUrun GoFrm = new FrmAdminUrun();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminKullancilar_Click(object sender, EventArgs e)
        {
            FrmAdminKullanici GoFrm = new FrmAdminKullanici();
            GoFrm.Show();
            this.Hide();
        }

        private void MenuAdminSiparisler_Click(object sender, EventArgs e)
        {
            FrmAdminSiparis GoFrm = new FrmAdminSiparis();
            GoFrm.Show();
            this.Hide();
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunFiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunAciklama.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtUrunDesi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun _urun = new Urun();
            _urun.UrunAd = TxtUrunAd.Text;
            _urun.UrunTanim = TxtUrunAciklama.Text;
            float urungec= (float)Convert.ToDouble(TxtUrunFiyat.Text);
            _urun.UrunFiyat = urungec;          // değişecekkk
            _urun.UrunAgirlik = (float)Convert.ToDouble(TxtUrunDesi.Text);
            _urun.UrunEkle();
            FonkDataGridListele();
            MessageBox.Show("Ürün başarı ile eklendi.");
            


        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            Urun _urun = new Urun();
            _urun.UrunId = Convert.ToInt32(TxtUrunId.Text);
            _urun.UrunSil();
            FonkDataGridListele();
            MessageBox.Show("Kayıt Silindi");

        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            Urun _urun = new Urun();
            _urun.UrunId = Convert.ToInt32(TxtUrunId.Text);
            _urun.UrunAd = TxtUrunAd.Text;
            _urun.UrunTanim = TxtUrunAciklama.Text;
            float urungec = (float)Convert.ToDouble(TxtUrunFiyat.Text);
            _urun.UrunFiyat = urungec;          // değişecekkk
            _urun.UrunAgirlik = (float)Convert.ToDouble(TxtUrunDesi.Text);
            _urun.UrunGuncelle();
            FonkDataGridListele();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
