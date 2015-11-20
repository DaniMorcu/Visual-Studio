namespace w12b_ComboEnlazado2
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
            this.panel = new System.Windows.Forms.Panel();
            this.cbPelis = new System.Windows.Forms.ComboBox();
            this.pbCartel = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblAccion);
            this.panel.Controls.Add(this.tbDirector);
            this.panel.Controls.Add(this.tbAño);
            this.panel.Controls.Add(this.pbCartel);
            this.panel.Controls.Add(this.tbDuracion);
            this.panel.Controls.Add(this.tbNombre);
            this.panel.Location = new System.Drawing.Point(23, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(564, 300);
            this.panel.TabIndex = 0;
            // 
            // cbPelis
            // 
            this.cbPelis.FormattingEnabled = true;
            this.cbPelis.Location = new System.Drawing.Point(23, 23);
            this.cbPelis.Name = "cbPelis";
            this.cbPelis.Size = new System.Drawing.Size(250, 27);
            this.cbPelis.TabIndex = 1;
            this.cbPelis.SelectedIndexChanged += new System.EventHandler(this.cbPelis_SelectedIndexChanged);
            // 
            // pbCartel
            // 
            this.pbCartel.Location = new System.Drawing.Point(313, 4);
            this.pbCartel.Name = "pbCartel";
            this.pbCartel.Size = new System.Drawing.Size(240, 290);
            this.pbCartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartel.TabIndex = 2;
            this.pbCartel.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(24, 36);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(195, 26);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(24, 103);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.ReadOnly = true;
            this.tbDuracion.Size = new System.Drawing.Size(195, 26);
            this.tbDuracion.TabIndex = 1;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(24, 170);
            this.tbAño.Name = "tbAño";
            this.tbAño.ReadOnly = true;
            this.tbAño.Size = new System.Drawing.Size(195, 26);
            this.tbAño.TabIndex = 2;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(24, 237);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(195, 26);
            this.tbDirector.TabIndex = 3;
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNueva.Location = new System.Drawing.Point(337, 22);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(250, 26);
            this.btnNueva.TabIndex = 3;
            this.btnNueva.Text = "Nueva Película";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(23, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 26);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Location = new System.Drawing.Point(153, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 26);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(84, 4);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(0, 19);
            this.lblAccion.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 441);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.cbPelis);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbPelis;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.PictureBox pbCartel;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAccion;
    }
}

