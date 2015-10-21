using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  Espacio de nombre para trabajar con los Stream
using System.IO;

namespace ProjectoOpenSaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            Stream miStream = null;
            //String linea = String.Empty;

            StreamReader fr = new StreamReader();

            //  Ruta inicial al abrir el OpenFileDialog
            ofdialog.InitialDirectory = "C:\\Program Files\\";

            //  Menu despegable en la ventana para aplicar un filtro en la extensión de los archivos 
            //  que mostraremos en la ruta establecida
            ofdialog.Filter = "Archivos txt (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            // Establece la opcion por defecto a los distintos filtros establecidos (comienza en el 1)
            ofdialog.FilterIndex = 1;

            //  Establece si guarda la ultima ruta establecida (?)
            ofdialog.RestoreDirectory = false;

            StreamReader sr = new StreamReader();
            File fr = new File();

                
            sr = ofdialog.OpenFile

            if (ofdialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((miStream = ofdialog.OpenFile()) != null)
                    {
                        using (miStream)
                        {
                            while()
                            {
                                chlbListaCargada.Items.Add();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ¡No se ha podido encontrar el archivo en el disco duro!" + ex.Message);
                }
                finally
                {
                    miStream.Close();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Stream miStream;
            SaveFileDialog guardarDialogo = new SaveFileDialog();

            guardarDialogo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            guardarDialogo.FilterIndex = 2;
            guardarDialogo.RestoreDirectory = true;

            if (guardarDialogo.ShowDialog() == DialogResult.OK)
            {
                if ((miStream = guardarDialogo.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    miStream.Close();
                }
            }
        }

    }
}
