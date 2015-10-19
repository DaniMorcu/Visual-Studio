using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Vamos a cargar inicialmente equipos en el chlbEquipos
            chlbEquipos.Items.Add("A la vez");
            chlbEquipos.Items.Add("Osasuna");
            chlbEquipos.Items.Add("Betis");
            chlbEquipos.Items.Add("Madrid");
            chlbEquipos.Items.Add("Sevilla");
            chlbEquipos.Items.Add("Cadiz");

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            //  Comprobar que no está vacío //  Con String.Empty es igual a ""
            //  tbNombreEquipo.Text.Lengt 
            if (tbNombreEquipo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo vacío");
            }
            else if (chlbEquipos.Items.Contains(tbNombreEquipo.Text.Trim()))
            {
                MessageBox.Show("El equipo ya existe");
                tbNombreEquipo.Clear();
            }
            else
            {
                chlbEquipos.Items.Add(tbNombreEquipo.Text);
                tbNombreEquipo.Clear();
            }
        }

        private void rbDosClic_CheckedChanged(object sender, EventArgs e)
        {
            //  La propiedad del radiobuton checked nos devuelve un booleano con el estado si esta 
            //  activada (true) o no (false)
            chlbEquipos.CheckOnClick = rbUnClic.Checked;
        }

        private void tbNombreEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAnyadir_Click(sender, e);
            }
        }

        private void chbMultiColum_CheckedChanged(object sender, EventArgs e)
        {
            chlbEquipos.MultiColumn = !chlbEquipos.MultiColumn;
        }

        private void btnOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            Random rd = new Random();

            if(chbOrdenar.Checked)
            {
                chlbEquipos.Sorted = true;
            }
            else
            {
                for(int i = 0; i<chlbEquipos.Items.Count; i++){

                }
            }

        }

        private void btnBorrarChecked_Click(object sender, EventArgs e)
        {
            //  Vamos a borrar una lista empezando a contar desde el inicio,
            //  hay que tener en cuenta algunas cosas como no establecer el count en la condición
            //  porque cada vez que se ejecuta borra un elemento y entonces se modifica el numero de elementos
            //int numElementos = chlbEquipos.CheckedItems.Count;

            //for (int i = 0; i < numElementos; i++)
            //{
            //    chlbEquipos.Items.Remove(chlbEquipos.CheckedItems[0]);
            //}


            //  Otra forma estableciendo la condición el numero de elementos checkeado [LA MEJOR]
            while (chlbEquipos.CheckedItems.Count > 0)
            {
                chlbEquipos.Items.Remove(chlbEquipos.CheckedItems[0]);
            }

            //  Desde atras hasta delante
            //for(int i = chlbEquipos.CheckedItems.Count - 1; i >= 0 ; i--)
            //{
            //    chlbEquipos.Items.Remove(chlbEquipos.CheckedItems[i]);
            //}
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chlbEquipos.Items.Count ; i++)
            {
                if (chlbEquipos.GetItemCheckState(i) == CheckState.Checked)
                    chlbEquipos.SetItemCheckState(i, CheckState.Unchecked);
                else
                    chlbEquipos.SetItemCheckState(i, CheckState.Checked);
            }
        }


    }
}
