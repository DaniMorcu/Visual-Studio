using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = this.CreateGraphics();
            Pen boli = new Pen(Color.Red, 1);

            int margenX = ClientSize.Width/10;
            int margenY = ClientSize.Height/15;


            Point p1 = new Point(ClientSize.Width/2, margenY);
            Point p2 = new Point(ClientSize.Width - margenX, ClientSize.Height/3);
            Point p3 = new Point(ClientSize.Width - margenX, ClientSize.Height - margenY);
            Point p4 = new Point(margenX, ClientSize.Height - margenY);
            Point p5 = new Point(margenX, ClientSize.Height/3);



            Point [] matrizP = {p4, p5, p1, p2, p3, p5, p2, p4, p3};

            
            grafico.DrawLines(boli, matrizP);
        }
    }
}
