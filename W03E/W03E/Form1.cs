using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //  Pen
            Pen boli = new Pen(Color.Red, 2);

            //  Variables
            int numVertices = 5;

            //  Márgenes
            int margenX = ClientSize.Width / 15;
            int margenY = ClientSize.Width / 12;

            //  Punto y tamaño para formar el rectángulo
            Point localizacion = new Point(margenX, margenY);
            Size tamanioRect = new Size(ClientSize.Width - 2* margenX, ClientSize.Height - 2* margenY);          

            Rectangle rect = new Rectangle(localizacion, tamanioRect);
            
            //  Comprobamos el espacio del rectángulo
            //g.DrawRectangle(boli, rect);

            //  Array de puntos
            Point[] listPuntos = null;

            //  Angulo base en radianes
            double anguloBase = 360 / numVertices * (Math.PI / 180);
            double angulo = 0;

            //  Radio
            int radio = 1;

            //  Coordenadas
            double CoodX = 0;
            double CoodY = 0;
            double CoodXcentro = ClientSize.Width / 2;
            double CoodYcentro = ClientSize.Height / 2;

   

            for (int i = 0; i < numVertices; i++)
            {
                angulo = 2 * i * anguloBase;

                CoodX = (int)(radio * Math.Cos(angulo)) + CoodXcentro;
                CoodY = (int)(radio * Math.Sin(angulo)) + CoodYcentro;

                listPuntos[i] = new Point((int)CoodX, (int)CoodY);
            }

            g.DrawPolygon(boli, listPuntos);
        }
    }
}
