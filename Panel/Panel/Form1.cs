﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        Pen boli = new Pen(Color.Red, 3);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  No se puede construir un objeto Graphics vacío.
            Graphics grP = panel.CreateGraphics();
            grP.DrawRectangle(boli, 50, 50, 70, 30);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grF = e.Graphics;
            grF.DrawRectangle(boli, 50, 50, 70, 30);

        }
    }
}
