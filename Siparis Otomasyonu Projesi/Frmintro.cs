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
    public partial class Frmintro : Form
    {
        public Frmintro()
        {
            InitializeComponent();
        }

        private void Frmintro_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FrmGiris GoFrm = new FrmGiris();
            GoFrm.Show();
            this.Hide();
        }
    }
}
