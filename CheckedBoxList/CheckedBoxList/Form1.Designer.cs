namespace CheckedBoxList
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnEliminarChecked = new System.Windows.Forms.Button();
            this.btnEliminarSelect = new System.Windows.Forms.Button();
            this.btnCambiaColor = new System.Windows.Forms.Button();
            this.gbClick = new System.Windows.Forms.GroupBox();
            this.txbElementoNuevo = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnEleminarTodo = new System.Windows.Forms.Button();
            this.rdbClick1 = new System.Windows.Forms.RadioButton();
            this.rdbClick2 = new System.Windows.Forms.RadioButton();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.gbClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Betis",
            "Cadiz",
            "Sevilla",
            "Valencia"});
            this.checkedListBox1.Location = new System.Drawing.Point(34, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 172);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnEliminarChecked
            // 
            this.btnEliminarChecked.Location = new System.Drawing.Point(203, 337);
            this.btnEliminarChecked.Name = "btnEliminarChecked";
            this.btnEliminarChecked.Size = new System.Drawing.Size(94, 54);
            this.btnEliminarChecked.TabIndex = 1;
            this.btnEliminarChecked.Text = "Eliminar checked";
            this.btnEliminarChecked.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSelect
            // 
            this.btnEliminarSelect.Location = new System.Drawing.Point(323, 337);
            this.btnEliminarSelect.Name = "btnEliminarSelect";
            this.btnEliminarSelect.Size = new System.Drawing.Size(116, 54);
            this.btnEliminarSelect.TabIndex = 2;
            this.btnEliminarSelect.Text = "Eliminar seleccionado";
            this.btnEliminarSelect.UseVisualStyleBackColor = true;
            // 
            // btnCambiaColor
            // 
            this.btnCambiaColor.Location = new System.Drawing.Point(34, 233);
            this.btnCambiaColor.Name = "btnCambiaColor";
            this.btnCambiaColor.Size = new System.Drawing.Size(120, 47);
            this.btnCambiaColor.TabIndex = 3;
            this.btnCambiaColor.Text = "Cambiar color";
            this.btnCambiaColor.UseVisualStyleBackColor = true;
            this.btnCambiaColor.Click += new System.EventHandler(this.btnCambiaColor_Click);
            // 
            // gbClick
            // 
            this.gbClick.Controls.Add(this.rdbClick2);
            this.gbClick.Controls.Add(this.rdbClick1);
            this.gbClick.Location = new System.Drawing.Point(34, 299);
            this.gbClick.Name = "gbClick";
            this.gbClick.Size = new System.Drawing.Size(120, 92);
            this.gbClick.TabIndex = 4;
            this.gbClick.TabStop = false;
            this.gbClick.Text = "Click";
            // 
            // txbElementoNuevo
            // 
            this.txbElementoNuevo.Location = new System.Drawing.Point(203, 33);
            this.txbElementoNuevo.Name = "txbElementoNuevo";
            this.txbElementoNuevo.Size = new System.Drawing.Size(236, 26);
            this.txbElementoNuevo.TabIndex = 5;
            this.txbElementoNuevo.TextChanged += new System.EventHandler(this.txbElementoNuevo_TextChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(277, 163);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(94, 47);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(203, 94);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(94, 47);
            this.btnAnyadir.TabIndex = 7;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            // 
            // btnEleminarTodo
            // 
            this.btnEleminarTodo.Location = new System.Drawing.Point(345, 94);
            this.btnEleminarTodo.Name = "btnEleminarTodo";
            this.btnEleminarTodo.Size = new System.Drawing.Size(94, 47);
            this.btnEleminarTodo.TabIndex = 8;
            this.btnEleminarTodo.Text = "Eliminar todo";
            this.btnEleminarTodo.UseVisualStyleBackColor = true;
            // 
            // rdbClick1
            // 
            this.rdbClick1.AutoSize = true;
            this.rdbClick1.Location = new System.Drawing.Point(7, 26);
            this.rdbClick1.Name = "rdbClick1";
            this.rdbClick1.Size = new System.Drawing.Size(84, 22);
            this.rdbClick1.TabIndex = 0;
            this.rdbClick1.TabStop = true;
            this.rdbClick1.Text = "Un Click";
            this.rdbClick1.UseVisualStyleBackColor = true;
            this.rdbClick1.CheckedChanged += new System.EventHandler(this.rdbClick1_CheckedChanged);
            // 
            // rdbClick2
            // 
            this.rdbClick2.AutoSize = true;
            this.rdbClick2.Checked = true;
            this.rdbClick2.Location = new System.Drawing.Point(7, 55);
            this.rdbClick2.Name = "rdbClick2";
            this.rdbClick2.Size = new System.Drawing.Size(94, 22);
            this.rdbClick2.TabIndex = 1;
            this.rdbClick2.TabStop = true;
            this.rdbClick2.Text = "Dos Click";
            this.rdbClick2.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(203, 233);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(94, 47);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(345, 233);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(94, 47);
            this.btnIzquierda.TabIndex = 10;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 423);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnEleminarTodo);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txbElementoNuevo);
            this.Controls.Add(this.gbClick);
            this.Controls.Add(this.btnCambiaColor);
            this.Controls.Add(this.btnEliminarSelect);
            this.Controls.Add(this.btnEliminarChecked);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbClick.ResumeLayout(false);
            this.gbClick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnEliminarChecked;
        private System.Windows.Forms.Button btnEliminarSelect;
        private System.Windows.Forms.Button btnCambiaColor;
        private System.Windows.Forms.GroupBox gbClick;
        private System.Windows.Forms.RadioButton rdbClick2;
        private System.Windows.Forms.RadioButton rdbClick1;
        private System.Windows.Forms.TextBox txbElementoNuevo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnEleminarTodo;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
    }
}

