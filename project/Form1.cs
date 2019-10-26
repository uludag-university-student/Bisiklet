using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {

            if (colorDilagBiskletRengi.ShowDialog() == DialogResult.OK)
            {
                txtRenkAdi.BackColor = colorDilagBiskletRengi.Color;
                txtRenkAdi.Text = colorDilagBiskletRengi.Color.ToString();
            }
        }

        private void btnCalsitir_Click(object sender, EventArgs e)
        {
            Bisiklet bisiklet = new Bisiklet();
            bisiklet.Renk = txtRenkAdi.BackColor;
            bisiklet.TekerlekSayisi = int.Parse(txtTekerlekSayisi.Text);
            bisiklet.BisikletHizi = int.Parse(txtBisikletHizi.Text);
            bisiklet.TavsiyeEdermisin = txtTavsiyeEdermisin.Text;








            txtBisikletInfo.Text = bisiklet.BisikletInfo();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void BisikletTipi_Click(object sender, EventArgs e)
        {

        }
    }
}
