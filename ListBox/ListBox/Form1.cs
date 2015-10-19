using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxEquipos.Items.Add("Barca");
            lbxEquipos.Items.Add("Madri");
            lbxEquipos.Items.Add("Sevilla");
            lbxEquipos.Items.Add("Osasuna");
            lbxEquipos.Items.Add("Cadiz");
            lbxEquipos.Items.Add("Jerez");
        }

        private void tbNombreEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAnyadir_Click(sender, e);
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            //  Comprobar que no está vacío //  Con String.Empty es igual a ""
            //  tbNombreEquipo.Text.Lengt 
            if (tbNombreEquipo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo vacío");
            }
            else if (lbxEquipos.Items.Contains(tbNombreEquipo.Text.Trim()))
            {
                MessageBox.Show("El equipo ya existe");
                tbNombreEquipo.Clear();
            }
            else
            {
                lbxEquipos.Items.Add(tbNombreEquipo.Text);
                tbNombreEquipo.Clear();
            }
        }

        private void btnBorrarChecked_Click_1(object sender, EventArgs e)
        {
            while (lbxEquipos.SelectedItems.Count > 0)
            {
                lbxEquipos.Items.Remove(lbxEquipos.SelectedItems[0]);
            }

        }

    }
}
