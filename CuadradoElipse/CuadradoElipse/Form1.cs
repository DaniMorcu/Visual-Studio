using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadradoElipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            int margenX = 30;
            int margenY = 30;
            Point origen = new Point(ClientSize.Width/10, ClientSize.Width/10);
            Size tamanio = new Size((margenX*2 - ClientSize.Width),(margenY*2 - ClientSize.Height));

            Rectangle rect = new Rectangle(origen, tamanio);

            
            
        }
    }
}
