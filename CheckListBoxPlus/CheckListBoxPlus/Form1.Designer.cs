namespace CheckListBoxPlus
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
            this.chlbEquipos = new System.Windows.Forms.CheckedListBox();
            this.grbNumClics = new System.Windows.Forms.GroupBox();
            this.rbDosClic = new System.Windows.Forms.RadioButton();
            this.rbUnClic = new System.Windows.Forms.RadioButton();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.chbMultiColum = new System.Windows.Forms.CheckBox();
            this.chbOrdenar = new System.Windows.Forms.CheckBox();
            this.btnBorrarChecked = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.grbNumClics.SuspendLayout();
            this.SuspendLayout();
            // 
            // chlbEquipos
            // 
            this.chlbEquipos.CheckOnClick = true;
            this.chlbEquipos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlbEquipos.FormattingEnabled = true;
            this.chlbEquipos.Location = new System.Drawing.Point(26, 127);
            this.chlbEquipos.Margin = new System.Windows.Forms.Padding(4);
            this.chlbEquipos.Name = "chlbEquipos";
            this.chlbEquipos.Size = new System.Drawing.Size(354, 151);
            this.chlbEquipos.TabIndex = 0;
            // 
            // grbNumClics
            // 
            this.grbNumClics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbNumClics.Controls.Add(this.rbDosClic);
            this.grbNumClics.Controls.Add(this.rbUnClic);
            this.grbNumClics.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNumClics.Location = new System.Drawing.Point(26, 361);
            this.grbNumClics.Margin = new System.Windows.Forms.Padding(4);
            this.grbNumClics.Name = "grbNumClics";
            this.grbNumClics.Padding = new System.Windows.Forms.Padding(4);
            this.grbNumClics.Size = new System.Drawing.Size(159, 121);
            this.grbNumClics.TabIndex = 1;
            this.grbNumClics.TabStop = false;
            this.grbNumClics.Text = "Clics";
            // 
            // rbDosClic
            // 
            this.rbDosClic.AutoSize = true;
            this.rbDosClic.Location = new System.Drawing.Point(26, 61);
            this.rbDosClic.Margin = new System.Windows.Forms.Padding(4);
            this.rbDosClic.Name = "rbDosClic";
            this.rbDosClic.Size = new System.Drawing.Size(82, 22);
            this.rbDosClic.TabIndex = 1;
            this.rbDosClic.Text = "Dos clic";
            this.rbDosClic.UseVisualStyleBackColor = true;
            this.rbDosClic.CheckedChanged += new System.EventHandler(this.rbDosClic_CheckedChanged);
            // 
            // rbUnClic
            // 
            this.rbUnClic.AutoSize = true;
            this.rbUnClic.Checked = true;
            this.rbUnClic.Location = new System.Drawing.Point(26, 28);
            this.rbUnClic.Margin = new System.Windows.Forms.Padding(4);
            this.rbUnClic.Name = "rbUnClic";
            this.rbUnClic.Size = new System.Drawing.Size(72, 22);
            this.rbUnClic.TabIndex = 0;
            this.rbUnClic.TabStop = true;
            this.rbUnClic.Text = "Un clic";
            this.rbUnClic.UseVisualStyleBackColor = true;
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.Location = new System.Drawing.Point(26, 49);
            this.tbNombreEquipo.MaxLength = 20;
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(159, 26);
            this.tbNombreEquipo.TabIndex = 2;
            this.tbNombreEquipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombreEquipo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F);
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del equipo a añadir";
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(26, 82);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(159, 27);
            this.btnAnyadir.TabIndex = 4;
            this.btnAnyadir.Text = "Añadir Equipo";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // chbMultiColum
            // 
            this.chbMultiColum.AutoSize = true;
            this.chbMultiColum.Location = new System.Drawing.Point(237, 361);
            this.chbMultiColum.Name = "chbMultiColum";
            this.chbMultiColum.Size = new System.Drawing.Size(100, 22);
            this.chbMultiColum.TabIndex = 5;
            this.chbMultiColum.Text = "Multicolum";
            this.chbMultiColum.UseVisualStyleBackColor = true;
            this.chbMultiColum.CheckedChanged += new System.EventHandler(this.chbMultiColum_CheckedChanged);
            // 
            // chbOrdenar
            // 
            this.chbOrdenar.AutoSize = true;
            this.chbOrdenar.Location = new System.Drawing.Point(237, 422);
            this.chbOrdenar.Name = "chbOrdenar";
            this.chbOrdenar.Size = new System.Drawing.Size(143, 22);
            this.chbOrdenar.TabIndex = 6;
            this.chbOrdenar.Text = "Orden Alfabético";
            this.chbOrdenar.UseVisualStyleBackColor = true;
            this.chbOrdenar.CheckedChanged += new System.EventHandler(this.btnOrdenar_CheckedChanged);
            // 
            // btnBorrarChecked
            // 
            this.btnBorrarChecked.Location = new System.Drawing.Point(26, 302);
            this.btnBorrarChecked.Name = "btnBorrarChecked";
            this.btnBorrarChecked.Size = new System.Drawing.Size(159, 27);
            this.btnBorrarChecked.TabIndex = 7;
            this.btnBorrarChecked.Text = "Eliminar Seleccion";
            this.btnBorrarChecked.UseVisualStyleBackColor = true;
            this.btnBorrarChecked.Click += new System.EventHandler(this.btnBorrarChecked_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(221, 302);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(159, 27);
            this.btnInvertir.TabIndex = 8;
            this.btnInvertir.Text = "Invertir Seleccion";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 547);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnBorrarChecked);
            this.Controls.Add(this.chbOrdenar);
            this.Controls.Add(this.chbMultiColum);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreEquipo);
            this.Controls.Add(this.grbNumClics);
            this.Controls.Add(this.chlbEquipos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNumClics.ResumeLayout(false);
            this.grbNumClics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbEquipos;
        private System.Windows.Forms.GroupBox grbNumClics;
        private System.Windows.Forms.RadioButton rbDosClic;
        private System.Windows.Forms.RadioButton rbUnClic;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.CheckBox chbMultiColum;
        private System.Windows.Forms.CheckBox chbOrdenar;
        private System.Windows.Forms.Button btnBorrarChecked;
        private System.Windows.Forms.Button btnInvertir;
    }
}

