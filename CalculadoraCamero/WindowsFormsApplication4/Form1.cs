using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  Este controlador de eventos lo usaré para todos los botones
        private void Operador_Click(object sender, EventArgs e)
        {
            string operacion = ((Button)sender).Text;

            int s1 = 0, s2 = 0;
            double resultado = 0;
            try 
            {
                s1 = Convert.ToInt32(txb1.Text);
                s2 = Convert.ToInt32(txb2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("¡¡Solo acepto numeros enteros!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch(operacion)
            {
                case "Sumar": 
                    lblOperacion.Text = "+";
                    resultado = s1 + s2;
                    break;
                case "Restar":
                    lblOperacion.Text = "-";
                    resultado = s1 - s2;
                    break;
                case "Multiplicar":
                    lblOperacion.Text = "x";
                    resultado = s1 * s2;
                    break;
                case "Dividir":
                    lblOperacion.Text = "/";
                    resultado = (1.0)*(s1 / s2);    //  Casteamos el resultado a decimales
                    break;
                case "Modulo":
                    lblOperacion.Text = "%";
                    resultado = s1 % s2;
                    break;
            }

            txbRes.Text = resultado.ToString();

        }

       
    }
}
