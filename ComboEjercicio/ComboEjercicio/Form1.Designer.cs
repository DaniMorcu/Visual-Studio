namespace ComboEjercicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.pbCaptura = new System.Windows.Forms.PictureBox();
            this.tbCompanyia = new System.Windows.Forms.TextBox();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtimeNuevo = new System.Windows.Forms.DateTimePicker();
            this.btnMas = new System.Windows.Forms.Button();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.tbNuevaCompanyia = new System.Windows.Forms.TextBox();
            this.dtimeFecha = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(20, 18);
            this.cbLista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(207, 27);
            this.cbLista.TabIndex = 0;
            this.cbLista.SelectedIndexChanged += new System.EventHandler(this.cbLista_SelectedIndexChanged);
            // 
            // pbCaptura
            // 
            this.pbCaptura.Location = new System.Drawing.Point(292, 18);
            this.pbCaptura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbCaptura.Name = "pbCaptura";
            this.pbCaptura.Size = new System.Drawing.Size(459, 265);
            this.pbCaptura.TabIndex = 1;
            this.pbCaptura.TabStop = false;
            // 
            // tbCompanyia
            // 
            this.tbCompanyia.Location = new System.Drawing.Point(20, 223);
            this.tbCompanyia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbCompanyia.Name = "tbCompanyia";
            this.tbCompanyia.ReadOnly = true;
            this.tbCompanyia.Size = new System.Drawing.Size(248, 26);
            this.tbCompanyia.TabIndex = 4;
            // 
            // pbIcono
            // 
            this.pbIcono.Location = new System.Drawing.Point(81, 53);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(128, 128);
            this.pbIcono.TabIndex = 5;
            this.pbIcono.TabStop = false;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(20, 257);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.ReadOnly = true;
            this.tbFecha.Size = new System.Drawing.Size(248, 26);
            this.tbFecha.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(20, 189);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(248, 26);
            this.tbNombre.TabIndex = 3;
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "Android Studio.png");
            this.imageListIconos.Images.SetKeyName(1, "Avira AV.png");
            this.imageListIconos.Images.SetKeyName(2, "Google Chrome.png");
            this.imageListIconos.Images.SetKeyName(3, "Mozilla Firefox.png");
            this.imageListIconos.Images.SetKeyName(4, "Nero 2015.png");
            this.imageListIconos.Images.SetKeyName(5, "Winrar.png");
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(20, 311);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 26);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(145, 311);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 26);
            this.textBox1.TabIndex = 10;
            // 
            // dtimeNuevo
            // 
            this.dtimeNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtimeNuevo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeNuevo.Location = new System.Drawing.Point(20, 257);
            this.dtimeNuevo.Name = "dtimeNuevo";
            this.dtimeNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtimeNuevo.Size = new System.Drawing.Size(248, 26);
            this.dtimeNuevo.TabIndex = 11;
            this.dtimeNuevo.Visible = false;
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(237, 18);
            this.btnMas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(31, 27);
            this.btnMas.TabIndex = 13;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(401, 90);
            this.tbNuevoNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(248, 26);
            this.tbNuevoNombre.TabIndex = 14;
            this.tbNuevoNombre.Visible = false;
            // 
            // tbNuevaCompanyia
            // 
            this.tbNuevaCompanyia.Location = new System.Drawing.Point(401, 141);
            this.tbNuevaCompanyia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNuevaCompanyia.Name = "tbNuevaCompanyia";
            this.tbNuevaCompanyia.Size = new System.Drawing.Size(248, 26);
            this.tbNuevaCompanyia.TabIndex = 15;
            this.tbNuevaCompanyia.Visible = false;
            // 
            // dtimeFecha
            // 
            this.dtimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeFecha.Location = new System.Drawing.Point(401, 192);
            this.dtimeFecha.Name = "dtimeFecha";
            this.dtimeFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtimeFecha.Size = new System.Drawing.Size(248, 26);
            this.dtimeFecha.TabIndex = 16;
            this.dtimeFecha.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(451, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 19);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Nuevo programa:";
            this.lbl.Visible = false;
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Location = new System.Drawing.Point(455, 241);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(154, 26);
            this.btnGuardar2.TabIndex = 18;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Visible = false;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 362);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dtimeFecha);
            this.Controls.Add(this.tbNuevaCompanyia);
            this.Controls.Add(this.tbNuevoNombre);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.dtimeNuevo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.pbIcono);
            this.Controls.Add(this.tbCompanyia);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.pbCaptura);
            this.Controls.Add(this.cbLista);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.PictureBox pbCaptura;
        private System.Windows.Forms.TextBox tbCompanyia;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ImageList imageListIconos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtimeNuevo;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.TextBox tbNuevaCompanyia;
        private System.Windows.Forms.DateTimePicker dtimeFecha;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnGuardar2;
    }
}

