using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboEjercicio
{
    public partial class Form1 : Form
    {
        private static List<Programa> listaProgramas = new List<Programa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaListaProgramas();

            cbLista.DataSource = listaProgramas;
            cbLista.DisplayMember = "Nombre";
            cbLista.ValueMember = "id";

        }

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargamos los Textbox correspondientes al objeto
            tbNombre.Text = ((Programa)cbLista.SelectedItem).Nombre.ToString();
            tbCompanyia.Text = ((Programa)cbLista.SelectedItem).Companyia.ToString();
            tbFecha.Text = ((Programa)cbLista.SelectedItem).FechaActualizacion.ToString();
            pbIcono.BackgroundImage = imageListIconos.Images[((Programa)cbLista.SelectedItem).Nombre.ToString() + ".png"];
        }

        private void cargaListaProgramas(){

            //  Lista de programas
            Programa prog1 = new Programa(1, "Winrar", "Winrar Company", "23/10/2015");
            Programa prog2 = new Programa(2, "Google Chrome", "Google Company", "25/06/2015");
            Programa prog3 = new Programa(3, "Avira AV", "Avira SA", "28/09/2015");
            Programa prog4 = new Programa(4, "Nero 2015", "Networks Studio", "16/02/2015");
            Programa prog5 = new Programa(5, "Mozilla Firefox", "Fundation Mozilla","15/11/2015");
            Programa prog6 = new Programa(6, "Android Studio", "Google Company", "07/11/2015");

            //  Lo cargamos a la lista de programas "listaPrograma"
            listaProgramas.Add(prog1);
            listaProgramas.Add(prog2);
            listaProgramas.Add(prog3);
            listaProgramas.Add(prog4);
            listaProgramas.Add(prog5);
            listaProgramas.Add(prog6);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Mostramos el boton de Guardar
            btnGuardar.Visible = true;
            tbNombre.ReadOnly = false;
            tbCompanyia.ReadOnly = false;
            dtimeNuevo.Visible = true;

            //  Para mostrar el cuadro de dialogo de la nueva fecha
            String fechaAnterior = ((Programa)cbLista.SelectedItem).FechaActualizacion.ToString();
            String[] fechaAnt = fechaAnterior.Split('/');
            
            int anyo = 2000, mes = 01, dia = 01;
            try
            {
                Int32.TryParse(fechaAnt[2], out anyo);
                Int32.TryParse(fechaAnt[1], out mes);
                Int32.TryParse(fechaAnt[0], out dia);
            }
            catch (FormatException error)
            {
               MessageBox.Show(error.Message);
            }
          
            dtimeNuevo.Value = new DateTime(anyo, mes, dia);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //listaProgramas.ElementAt(((Programa)cbLista.SelectedItem).Id).Nombre = tbNombre.Text;
            //cbLista.Refresh();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            pbCaptura.Visible = false;
            lbl.Visible = true;
            tbNuevoNombre.Visible = true;
            tbNuevaCompanyia.Visible = true;
            dtimeFecha.Visible = true;
            btnGuardar2.Visible = true;
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            Programa prog = new Programa();

            if (tbNuevoNombre.Text.ToString() != String.Empty && tbCompanyia.Text.ToString() != String.Empty)
            {
                prog = new Programa(listaProgramas.Count + 1, tbNuevoNombre.Text.ToString(), tbCompanyia.Text.ToString(), dtimeFecha.ToString());
                listaProgramas.Add(prog);
            }
            else
                MessageBox.Show("Campos vacíos!");
        }
 
    }
}
