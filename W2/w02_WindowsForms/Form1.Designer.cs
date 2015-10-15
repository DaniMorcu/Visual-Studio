namespace w02_WindowsForms
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btnOtroFormulario = new System.Windows.Forms.Button();
            this.btnControladorPaint = new System.Windows.Forms.Button();
            this.btnPaintPara2 = new System.Windows.Forms.Button();
            this.btnDimensiones = new System.Windows.Forms.Button();
            this.btnCuatroEsquinas = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtroFormulario
            // 
            this.btnOtroFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtroFormulario.Location = new System.Drawing.Point(34, 48);
            this.btnOtroFormulario.Name = "btnOtroFormulario";
            this.btnOtroFormulario.Size = new System.Drawing.Size(331, 37);
            this.btnOtroFormulario.TabIndex = 0;
            this.btnOtroFormulario.Text = "Otro Formulario";
            this.btnOtroFormulario.UseVisualStyleBackColor = true;
            this.btnOtroFormulario.Click += new System.EventHandler(this.btnOtroFormulario_Click);
            // 
            // btnControladorPaint
            // 
            this.btnControladorPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControladorPaint.Location = new System.Drawing.Point(34, 115);
            this.btnControladorPaint.Name = "btnControladorPaint";
            this.btnControladorPaint.Size = new System.Drawing.Size(331, 37);
            this.btnControladorPaint.TabIndex = 1;
            this.btnControladorPaint.Text = "Controlador Paint";
            this.btnControladorPaint.UseVisualStyleBackColor = true;
            this.btnControladorPaint.Click += new System.EventHandler(this.btnControladorPaint_Click);
            // 
            // btnPaintPara2
            // 
            this.btnPaintPara2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaintPara2.Location = new System.Drawing.Point(34, 188);
            this.btnPaintPara2.Name = "btnPaintPara2";
            this.btnPaintPara2.Size = new System.Drawing.Size(331, 37);
            this.btnPaintPara2.TabIndex = 2;
            this.btnPaintPara2.Text = "Un Controlador Paint Para 2 Forms";
            this.btnPaintPara2.UseVisualStyleBackColor = true;
            this.btnPaintPara2.Click += new System.EventHandler(this.btnPaintPara2_Click);
            // 
            // btnDimensiones
            // 
            this.btnDimensiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDimensiones.Location = new System.Drawing.Point(34, 263);
            this.btnDimensiones.Name = "btnDimensiones";
            this.btnDimensiones.Size = new System.Drawing.Size(160, 37);
            this.btnDimensiones.TabIndex = 3;
            this.btnDimensiones.Text = "Dimensiones";
            this.btnDimensiones.UseVisualStyleBackColor = true;
            this.btnDimensiones.Click += new System.EventHandler(this.btnDimensiones_Click);
            // 
            // btnCuatroEsquinas
            // 
            this.btnCuatroEsquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatroEsquinas.Location = new System.Drawing.Point(34, 341);
            this.btnCuatroEsquinas.Name = "btnCuatroEsquinas";
            this.btnCuatroEsquinas.Size = new System.Drawing.Size(331, 37);
            this.btnCuatroEsquinas.TabIndex = 4;
            this.btnCuatroEsquinas.Text = "Las cuatro Esquinas";
            this.btnCuatroEsquinas.UseVisualStyleBackColor = true;
            this.btnCuatroEsquinas.Click += new System.EventHandler(this.btnCuatroEsquinas_Click);
            // 
            // btnColores
            // 
            this.btnColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.Location = new System.Drawing.Point(205, 263);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(160, 37);
            this.btnColores.TabIndex = 5;
            this.btnColores.Text = "Colores";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 430);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnCuatroEsquinas);
            this.Controls.Add(this.btnDimensiones);
            this.Controls.Add(this.btnPaintPara2);
            this.Controls.Add(this.btnControladorPaint);
            this.Controls.Add(this.btnOtroFormulario);
            this.Name = "Form1";
            this.Text = "Formulario que pasamos a Run";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtroFormulario;
        private System.Windows.Forms.Button btnControladorPaint;
        private System.Windows.Forms.Button btnPaintPara2;
        private System.Windows.Forms.Button btnDimensiones;
        private System.Windows.Forms.Button btnCuatroEsquinas;
        private System.Windows.Forms.Button btnColores;
    }
}

