using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_CasoPractico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            bool esSalida = true;
            while (esSalida)
            {
                DialogResult ds;
                ds = MessageBox.Show("Nunca haces casos.\n\t¿Quieres intentarlo de nuevo?", "¡Error!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
          
                if (ds == DialogResult.Yes) //  Limpiamos las cajas de textos
                {

                    MessageBox.Show("Recuerda de no pulsarlo");
                    MessageBox.Show("¡No es tan complicado!");
                }

                else if (ds == DialogResult.No)
                {
                    MessageBox.Show("¡Tampoco es tan dificil!", ":_(");
                }

                else
                {
                    MessageBox.Show("Pues nada, hasta otra", "Chao");
                    esSalida = false;
                    this.Close(); //  Nos salimos de la App
                }
            }
          
        }
    }
}
