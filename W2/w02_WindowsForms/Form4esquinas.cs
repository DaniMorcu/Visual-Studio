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
    public partial class Form4esquinas : Form
    {
        public Form4esquinas()
        {
            Text = "Alineación de texto en cuatro esquinas";
            BackColor = SystemColors.Window;
            ForeColor = SystemColors.WindowText;
            ResizeRedraw = true;

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;

            Brush brocha = new SolidBrush(Color.Black);
            StringFormat formato = new StringFormat();

            //objStringFormat.Alignment = StringAlignment.Near;
            //objStringFormat.LineAlignment = StringAlignment.Near;
            grafico.DrawString("Esquina superior izquierda", Font, brocha, 0, 0);

            formato.Alignment = StringAlignment.Far; 
            formato.LineAlignment = StringAlignment.Near;
            grafico.DrawString("Esquina superior derecha", Font, brocha,
                            ClientSize.Width, 0, formato);

            formato.Alignment = StringAlignment.Near;
            formato.LineAlignment = StringAlignment.Far;
            grafico.DrawString("Esquina inferior izquierda", Font, brocha,
                            0, ClientSize.Height, formato);

            formato.Alignment = StringAlignment.Far;
            formato.LineAlignment = StringAlignment.Far;
            grafico.DrawString("Esquina", Font, brocha,
                            ClientSize.Width, ClientSize.Height, formato);

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            //Quedará centrado independientemente del texto que sea
            grafico.DrawString("¡Hola!. En to'r centro", Font, Brushes.Black, ClientSize.Width / 2, ClientSize.Height / 2, formato);
        }

    }
}
