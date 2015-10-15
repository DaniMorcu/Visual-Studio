using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {


           

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grR;
            SolidBrush brocha = new SolidBrush(Color.Red);
            Pen trazo = new Pen(Color.Violet, 3);

            grR = e.Graphics;

            Point pSI = new Point(ClientSize.Width - (ClientSize.Width - 40),  (ClientSize.Height - (ClientSize.Height - 40)));
            Point pSD = new Point(ClientSize.Width - 40, ClientSize.Height - 40);
            Point pII = new Point(ClientSize.Width - (ClientSize.Width - 40), ClientSize.Height - 40);
            Point pID = new Point(ClientSize.Width - 40, ClientSize.Height - 40);
            
            //  Dibujando directamente con Graphics
            Rectangle rect = new Rectangle(pSI, new Size(//ancho, alto));


            

            //grR.FillRectangle(brocha, rect);
        }
    }
}
