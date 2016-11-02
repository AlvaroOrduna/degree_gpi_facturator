using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturator
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p2quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {

            float[] prices = { 1, 1, 1 };
            float p1q, p2q, p3q;
            if (p1quantity.Text.Equals(""))
                p1q = 0f;
            else
                p1q = float.Parse(p1quantity.Text);
            if (p2quantity.Text.Equals(""))
                p2q = 0f;
            else
                p2q = float.Parse(p2quantity.Text);
            if (p3quantity.Text.Equals(""))
                p3q = 0f;
            else
                p3q = float.Parse(p3quantity.Text);
            float noIva;
            noIva = (p1q * prices[0] + p2q * prices[1] + p3q * prices[2]);
            sinIva.Text = noIva.ToString();
            totalPriceLabel.Text = ((noIva * 0.21) + noIva).ToString();
        }
    }
}
