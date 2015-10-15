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
    public partial class Form1 : Form
    {
        public static String NombreBoton = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button accion = (Button)sender;
            FormDibujar frm = new FormDibujar();

            switch (accion.Name)
            {
                case "btnUno":
                    NombreBoton = accion.Text;
                    frm.ShowDialog(); 
                    break;
                case "btnDos":
                    NombreBoton = accion.Text;
                    frm.ShowDialog();
                    break;
                case "Tres":
                    NombreBoton = accion.Text;
                    frm.ShowDialog();
                    break;
                case "Cuatro":
                    NombreBoton = accion.Text;
                    frm.ShowDialog();
                    break;
                case "Cinco":
                    NombreBoton = accion.Text;
                    frm.ShowDialog();
                    break;
                default:
                    break;

            }
        }
    }
}
