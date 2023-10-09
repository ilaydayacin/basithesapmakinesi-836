using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çarpma_bölme_topla_çıkar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(txtSayi1.Text);
            Double sayi2 = Convert.ToDouble(txtSayi2.Text);

            if (rbTopla.Checked)
            {
                lblSonuc.Text = "Sonuç: " + Convert.ToString(sayi1 + sayi2);
            }
            else if (rbCikar.Checked)
            {
                lblSonuc.Text = "Sonuç: " + Convert.ToString(sayi1 - sayi2);
            }
            else if (rbCarp.Checked)
            {
                lblSonuc.Text = "Sonuç: " + Convert.ToString(sayi1 * sayi2);
            }

            else if (rbBol.Checked)
            {
                lblSonuc.Text = "Sonuç: " + Convert.ToString(sayi1 / sayi2);
            }
        }
    }
}
