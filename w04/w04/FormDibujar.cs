using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04
{
    public partial class FormDibujar : Form
    {

        //  Este formulario lo usaremos para dibujar las distintas acciones corresponiendete 
        //  al botón pulsado


        public FormDibujar()
        {
            InitializeComponent();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //  Con el evento MouseOver nos pasa un parámetro e que con las propiedades
            //  X e Y localizamos en cada movimiento su posición

            //  Posicion del cursor en cada momento
            Point posCursor = new Point(e.X, e.Y);
            
            Graphics g = CreateGraphics();

            switch (this.Text)
            {
                case "Raton Araña 1":
                    //  Para limpiar el g con el color del fondo
                    g.Clear(BackColor);

                   
                    break;

                case "Raton Araña 2":
                    break;
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (this.Text)
            {
                case
            }
        }

        void PintarAranya(Graphics g, Pen boli, Point posicion)
        {
            int anchoX = ClientSize.Width, altoY = ClientSize.Height;

            //  Tenemos que calcular los puntos donde parten las lineas de cada
            //  lado del formulario.
        }

      

    }
}
