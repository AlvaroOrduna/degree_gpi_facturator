using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Facturator
{
    public partial class Facturacion : Form
    {
        HashSet<KeyValuePair<string, double>> products = new HashSet<KeyValuePair<string, double>> ();

        public Facturacion()
        {
            InitializeComponent();

            products.Add(new KeyValuePair<string, double>("Calzoncillos", 3.49));
            products.Add(new KeyValuePair<string, double>("Pantalón", 23));
            products.Add(new KeyValuePair<string, double>("Camiseta", 5.98));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1label.Text = products.ElementAt(0).Key.ToString() + " (" +
                products.ElementAt(0).Value.ToString() + " €)";
            p2label.Text = products.ElementAt(1).Key.ToString() + " (" +
                products.ElementAt(1).Value.ToString() + " €)";
            p3label.Text = products.ElementAt(2).Key.ToString() + " (" +
                products.ElementAt(2).Value.ToString() + " €)";
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

            double[] prices = {
                products.ElementAt(0).Value,
                products.ElementAt(1).Value,
                products.ElementAt(2).Value
            };
            double p1q, p2q, p3q;
            double noIva;

            if (p1quantity.Text.Equals(""))
                p1q = 0f;
            else
                p1q = double.Parse(p1quantity.Text);
            if (p2quantity.Text.Equals(""))
                p2q = 0f;
            else
                p2q = double.Parse(p2quantity.Text);
            if (p3quantity.Text.Equals(""))
                p3q = 0f;
            else
                p3q = double.Parse(p3quantity.Text);

            noIva = (p1q * prices[0] + p2q * prices[1] + p3q * prices[2]);
            sinIva.Text = noIva.ToString();
            totalPriceLabel.Text = ((noIva * 0.21) + noIva).ToString();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            double[] prices = {
                products.ElementAt(0).Value,
                products.ElementAt(1).Value,
                products.ElementAt(2).Value
            };
            double p1q, p2q, p3q, totalSinIva, totalConIva;

            if (p1quantity.Text.Equals(""))
                p1q = 0f;
            else
                p1q = double.Parse(p1quantity.Text);
            if (p2quantity.Text.Equals(""))
                p2q = 0f;
            else
                p2q = double.Parse(p2quantity.Text);
            if (p3quantity.Text.Equals(""))
                p3q = 0f;
            else
                p3q = double.Parse(p3quantity.Text);

            totalSinIva = (p1q * prices[0] + p2q * prices[1] + p3q * prices[2]);
            totalConIva = (totalSinIva * 1.21);

            PdfDocument pdf = new PdfDocument();
            PdfPage page = pdf.AddPage();

            XGraphics graphs = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Verdana", 24, XFontStyle.Bold);
            XFont bodyFont = new XFont("Verdana", 16, XFontStyle.Regular);

            // Titulo
            graphs.DrawString("Facturator\n", titleFont, XBrushes.Black,
                new XRect(0, 0, page.Width.Point, page.Height.Point),
                XStringFormats.TopCenter);

            // Productos
            String line1 = products.ElementAt(0).Key.ToString() +
                " (" + prices[0] + " €) x " +
                p1quantity.Text + "\n";
            graphs.DrawString(line1, bodyFont, XBrushes.Black,
                new XRect(40, 40, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);

            String line2 = products.ElementAt(1).Key.ToString() +
                " (" + prices[1] + " €) x " +
                p2quantity.Text + "\n";
            graphs.DrawString(line2, bodyFont, XBrushes.Black,
                new XRect(40, 80, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);

            String line3 = products.ElementAt(2).Key.ToString() +
                " (" + prices[2] + " €) x " +
                p3quantity.Text + "\n";
            graphs.DrawString(line3, bodyFont, XBrushes.Black,
                new XRect(40, 120, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);

            String line4 = "Precio total sin IVA: " + totalSinIva + " €";
            graphs.DrawString(line4, bodyFont, XBrushes.Black,
                new XRect(40, 160, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);

            String line5 = "Precio total con IVA: " + totalConIva + " €";
            graphs.DrawString(line5, bodyFont, XBrushes.Black,
                new XRect(40, 200, page.Width.Point, page.Height.Point),
                XStringFormats.TopLeft);

            pdf.Save("D:\\Álvaro\\Escritorio\\factura.pdf");
        }
    }
}
