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
                txbSuma.Text = suma.ToString();           
            }

            catch(FormatException ex)
            {
                DialogResult ds;
                ds = MessageBox.Show("Por favor, solo se admiten números.\n\t¿Quieres intentarlo de nuevo?", "¡Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (ds == DialogResult.Yes) //  Limpiamos las cajas de textos
                {
                    txb1.Text = String.Empty;
                    txb2.Clear();
                    txbSuma.ResetText();
                    txb1.Focus();   //  Hacemos que el foco se coloque en la caja uno
                }

                else
                {
                    this.Close(); //  Nos salimos de la App
                }
                   

            }
        }
    }
}
