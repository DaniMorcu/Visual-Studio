using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04
{
    public partial class FormPrincipal : Form
    {
        //  Formulario principal donde ubicaremos todos los botones necesarios

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAranya1_Click(object sender, EventArgs e)
        {
            FormDibujar form = new FormDibujar();
            form.Text = "Raton Araña 1";
            form.Show();
        }

        private void btnAranya2_Click(object sender, EventArgs e)
        {
            FormDibujar form = new FormDibujar();
            form.Text = "Raton Araña 2";
            form.Show();
        }

        
        //  Para capturar el ratón al desplazarse sobre la ventana
      
    }
}
