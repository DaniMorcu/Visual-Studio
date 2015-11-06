using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficaSenoidal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  Cargamos valores en el comboBox
            cbGrosor.Items.Add(1);
            cbGrosor.Items.Add(1.5d);
            cbGrosor.Items.Add(2);
            cbGrosor.Items.Add(2.5d);
            cbGrosor.Items.Add(3);
            cbGrosor.Items.Add(3.5d);
            cbGrosor.Items.Add(4);
            cbGrosor.Items.Add(4.5d);
            cbGrosor.Items.Add(5);

            //  Valor por defecto en cbGrosor
            cbGrosor.SelectedIndex = 3;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Graphics gr = panelDibujo.CreateGraphics();

            //  Propiedades del trazo
            Color colorSelec = colorDialog1.Color;
            double grosorSelec = Convert.ToInt32(cbGrosor.SelectedItem);
            Pen boli = new Pen(colorSelec, (int)grosorSelec);
            Pen boliFino = new Pen(colorSelec, 2);
            
            //  Coordenadas
            int coordX = panelColor.Location.X;
            int coordY = panelColor.Size.Height/2;
            Point p = new Point(coordX, coordY);

            //  Amplitud
            int amplitud = trkbAmplitud.Value;

            //  Numero de ciclos
            double numCiclos = Convert.ToDouble(nudCiclos.Value);

            //  Ancho de pixeles
            int ancho = panelColor.Size.Width;

            //  Tabla de puntos
            Point[] puntos = new Point[501];

            int Y = 0;

            for (int i = 0; i < ancho; i++)
            {
                Y = (int) (amplitud  *  Math.Sin((i * numCiclos * 2 * Math.PI / ancho)));
                
                coordX += i; 
                coordY -= Y;
                puntos[i] = new Point(coordX , coordY);
            }


            gr.DrawLines(boli, puntos);

            // Puntos fijos para la linea horizontal
            Point p1 = new Point(0, (panelColor.Size.Height / 2));
            Point p2 = new Point(panelColor.Size.Width, panelColor.Size.Height / 2);

            // Eje de coordenadas X (linea horizontal)
            gr.DrawLine(boliFino, p1, p2);
        }

        private void trkbAmplitud_ValueChanged(object sender, EventArgs e)
        {
            int posicionY = 281 - ((trkbAmplitud.Value) * ( 281 - 46) / 400 );
            int posicionX = 63;
            //lbAmplitud.Location = new Point((int)posicionX, (int)posicionY);
            lbAmplitud.Location = new Point((int)posicionX, (int)posicionY);
            
            lbAmplitud.Text = Convert.ToString(trkbAmplitud.Value);
            lbAmplitud.Refresh();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            panelColor.BackColor = colorDialog1.Color;
            lblColor.ForeColor = colorDialog1.Color;
            
        }

     

   

    }
}
