namespace ProjectoOpenSaveFileDialog
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofdialog = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.chlbListaCargada = new System.Windows.Forms.CheckedListBox();
            this.chlbListaGuardar = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sfdialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(40, 40);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(125, 34);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir lista";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdialog
            // 
            this.ofdialog.InitialDirectory = "C:\\Program Files";
            this.ofdialog.Title = "Buscar lista de texto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(415, 40);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar lista";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(288, 207);
            this.btnAnyadir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(83, 34);
            this.btnAnyadir.TabIndex = 2;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            // 
            // chlbListaCargada
            // 
            this.chlbListaCargada.FormattingEnabled = true;
            this.chlbListaCargada.Location = new System.Drawing.Point(40, 100);
            this.chlbListaCargada.Name = "chlbListaCargada";
            this.chlbListaCargada.Size = new System.Drawing.Size(200, 298);
            this.chlbListaCargada.TabIndex = 3;
            // 
            // chlbListaGuardar
            // 
            this.chlbListaGuardar.FormattingEnabled = true;
            this.chlbListaGuardar.Location = new System.Drawing.Point(415, 100);
            this.chlbListaGuardar.Name = "chlbListaGuardar";
            this.chlbListaGuardar.Size = new System.Drawing.Size(200, 298);
            this.chlbListaGuardar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = ">>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = ">>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chlbListaGuardar);
            this.Controls.Add(this.chlbListaCargada);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog ofdialog;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.CheckedListBox chlbListaCargada;
        private System.Windows.Forms.CheckedListBox chlbListaGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdialog;

    }
}

