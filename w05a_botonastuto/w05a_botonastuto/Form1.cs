using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w05a_botonastuto
{
    public partial class Form1 : Form
    {

        private Point[] listaPuntos = {new Point(10, 30), new Point(200, 250), new Point(95, 30), new Point(158, 203), new Point(30, 150), new Point(286, 103), new Point(98, 88)};

        int posicion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSi_MouseEnter(object sender, EventArgs e)
        {
            //int margenX = ClientSize.Height - 75;
            //int margenY = ClientSize.Width - 10;

            //Random rd = new Random();



            
            btnSi.Location = listaPuntos[posicion];
            posicion = (posicion + 1) % 7;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Le diste!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salir");
            this.Close();
        }
    }
}
