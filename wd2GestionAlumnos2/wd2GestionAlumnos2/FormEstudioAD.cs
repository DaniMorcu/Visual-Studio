using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
// Usamos el namespace System.Data.OleDb para usar BD´s Access
using System.Data.OleDb;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EstudioAccesoDatos
{
    public partial class FormEstudioAD : Form
    {
        // Paso 1: Construimos la cadena de conexión a la BD                                        @"..\..\Datos\
        private string strConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\zDatosPruebas\bd_Ejemplo.mdb"; // tanto ..\ es para acceder de forma relativa a la carpeta Datos
        // Paso 2.1 declaramos el objeto conexión
        private OleDbConnection objConn;
        // Paso 3.1 declaramos el objeto dataAdapter para conectarlo con el dataset
        private OleDbDataAdapter objDa;
        // Paso 4.1 declaramos el dataset
        private DataSet ds;

        bool esNuevo;

        // Añadimos para esta versión
        DataRow filaDS = null;  // <-- Nos servirá para actualizar registro
        bool comenzando = true; // <-- Para evitar el evento del combo cuando lo cargo


        public FormEstudioAD()
        {
            InitializeComponent();
            //Paso 2.2 inicializamos el objeto conexión
            objConn = new OleDbConnection(strConexion);
            // Paso 3.2: Construimos el objeto DataAdapter y lo inicializamos
            objDa = new OleDbDataAdapter("select * from Grupos", objConn);
            // Paso 3.3: Construimos las sentencias Update, Insert y Delete de forma atomática a 
            // partir del Select del DataApter
            OleDbCommandBuilder builder = new OleDbCommandBuilder(objDa);
            // MessageBox.Show(builder.GetDeleteCommand().CommandText);
        }
        private void FormEstudioAD_Load(object sender, EventArgs e)
        {
            //Cargamos los combos (en el constructor todavía no está)
            CargaCombos(); // (comentar el evento SelectedIndexChanged al cargar y cómo evitarlo)
            comenzando = false;
            CargaAlumnosGrupo();
        }

        #region Métodos para los eventos de los controles de panelControl

        // El botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //--- Buscamos en el ds, el registro correspondiente al alumno seleccionado (explicar por qué no se coge simplemente el índice del dgv)
            // Capturamos el idAlumnos del registro del dgv seleccionado
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value); // <-- Lo obtenemos de la tabla de registros seleccionados
            // Buscamos la fila del ds 
            foreach(DataRow reg in ds.Tables[0].Rows)
                if (idAlumno == Convert.ToInt32(reg["idAlumno"]))
                {
                    filaDS = reg;
                    break;
                }
            // todo lo anterior puede ir en un método BuscaAlumSeleccionado, que devuelve el registro: filaDS = BuscaAlumSeleccionado();


            //--- Actualizamos los controles del panelDetalle con los campos de dicho registro
            txbIndice.Text = idAlumno.ToString();
            cbGruposDetalle.SelectedValue = filaDS["idGrupo"].ToString();// <-- seleccionamos el valor del combo
            txbApellNom.Text = filaDS["apellidosNombre"].ToString();
            txbTelefono.Text = filaDS["telefono"].ToString();
            txbMovil.Text = filaDS["movil"].ToString();
            txbDni.Text = filaDS["dni"].ToString();
            txbMail.Text = filaDS["email"].ToString();
            txbIndice.Visible = true; // <-- Se verá el índice

            esNuevo = false;
            this.Height = 460; //<-- Encogemos el formulario
            panelControles.Visible = false; //<-- Ocultamos el panelControles
            panelDetalle.Visible = true; //<-- Mostramos el panelDetalle
        }

        // El botón Añadir
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //--- Limpiamos los controles de panelDetalle
            txbApellNom.Clear(); // en atención a Carlos Yera
            txbDni.Clear();
            txbIndice.Clear();
            txbMail.Clear();
            txbMovil.Clear();
            txbTelefono.Clear();
            cbGruposDetalle.Text = "Selecciona un Grupo";

            // Tomamos una nueva fila como la de la tabla de alumnos
            filaDS = ds.Tables[0].NewRow();

            txbIndice.Visible = false;
            //Y actuamos como en edición pero haciendo esNuevo
            esNuevo = true;
            this.Height = 460; //<-- Encogemos el formulario
            panelControles.Visible = false; //<-- Ocultamos el panelControles
            panelDetalle.Visible = true; //<-- Mostramos el panelDetalle
        }

        // El botón Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Si no confirmo el borrado, me salgo de este método
            string mensaje = "Confirmas que quieres eliminar a este alumno?:\n\t" + dgv.SelectedRows[0].Cells["apellidosNombre"].Value.ToString();
            if (DialogResult.No == MessageBox.Show(mensaje, "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            //--- Como en Editar Buscamos en el ds, el registro correspondiente al alumno seleccionado (por eso puede ir en un método)
            // Capturamos el idAlumnos del registro del dgv seleccionado
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value); // <-- Lo obtenemos de la tabla de registros seleccionados
            // Buscamos la fila del ds 
            foreach (DataRow reg in ds.Tables[0].Rows)
                if (idAlumno == Convert.ToInt32(reg["idAlumno"]))
                {
                    reg.Delete();
                    break;
                }

            try
            {
                objDa.Update(ds.Tables[0]);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            //Actualizamos el dgv Sin tener que acudir a la BD
            dgv.Refresh();
        }

        // Cambiando la opción del combo cbGrupos
        private void cbGrupos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // si estoy cargando el combo no hago nada
            if (comenzando) 
                return;

            // lo hacemos en un método porque nos va a hacer falta más veces
            CargaAlumnosGrupo();
        }

        // Cargamos la tabla de alumnos de un grupo o de todos, en función del combo cbGrupos
        private void CargaAlumnosGrupo()
        {
            // Ejemplo de select personalizado. 
            // En este caso vamos a cargar, sólo los alumnos del grupo seleccionado
            // Capturamos el grupo seleccionado y mostramos su nombre en la cabecera
            string idGrupo = cbGrupos.SelectedValue.ToString();

            lbCabecera.Text = "Alumnos de " + cbGrupos.Text;

            ds = new DataSet(); // Ojo: Nueva Inicialización del DataSet

            if (idGrupo == "todos")
                objDa.SelectCommand.CommandText = "Select * from Alumnos";
            else
                objDa.SelectCommand.CommandText = "Select * from Alumnos WHERE idGrupo = '" + idGrupo + "'";


            // Cargamos la tabla
            objDa.Fill(ds, "alumnosGrupo");
            // Paso 5.2: le indicamos al datagrid el origen de datos: el dataset anterior
            dgv.DataSource = ds.Tables["alumnosGrupo"];
        }

        #endregion

        #region Metodos para controlar los dos botones del panelDetalle

        // El botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //// Si hay error en los datos Me salgo
            //if (HayErrorEnDatos())
            //    return;

            // lo que sigue se hace también para Añadir, por lo que se puede colocar en un Método
            filaDS["idGrupo"]=cbGruposDetalle.SelectedValue;// <-- seleccionamos el valor del combo
            filaDS["apellidosNombre"]=txbApellNom.Text;
            filaDS["telefono"]=txbTelefono.Text;
            filaDS["movil"]=txbMovil.Text;
            filaDS["dni"]=txbDni.Text;
            filaDS["email"]=txbMail.Text;
            if (esNuevo)
                ds.Tables[0].Rows.Add(filaDS);

            try
            {
                objDa.Update(ds.Tables[0]);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            //Actualizamos el dgv Sin tener que acudir a la BD
            dgv.Refresh();

            // Actualizamos los paneles y ampliamos el form
            panelDetalle.Visible = false;
            panelControles.Visible = true;
            this.Height = 590;
        }

        // El botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Actualizamos los paneles y ampliamos el form
            panelDetalle.Visible = false;
            panelControles.Visible = true;
            this.Height = 590;
        }
        #endregion

        // Método que carga los dos combos de Grupos: cbGrupos y cbGruposDetalle
        private void CargaCombos()
        {
            List<Grupo> listaGrupos, listaTodosMasGrupos;
            Grupo grupo;
            // Declaramos el DataReader
            OleDbDataReader objDr;

            // Configuramos el comando
            OleDbCommand objComm = new OleDbCommand("select * from Grupos", objConn);
            // OleDbCommand objCommTodos = new OleDbCommand("select * from Alumnos", objConn);

            // Si no está abierta la conexión, la abro ahora
            if (objConn.State != ConnectionState.Open)
                objConn.Open();

            // Cargo el DR con el select de nuestro comando
            objDr = objComm.ExecuteReader();

            // Cargo en nuestra listaGrupos el DataReader
            listaGrupos = new List<Grupo>();
            while (objDr.Read())
            {
                grupo = new Grupo(objDr.GetString(0), objDr.GetString(1));
                listaGrupos.Add(grupo);
            }
            // Cierro el DataReader y la conexión
            objDr.Close();
            objConn.Close();

            // Ahora cargo la lista que tiene en primer lugar "Todos los grupos"
            listaTodosMasGrupos = new List<Grupo>();
            listaTodosMasGrupos.Add(new Grupo("todos", "Todos los Grupos")); // <-- Añado en primer lugar "Todos los grupos"
            // y sigo cargándola con la otra lista
            foreach (Grupo g in listaGrupos)
                listaTodosMasGrupos.Add(g);

            // Enlazo el combo del panelControles con la listaTodosMasGrupos
            cbGrupos.DataSource = listaTodosMasGrupos;		// Origen de datos
            cbGrupos.ValueMember = "IDGrupo";	// Campo asociado a Valúe "no se verá"
            cbGrupos.DisplayMember = "Nombre";	// Campo asociado a Display "Text"

            // Enlazo el combo del panelDetalle con la listaGrupos
            cbGruposDetalle.DataSource = listaGrupos;		// Origen de datos
            cbGruposDetalle.ValueMember = "IDGrupo";	// Campo asociado a Valúe "no se verá"
            cbGruposDetalle.DisplayMember = "Nombre";	// Campo asociado a Display "Text"
        }
    }

    public struct Grupo
    {
        private string idGrupo;
        private string nombre;

        //-- El constructor
        public Grupo(string idGrupo, string nombre)
        {
            this.idGrupo = idGrupo;
            this.nombre = nombre;
        }

        //-- Las propiedades
        public string IDGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

}
