namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txbRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(22, 22);
            this.txb1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(96, 29);
            this.txb1.TabIndex = 0;
            this.txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(180, 22);
            this.txb2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(96, 29);
            this.txb2.TabIndex = 1;
            this.txb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(132, 17);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(28, 37);
            this.lblOperacion.TabIndex = 2;
            this.lblOperacion.Text = "?";
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(472, 118);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(122, 42);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(340, 118);
            this.btnMult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(122, 42);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(22, 118);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(122, 42);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(156, 118);
            this.btnResta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(122, 42);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "Restar";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(604, 118);
            this.btnMod.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(113, 42);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Modulo";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.Operador_Click);
            // 
            // txbRes
            // 
            this.txbRes.Location = new System.Drawing.Point(408, 22);
            this.txbRes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbRes.Name = "txbRes";
            this.txbRes.Size = new System.Drawing.Size(253, 29);
            this.txbRes.TabIndex = 8;
            this.txbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRes);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Calculadora 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txbRes;
        private System.Windows.Forms.Label label1;
    }
}

