using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverView0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "+";

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                int suma = a + b;

                //txbRes.BackColor = Color.PaleGoldenrod;
                //txbRes.Width = 100;
                txbRes.Text = suma.ToString();           
            }

            catch(FormatException ex)
            {
                MessageBox.Show("¡Solo se adminten números", "ERROR");
                Console.Beep();

                //txbRes.BackColor = Color.Red;
                //txbRes.Width = 120;
                //txbRes.Text = "¡Solo números!";

                
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "-";

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                int resta = a - b;

                txbRes.Text = resta.ToString();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("¡Solo se adminten números", "ERROR");
                Console.Beep();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "*";

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                int producto = a * b;

                txbRes.Text = producto.ToString();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("¡Solo se adminten números", "ERROR");
                Console.Beep();

            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "/";

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                double cociente = (1.0*a / b);

                txbRes.Text = cociente.ToString();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("¡Solo se adminten números", "ERROR");
                Console.Beep();

            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "/";

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                double cociente = a % b;

                txbRes.Text = cociente.ToString();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("¡Solo se adminten números", "ERROR");
                Console.Beep();

            }
        }

      
    }
}
