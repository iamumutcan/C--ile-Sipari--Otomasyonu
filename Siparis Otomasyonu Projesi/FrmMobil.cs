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
    public partial class FrmMobil : Form
    {
        public FrmMobil()
        {
            InitializeComponent();
        }
        public float OdenecekTutar;
        public string DogrulamaKodu;

        private void FrmMobil_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            
            label1.BackColor = Color.Transparent;
            label1.Text = "AESU mağazasından yaptığınız alış- \n veriş " +
                          "için: " + OdenecekTutar + " TL kartınızdan \n" +
                          "tahsil edilcektir Onay Kodunuz: " + DogrulamaKodu + 
                          "\n kimse ile paylaşmayınız. B012";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
