using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_Full
{
    public partial class FormDibujar : Form
    {
        public FormDibujar()
        {
            InitializeComponent();

        }

        private void FormDibujar_Paint(object sender, PaintEventArgs e)
        {
             Graphics g = this.CreateGraphics();

            switch (Form1.NombreBoton)
            {
                case "Uno":
                    
                    Point p1 = new Point(25, 25);
                    Point p2 = new Point(50, 50);

                    g.DrawLine(new Pen(Color.Red), p1, p2);
                    break;
                case "Dos":
                    Point p3 = new Point(150, 150);
                    Point p4 = new Point(100, 100);

                    g.DrawLine(new Pen(Color.Red), p3, p4);
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }

          
        }

    
    }
}
