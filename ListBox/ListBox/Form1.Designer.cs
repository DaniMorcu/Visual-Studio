namespace ListBox
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
            this.lbxEquipos = new System.Windows.Forms.ListBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnBorrarChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxEquipos
            // 
            this.lbxEquipos.FormattingEnabled = true;
            this.lbxEquipos.ItemHeight = 19;
            this.lbxEquipos.Location = new System.Drawing.Point(32, 134);
            this.lbxEquipos.Name = "lbxEquipos";
            this.lbxEquipos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxEquipos.Size = new System.Drawing.Size(159, 213);
            this.lbxEquipos.TabIndex = 0;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(32, 78);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(159, 27);
            this.btnAnyadir.TabIndex = 7;
            this.btnAnyadir.Text = "Añadir Equipo";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F);
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del equipo a añadir";
            // 
            // tbNombreEquipo
            // 
            this.tbNombreEquipo.Location = new System.Drawing.Point(32, 45);
            this.tbNombreEquipo.MaxLength = 20;
            this.tbNombreEquipo.Name = "tbNombreEquipo";
            this.tbNombreEquipo.Size = new System.Drawing.Size(159, 26);
            this.tbNombreEquipo.TabIndex = 5;
            // 
            // btnBorrarChecked
            // 
            this.btnBorrarChecked.Location = new System.Drawing.Point(32, 382);
            this.btnBorrarChecked.Name = "btnBorrarChecked";
            this.btnBorrarChecked.Size = new System.Drawing.Size(159, 27);
            this.btnBorrarChecked.TabIndex = 9;
            this.btnBorrarChecked.Text = "Eliminar Seleccion";
            this.btnBorrarChecked.UseVisualStyleBackColor = true;
            this.btnBorrarChecked.Click += new System.EventHandler(this.btnBorrarChecked_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 458);
            this.Controls.Add(this.btnBorrarChecked);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreEquipo);
            this.Controls.Add(this.lbxEquipos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEquipos;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreEquipo;
        private System.Windows.Forms.Button btnBorrarChecked;
    }
}

