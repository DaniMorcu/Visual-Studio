using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w02_WindowsForms
{
    public partial class Form1 : Form
    {
        static Form form1, form2;

        public Form1()
        {
            InitializeComponent();
            //btnOtroFormulario.Enabled = false;
            
        }

        #region El método Show de Form (2.2)
        private void btnOtroFormulario_Click(object sender, EventArgs e)
        {
            //--- Construyo otro formulario
            form2 = new Form();

            //--- Le doy propiedades a mi gusto
            form2.Text = "Form 2. Soy inútil pero quedo bonito";
            form2.BackColor = Color.Gold;
            form2.Width *= 2;  // <-- Doblamos su anchura
            form2.Height /= 2; // <-- Dividimos su altura a la mitad
            form2.FormBorderStyle = FormBorderStyle.Fixed3D;
            form2.MaximizeBox = false; // <-- Deshabilitamos "Maximizar" 
            form2.Cursor = Cursors.Hand; // <-- El cursor será "la manita" 
            form2.StartPosition = FormStartPosition.CenterScreen;

            //--- Lo muestro
            //form2.Show();
            //--- Mostrarlo como diálogo
            DialogResult ds= form2.ShowDialog();
            MessageBox.Show(ds.ToString());
        }

        #endregion

        #region El Evento Paint y su control (2.3 y 2.4)
        private void btnControladorPaint_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Hola Paint";
            btnOtroFormulario.Enabled = true;

            // Añadimos mi controlador de eventos al evento Paint de la clase Form
            // El operador += instala un controlador de eventos añadiendo un método a un "manejador de eventos"
            form.Paint += new PaintEventHandler(MiControladorPaint);
            form.Show();
        }

        static void MiControladorPaint(object objSender, PaintEventArgs pea)
        {

            // objSender hace referencia al objeto sobre el que se aplica el evento, 
            form1 = (Form)objSender; //  <--- Lo guardamos en form
            Graphics objGrafico = pea.Graphics; 
            objGrafico.Clear(Color.Red);	// <-- Borra rellenando del color especificado
            //-- Definimos dos colores,por claridad
            Brush brochaNegra = Brushes.Black;
            Brush brochaAzul = Brushes.Blue;
            Font miFuente = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
            // Dibujar Textos
            objGrafico.DrawString(" ¡Hola ", miFuente, brochaNegra,20, 20); // form1.Font es la fuente por defecto
            objGrafico.DrawString(" Técnicos de Info-Lent!", miFuente, brochaAzul, 50, 100);
        }
        #endregion

        #region Un Controlador para dos Eventos Paint y su control (2.4.2)

        private void btnPaintPara2_Click(object sender, EventArgs e)
        {
            form1 = new Form();
            form1.Text = "Primer Formulario";
            form1.BackColor = Color.White;
            form1.Paint += new PaintEventHandler(MiControladorPaintPara2);

            form2 = new Form();
            form2.Text = "Segundo Formulario";
            form2.BackColor = Color.Aquamarine;
            form2.Paint += new PaintEventHandler(MiControladorPaintPara2);

            MessageBox.Show("Pulsa aceptar para lanzar el primer formulario");
            form1.Show();
            MessageBox.Show("Pulsa aceptar para lanzar el segundo");
            form2.Show();
        }


        static void MiControladorPaintPara2 (object objSender, PaintEventArgs pea)
        {
            Form form = (Form)objSender;
            Graphics grfx = pea.Graphics;

            if (form == form1)
                grfx.DrawString("Hola desde La Primera", form.Font, Brushes.Black, 50, 50);
            else
                grfx.DrawString("desde La Segunda, Hola ", form.Font, Brushes.Black, 50, 50);
        }
        #endregion

        #region Trabajando con herencia (2.5)

        private void btnDimensiones_Click(object sender, EventArgs e)
        {
            FormPrueba fp = new FormPrueba();
            fp.Text = "OnPaint() Mostrando Dimensiones";
            fp.Show();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            FormPrueba fp = new FormPrueba();
            fp.Text = "OnPaint() Mostrando Colores";
            fp.Show();
        }

        private void btnCuatroEsquinas_Click(object sender, EventArgs e)
        {
            Form4esquinas fp = new Form4esquinas();
            fp.Show();
        }
        #endregion

    }
}
