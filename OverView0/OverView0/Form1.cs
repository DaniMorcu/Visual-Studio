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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
          

                int a = Convert.ToInt32(txb1.Text);
                int b = Convert.ToInt32(txb2.Text);
                int suma = a + b;

                txbSuma.BackColor = Color.PaleGoldenrod;
                txbSuma.Width = 100;
                txbSuma.Text = suma.ToString();           
            }

            catch(FormatException ex)
            {
                txbSuma.BackColor = Color.Red;
                txbSuma.Width = 150;
                txbSuma.Text = "¡Solo números, por favor!";
                Console.Beep();
                
            }
        }
    }
}
