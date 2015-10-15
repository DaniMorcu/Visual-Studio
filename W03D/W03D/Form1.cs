using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03D
{
    public partial class Form1 : Form
    {
        private bool esRelleno;

        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //  Pen
            Pen boliRojo = new Pen(Color.Red, 2);
            Pen boliAzul = new Pen(Color.Blue, 4);

            //  Brochas
            Brush BrochaNaranja = new SolidBrush(Color.Orange);
            Brush BrochaAmarillo = new SolidBrush(Color.Yellow);

            Brush BrochaBlanca = new SolidBrush(Color.White);


            //  Margen 
            int margenX = ClientSize.Width / 15;
            int margenY = ClientSize.Width / 15;

            Size tamanioRect = new Size(ClientSize.Width - 2*margenX, ClientSize.Height - 2*margenY);

            Rectangle rect = new Rectangle(new Point(margenX, margenY), tamanioRect);

            //  Con bucle
            bool color= false;

            g.FillEllipse(BrochaNaranja, rect);
            for (int i = 0; i < 360; i += 60)
            {
                g.FillPie(BrochaAmarillo, rect, i, 30);

            }

            //  Forma con bucle
            //for (int i = 0; i < 360; i += 30)
            //{
            //    if(color)
            //        g.DrawArc(boliRojo, rect, i, 30);
            //    else
            //        g.DrawArc(boliAzul, rect, i, 30);

            //    color = !color;

            //}


            //Forma sencilla arco a arco
            //g.DrawArc(boliRojo, rect, 0, 30);
            //g.DrawArc(boliAzul, rect, 30, 30);
            //g.DrawArc(boliRojo, rect, 60, 90);
            //g.DrawArc(boliAzul, rect, 90, 30);
            //g.DrawArc(boliRojo, rect, 120, 30);
            //g.DrawArc(boliAzul, rect, 150, 30);
            //g.DrawArc(boliRojo, rect, 180, 30);
            //g.DrawArc(boliAzul, rect, 210, 30);
            //g.DrawArc(boliRojo, rect, 240, 30);
            //g.DrawArc(boliAzul, rect, 270, 30);
            //g.DrawArc(boliRojo, rect, 300, 30);
            //g.DrawArc(boliAzul, rect, 330, 30);


            if (esRelleno) 
            {
                for (int i = 0; i < 360; i += 30)
                {
                    if (color)
                        g.FillPie(BrochaNaranja, rect, i, 30);
                    else
                        g.FillPie(BrochaAmarillo, rect, i, 30);

                    color = !color;
                }

                btnRellenar.Text = "Vaciar";

                //g.FillPie(BrochaNaranja, rect, 0, 30);
                //g.FillPie(BrochaAmarillo, rect, 30, 30);
                //g.FillPie(BrochaNaranja, rect, 60, 30);
                //g.FillPie(BrochaAmarillo, rect, 90, 30);
                //g.FillPie(BrochaNaranja, rect, 120, 30);
                //g.FillPie(BrochaAmarillo, rect, 150, 30);
                //g.FillPie(BrochaNaranja, rect, 180, 30);
                //g.FillPie(BrochaAmarillo, rect, 210, 30);
                //g.FillPie(BrochaNaranja, rect, 240, 30);
                //g.FillPie(BrochaAmarillo, rect, 270, 30);
                //g.FillPie(BrochaNaranja, rect, 300, 30);
                //g.FillPie(BrochaAmarillo, rect, 330, 30);
            }

            else {
                g.FillPie(BrochaBlanca, rect, 0, 360);
                btnRellenar.Text = "Rellenar";
            }
            
            
            
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            esRelleno = !esRelleno;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
