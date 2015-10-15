using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoCentrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true; // Con esto hacemos que se llame al OnPaint cuando redimensione
            
        }


        protected override void OnPaint(PaintEventArgs pea)
        {
            Point ptoCentral = new Point(this.ClientSize.Width / 2 , this.ClientSize.Height / 2);
            Graphics grfx = pea.Graphics;

            StringFormat formatoCentral = new StringFormat();
            StringFormat formatoSuperiorIzq = new StringFormat();
            StringFormat formatoSuperiorDer = new StringFormat();
            StringFormat formatoInferiorIzq = new StringFormat();
            StringFormat formatoInferiorDer = new StringFormat();

            formatoCentral.Alignment = StringAlignment.Center; //  Alineamiento horizontal
            formatoCentral.LineAlignment = StringAlignment.Center; //  Alineamiento Vertical

            formatoSuperiorIzq.Alignment = StringAlignment.Near;
            formatoSuperiorIzq.LineAlignment = StringAlignment.Near;

            formatoSuperiorDer.Alignment = StringAlignment.Far;
            formatoSuperiorDer.LineAlignment = StringAlignment.Near;

            formatoInferiorIzq.Alignment = StringAlignment.Near;
            formatoInferiorIzq.LineAlignment = StringAlignment.Far;

            formatoInferiorDer.Alignment = StringAlignment.Far;
            formatoInferiorDer.LineAlignment = StringAlignment.Far;

            grfx.DrawString("Centrado", Font, Brushes.Black, ptoCentral, formatoCentral);
            grfx.DrawString("Superior Izquierda", Font, Brushes.Black, 0, 0, formatoSuperiorIzq);
            grfx.DrawString("Superior Derecha", Font, Brushes.Black, ClientSize.Width, 0, formatoSuperiorDer);
            grfx.DrawString("Inferior Izquierda", Font, Brushes.Black, 0, ClientSize.Height, formatoInferiorIzq);
            grfx.DrawString("Inferior Derecha", Font, Brushes.Black, ClientSize.Width, ClientSize.Height, formatoInferiorDer);
        }
    }
}
