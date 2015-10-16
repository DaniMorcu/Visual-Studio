using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedBoxList
{
    public partial class Form1 : Form
    {
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiaColor_Click(object sender, EventArgs e)
        {
            checkedListBox1.BackColor = Color.FromArgb(rd.Next(251), rd.Next(251), rd.Next(251));
        }

        private void rdbClick1_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = !rdbClick2.Checked;
        }

        private void txbElementoNuevo_TextChanged(object sender, EventArgs e)
        {
            checkedListBox1.
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            checkedListBox1.RightToLeft = false;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            checkedListBox1.RightToLeft(true);
        }
    }
}
