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
    public partial class FrmAdminSiparis : Form
    {
        public FrmAdminSiparis()
        {
            InitializeComponent();
        }

        private void FrmAdminSiparis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'siparisTablosuV3.Tbl_Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'siparistablosuKodlu.Tbl_Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            FonkDataGridListele();

        }
        public void FonkDataGridListele()
        {
            this.tbl_SiparisTableAdapter4.Fill(this.siparisTablosuV3.Tbl_Siparis);
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

        private void BtnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            Siparis _siparis = new Siparis();
            _siparis.SiparisId = Convert.ToInt32(TxtSiparisId.Text);
            _siparis.SiparisDurum = CmbSiparisDurum.Text;
            _siparis.SiparisTotalVergili = (float)Convert.ToDouble(TxtSiparisFiyat.Text);
            _siparis.SiparisAgirlik = (float)Convert.ToDouble(TxtSiparisDesi.Text);
            _siparis.SiparisTarih = Convert.ToDateTime(DateTimeSiparis.Value);
            _siparis.SiparisDetayAciklama = txtDetay.Text;
            _siparis.SiparisKod = TxtSiparisKod.Text;
            _siparis.SiparisGuncelleToVT();
            FonkDataGridListele();
            MessageBox.Show("Sipariş Güncellenmiştir");


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
        
            TxtSiparisId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSiparisKod.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            DateTimeSiparis.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[3].Value);
            CmbSiparisDurum.SelectedItem = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSiparisFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSiparisDesi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtDetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnSiparisSil_Click(object sender, EventArgs e)
        {
            Siparis _siparis = new Siparis();
            _siparis.SiparisId = Convert.ToInt32(TxtSiparisId.Text);
            _siparis.SiparisSilToVT();
            FonkDataGridListele();
            MessageBox.Show("Sipariş Silinmiştir");
        }

        private void BtnCikisYap_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnSiparisListele_Click(object sender, EventArgs e)
        {
            FonkDataGridListele();
        }
    }
}
