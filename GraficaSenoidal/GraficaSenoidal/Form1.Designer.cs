namespace GraficaSenoidal
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
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.trkbAmplitud = new System.Windows.Forms.TrackBar();
            this.nudCiclos = new System.Windows.Forms.NumericUpDown();
            this.nudDesfase = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbAmplitud = new System.Windows.Forms.Label();
            this.grbFondo = new System.Windows.Forms.GroupBox();
            this.chbAzul = new System.Windows.Forms.CheckBox();
            this.chbVerde = new System.Windows.Forms.CheckBox();
            this.chbRojo = new System.Windows.Forms.CheckBox();
            this.grbTrazo = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.grbFondo.SuspendLayout();
            this.grbTrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.Location = new System.Drawing.Point(98, 46);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(800, 500);
            this.panelDibujo.TabIndex = 0;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(922, 501);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(84, 45);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // trkbAmplitud
            // 
            this.trkbAmplitud.LargeChange = 10;
            this.trkbAmplitud.Location = new System.Drawing.Point(31, 46);
            this.trkbAmplitud.Maximum = 400;
            this.trkbAmplitud.Name = "trkbAmplitud";
            this.trkbAmplitud.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbAmplitud.Size = new System.Drawing.Size(45, 250);
            this.trkbAmplitud.TabIndex = 2;
            this.trkbAmplitud.ValueChanged += new System.EventHandler(this.trkbAmplitud_ValueChanged);
            // 
            // nudCiclos
            // 
            this.nudCiclos.DecimalPlaces = 1;
            this.nudCiclos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Location = new System.Drawing.Point(23, 363);
            this.nudCiclos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCiclos.Name = "nudCiclos";
            this.nudCiclos.Size = new System.Drawing.Size(54, 26);
            this.nudCiclos.TabIndex = 3;
            this.nudCiclos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCiclos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDesfase
            // 
            this.nudDesfase.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDesfase.Location = new System.Drawing.Point(23, 440);
            this.nudDesfase.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDesfase.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudDesfase.Name = "nudDesfase";
            this.nudDesfase.Size = new System.Drawing.Size(54, 26);
            this.nudDesfase.TabIndex = 4;
            this.nudDesfase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amplitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº Ciclos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "º Desfase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Offset";
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(23, 518);
            this.nudOffset.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(54, 26);
            this.nudOffset.TabIndex = 8;
            this.nudOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(931, 438);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 26);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lbAmplitud
            // 
            this.lbAmplitud.AutoSize = true;
            this.lbAmplitud.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmplitud.Location = new System.Drawing.Point(63, 281);
            this.lbAmplitud.Name = "lbAmplitud";
            this.lbAmplitud.Size = new System.Drawing.Size(14, 15);
            this.lbAmplitud.TabIndex = 11;
            this.lbAmplitud.Text = "0";
            // 
            // grbFondo
            // 
            this.grbFondo.Controls.Add(this.chbAzul);
            this.grbFondo.Controls.Add(this.chbVerde);
            this.grbFondo.Controls.Add(this.chbRojo);
            this.grbFondo.Location = new System.Drawing.Point(904, 265);
            this.grbFondo.Name = "grbFondo";
            this.grbFondo.Size = new System.Drawing.Size(111, 124);
            this.grbFondo.TabIndex = 12;
            this.grbFondo.TabStop = false;
            this.grbFondo.Text = "Fondo";
            // 
            // chbAzul
            // 
            this.chbAzul.AutoSize = true;
            this.chbAzul.Location = new System.Drawing.Point(6, 83);
            this.chbAzul.Name = "chbAzul";
            this.chbAzul.Size = new System.Drawing.Size(62, 23);
            this.chbAzul.TabIndex = 2;
            this.chbAzul.Text = "Azul";
            this.chbAzul.UseVisualStyleBackColor = true;
            // 
            // chbVerde
            // 
            this.chbVerde.AutoSize = true;
            this.chbVerde.Location = new System.Drawing.Point(6, 54);
            this.chbVerde.Name = "chbVerde";
            this.chbVerde.Size = new System.Drawing.Size(72, 23);
            this.chbVerde.TabIndex = 1;
            this.chbVerde.Text = "Verde";
            this.chbVerde.UseVisualStyleBackColor = true;
            // 
            // chbRojo
            // 
            this.chbRojo.AutoSize = true;
            this.chbRojo.Location = new System.Drawing.Point(6, 25);
            this.chbRojo.Name = "chbRojo";
            this.chbRojo.Size = new System.Drawing.Size(64, 23);
            this.chbRojo.TabIndex = 0;
            this.chbRojo.Text = "Rojo";
            this.chbRojo.UseVisualStyleBackColor = true;
            // 
            // grbTrazo
            // 
            this.grbTrazo.Controls.Add(this.panelColor);
            this.grbTrazo.Controls.Add(this.lblColor);
            this.grbTrazo.Controls.Add(this.cbGrosor);
            this.grbTrazo.Location = new System.Drawing.Point(904, 73);
            this.grbTrazo.Name = "grbTrazo";
            this.grbTrazo.Size = new System.Drawing.Size(111, 141);
            this.grbTrazo.TabIndex = 13;
            this.grbTrazo.TabStop = false;
            this.grbTrazo.Text = "Trazo";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(36, 88);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(39, 29);
            this.panelColor.TabIndex = 10;
            this.panelColor.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(32, 66);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 19);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // cbGrosor
            // 
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Location = new System.Drawing.Point(17, 25);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(85, 27);
            this.cbGrosor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 594);
            this.Controls.Add(this.grbTrazo);
            this.Controls.Add(this.grbFondo);
            this.Controls.Add(this.lbAmplitud);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDesfase);
            this.Controls.Add(this.nudCiclos);
            this.Controls.Add(this.trkbAmplitud);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.panelDibujo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.grbFondo.ResumeLayout(false);
            this.grbFondo.PerformLayout();
            this.grbTrazo.ResumeLayout(false);
            this.grbTrazo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.TrackBar trkbAmplitud;
        private System.Windows.Forms.NumericUpDown nudCiclos;
        private System.Windows.Forms.NumericUpDown nudDesfase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lbAmplitud;
        private System.Windows.Forms.GroupBox grbFondo;
        private System.Windows.Forms.CheckBox chbAzul;
        private System.Windows.Forms.CheckBox chbVerde;
        private System.Windows.Forms.CheckBox chbRojo;
        private System.Windows.Forms.GroupBox grbTrazo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

