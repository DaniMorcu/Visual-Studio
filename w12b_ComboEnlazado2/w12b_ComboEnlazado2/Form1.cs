using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace w12b_ComboEnlazado2
{
    public partial class Form1 : Form
    {
        private static List<Pelicula> listaPelis = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\..\Datos\Pelis.txt");

            String fila = String.Empty;

            while (!sr.EndOfStream)
            {
                fila = sr.ReadLine();
                Pelicula p = new Pelicula(fila);
                listaPelis.Add(p);
            }

            //  Cargamos el combobox con la lista
            cbPelis.DataSource = listaPelis;
            cbPelis.DisplayMember = "nombre";
            cbPelis.ValueMember = "Id";
        }

        private void cbPelis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPelis.SelectedItem != null)
            {
                // Cargamos los Textbox correspondientes al objeto
                tbNombre.Text = ((Pelicula)cbPelis.SelectedItem).Nombre.ToString();
                tbDuracion.Text = ((Pelicula)cbPelis.SelectedItem).Duracion.ToString();
                tbAño.Text = ((Pelicula)cbPelis.SelectedItem).Año.ToString();
                tbDirector.Text = ((Pelicula)cbPelis.SelectedItem).Director.ToString();
                try
                {
                    pbCartel.Image = Image.FromFile(@"..\..\..\Imagenes\Carteles\cartel" + ((Pelicula)cbPelis.SelectedItem).Id.ToString("0000") + ".jpg");
                }
                catch (Exception error)
                {
                    pbCartel.Image = Image.FromFile(@"..\..\..\Imagenes\Carteles\cartel\default.jpg");

                }
            }   
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            tbNombre.BackColor = btnNueva.BackColor;
            tbDuracion.BackColor = btnNueva.BackColor;
            tbAño.BackColor = btnNueva.BackColor;
            tbDirector.BackColor = btnNueva.BackColor;

            lblAccion.Text = "Nueva Pelicula";

            tbNombre.ReadOnly = false;
            tbDuracion.ReadOnly = false;
            tbAño.ReadOnly = false;
            tbDirector.ReadOnly = false;

            cbPelis.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tbNombre.BackColor = btnModificar.BackColor;
            tbDuracion.BackColor = btnModificar.BackColor;
            tbAño.BackColor = btnModificar.BackColor;
            tbDirector.BackColor = btnModificar.BackColor;

            lblAccion.Text = "Modificar Película";

            tbNombre.ReadOnly = false;
            tbDuracion.ReadOnly = false;
            tbAño.ReadOnly = false;
            tbDirector.ReadOnly = false;

            cbPelis.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tbNombre.BackColor = btnEliminar.BackColor;
            tbDuracion.BackColor = btnEliminar.BackColor;
            tbAño.BackColor = btnEliminar.BackColor;
            tbDirector.BackColor = btnEliminar.BackColor;

            lblAccion.Text = "Eliminar Pelicula";

            tbNombre.ReadOnly = false;
            tbDuracion.ReadOnly = false;
            tbAño.ReadOnly = false;
            tbDirector.ReadOnly = false;

            cbPelis.Enabled = false;

            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminarlo", "Eliminar película", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < listaPelis.Count; i++)
                {
                    if (listaPelis[i].Id == Convert.ToInt32(cbPelis.SelectedValue))
                    {
                        listaPelis.RemoveAt(i);
                    }
                }

                cbPelis.DataSource = null;

                cbPelis.DataSource = listaPelis;
                cbPelis.DisplayMember = "nombre";
                cbPelis.ValueMember = "Id";
            }

            cbPelis.Enabled = true;
            
        }
    }
}
