using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasPuntosySizes
{
    public partial class Form1 : Form
    {
        Point p0, p1, p2;

        public Form1()
        {
            InitializeComponent();
            
            p0 = Point.Empty;
            p1 = new Point();
            p2 = new Point(50, 100);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show((p0 == p1).ToString(), "¿Son iguales p0 y p1?");
            MessageBox.Show((p1.IsEmpty.ToString() + "\t" + p2.IsEmpty.ToString()), "¿Es Empy p0? ¿Y p2?");
        }
    }
}
