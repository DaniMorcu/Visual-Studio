using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w02_WindowsForms
{
    public partial class FormPrueba : Form
    {
        Random rand = new Random(); //<--Para valores aleatorios

        public FormPrueba()
        {
            InitializeComponent();
            Text = "Dimensiones del formulario";
            BackColor = Color.White;
           //ResizeRedraw = true; // <-- Esto sustituye al método OnResize.... siguiente
        }

        //--- Este método se ha sustituído en el constructor por ResizeRedraw = true; 
        protected override void OnResize(EventArgs ea)
        {
            Invalidate();
        }

        protected override void OnMove(EventArgs ea)
        {
           Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pea)
        {

            Graphics grfx = pea.Graphics;

            if (this.Text.IndexOf("Colores") > 0)
            {
                //--- Colores Aletorios
                grfx.Clear(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
            }
            else
            {
                string texto = "\t   Localización: " + Location +
                "\n\t   Tamaño: " + Size +
                "\n\t   Bounds: " + Bounds +
                "\n\t   Ancho: " + Width +
                "\n\t   Alto: " + Height +
                "\n\t   Izquierda: " + Left +
                "\n\t   Superior: " + Top +
                "\n\t   Derecha: " + Right +
                "\n\t   Inferior: " + Bottom + "\n\n" +
                "\n\t   DesktopLocation: " + DesktopLocation +
                "\n\t   DesktopBounds: " + DesktopBounds + "\n\n" +
                "\n\t   Tamaño Cliente: " + ClientSize +
                "\n\t   Rectangulo Cliente: " + ClientRectangle;

                grfx.DrawString(texto, Font, Brushes.Black, 0, 20);
            }
        }

    }
}
