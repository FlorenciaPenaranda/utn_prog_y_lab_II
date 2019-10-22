namespace FormaSistemaSolar
{
    partial class FormSistemaSolar
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
            this.lblPlanetaNombre = new System.Windows.Forms.Label();
            this.lblOrbitaPlaneta = new System.Windows.Forms.Label();
            this.lblRotacionPlaneta = new System.Windows.Forms.Label();
            this.lblLunas = new System.Windows.Forms.Label();
            this.lblPlanetaTipo = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblSateliteNombre = new System.Windows.Forms.Label();
            this.lblOrbtiaSatelite = new System.Windows.Forms.Label();
            this.lblRotacionSatelite = new System.Windows.Forms.Label();
            this.txtPlanetaNombre = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtSateliteNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownRotacionPlaneta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLunas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoPlaneta = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaneta = new System.Windows.Forms.ComboBox();
            this.buttonAgregarPlaneta = new System.Windows.Forms.Button();
            this.buttonAgregarSatelite = new System.Windows.Forms.Button();
            this.buttonMostrarInfo = new System.Windows.Forms.Button();
            this.buttonMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotacionPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanetaNombre
            // 
            this.lblPlanetaNombre.AutoSize = true;
            this.lblPlanetaNombre.Location = new System.Drawing.Point(12, 41);
            this.lblPlanetaNombre.Name = "lblPlanetaNombre";
            this.lblPlanetaNombre.Size = new System.Drawing.Size(99, 13);
            this.lblPlanetaNombre.TabIndex = 0;
            this.lblPlanetaNombre.Text = "Nombre del planeta";
            // 
            // lblOrbitaPlaneta
            // 
            this.lblOrbitaPlaneta.AutoSize = true;
            this.lblOrbitaPlaneta.Location = new System.Drawing.Point(12, 66);
            this.lblOrbitaPlaneta.Name = "lblOrbitaPlaneta";
            this.lblOrbitaPlaneta.Size = new System.Drawing.Size(135, 13);
            this.lblOrbitaPlaneta.TabIndex = 1;
            this.lblOrbitaPlaneta.Text = "Tiempo en completar orbita";
            // 
            // lblRotacionPlaneta
            // 
            this.lblRotacionPlaneta.AutoSize = true;
            this.lblRotacionPlaneta.Location = new System.Drawing.Point(12, 92);
            this.lblRotacionPlaneta.Name = "lblRotacionPlaneta";
            this.lblRotacionPlaneta.Size = new System.Drawing.Size(147, 13);
            this.lblRotacionPlaneta.TabIndex = 2;
            this.lblRotacionPlaneta.Text = "Tiempo en completar rotacion";
            // 
            // lblLunas
            // 
            this.lblLunas.AutoSize = true;
            this.lblLunas.Location = new System.Drawing.Point(12, 122);
            this.lblLunas.Name = "lblLunas";
            this.lblLunas.Size = new System.Drawing.Size(92, 13);
            this.lblLunas.TabIndex = 3;
            this.lblLunas.Text = "Cantidad de lunas";
            // 
            // lblPlanetaTipo
            // 
            this.lblPlanetaTipo.AutoSize = true;
            this.lblPlanetaTipo.Location = new System.Drawing.Point(12, 150);
            this.lblPlanetaTipo.Name = "lblPlanetaTipo";
            this.lblPlanetaTipo.Size = new System.Drawing.Size(81, 13);
            this.lblPlanetaTipo.TabIndex = 4;
            this.lblPlanetaTipo.Text = "Tipo de planeta";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(309, 41);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(43, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta";
            // 
            // lblSateliteNombre
            // 
            this.lblSateliteNombre.AutoSize = true;
            this.lblSateliteNombre.Location = new System.Drawing.Point(309, 66);
            this.lblSateliteNombre.Name = "lblSateliteNombre";
            this.lblSateliteNombre.Size = new System.Drawing.Size(97, 13);
            this.lblSateliteNombre.TabIndex = 6;
            this.lblSateliteNombre.Text = "Nombre del satelite";
            // 
            // lblOrbtiaSatelite
            // 
            this.lblOrbtiaSatelite.AutoSize = true;
            this.lblOrbtiaSatelite.Location = new System.Drawing.Point(309, 92);
            this.lblOrbtiaSatelite.Name = "lblOrbtiaSatelite";
            this.lblOrbtiaSatelite.Size = new System.Drawing.Size(146, 13);
            this.lblOrbtiaSatelite.TabIndex = 7;
            this.lblOrbtiaSatelite.Text = "Tiempo en completar la orbita";
            // 
            // lblRotacionSatelite
            // 
            this.lblRotacionSatelite.AutoSize = true;
            this.lblRotacionSatelite.Location = new System.Drawing.Point(309, 122);
            this.lblRotacionSatelite.Name = "lblRotacionSatelite";
            this.lblRotacionSatelite.Size = new System.Drawing.Size(147, 13);
            this.lblRotacionSatelite.TabIndex = 8;
            this.lblRotacionSatelite.Text = "Tiempo en completar rotacion";
            // 
            // txtPlanetaNombre
            // 
            this.txtPlanetaNombre.Location = new System.Drawing.Point(162, 33);
            this.txtPlanetaNombre.Name = "txtPlanetaNombre";
            this.txtPlanetaNombre.Size = new System.Drawing.Size(130, 20);
            this.txtPlanetaNombre.TabIndex = 9;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(162, 59);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(130, 20);
            this.txtOrbitaPlaneta.TabIndex = 10;
            // 
            // txtSateliteNombre
            // 
            this.txtSateliteNombre.Location = new System.Drawing.Point(466, 60);
            this.txtSateliteNombre.Name = "txtSateliteNombre";
            this.txtSateliteNombre.Size = new System.Drawing.Size(130, 20);
            this.txtSateliteNombre.TabIndex = 11;
            // 
            // numericUpDownRotacionPlaneta
            // 
            this.numericUpDownRotacionPlaneta.Location = new System.Drawing.Point(162, 85);
            this.numericUpDownRotacionPlaneta.Name = "numericUpDownRotacionPlaneta";
            this.numericUpDownRotacionPlaneta.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownRotacionPlaneta.TabIndex = 12;
            // 
            // numericUpDownLunas
            // 
            this.numericUpDownLunas.Location = new System.Drawing.Point(162, 115);
            this.numericUpDownLunas.Name = "numericUpDownLunas";
            this.numericUpDownLunas.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownLunas.TabIndex = 13;
            // 
            // numericUpDownOrbitaSatelite
            // 
            this.numericUpDownOrbitaSatelite.Location = new System.Drawing.Point(466, 85);
            this.numericUpDownOrbitaSatelite.Name = "numericUpDownOrbitaSatelite";
            this.numericUpDownOrbitaSatelite.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownOrbitaSatelite.TabIndex = 14;
            // 
            // numericUpDownRotacionSatelite
            // 
            this.numericUpDownRotacionSatelite.Location = new System.Drawing.Point(466, 115);
            this.numericUpDownRotacionSatelite.Name = "numericUpDownRotacionSatelite";
            this.numericUpDownRotacionSatelite.Size = new System.Drawing.Size(130, 20);
            this.numericUpDownRotacionSatelite.TabIndex = 15;
            // 
            // comboBoxTipoPlaneta
            // 
            this.comboBoxTipoPlaneta.FormattingEnabled = true;
            this.comboBoxTipoPlaneta.Location = new System.Drawing.Point(162, 142);
            this.comboBoxTipoPlaneta.Name = "comboBoxTipoPlaneta";
            this.comboBoxTipoPlaneta.Size = new System.Drawing.Size(130, 21);
            this.comboBoxTipoPlaneta.TabIndex = 16;
            // 
            // comboBoxPlaneta
            // 
            this.comboBoxPlaneta.FormattingEnabled = true;
            this.comboBoxPlaneta.Location = new System.Drawing.Point(466, 33);
            this.comboBoxPlaneta.Name = "comboBoxPlaneta";
            this.comboBoxPlaneta.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPlaneta.TabIndex = 17;
            // 
            // buttonAgregarPlaneta
            // 
            this.buttonAgregarPlaneta.Location = new System.Drawing.Point(15, 194);
            this.buttonAgregarPlaneta.Name = "buttonAgregarPlaneta";
            this.buttonAgregarPlaneta.Size = new System.Drawing.Size(277, 23);
            this.buttonAgregarPlaneta.TabIndex = 18;
            this.buttonAgregarPlaneta.Text = "Agregar Planeta";
            this.buttonAgregarPlaneta.UseVisualStyleBackColor = true;
            this.buttonAgregarPlaneta.Click += new System.EventHandler(this.buttonAgregarPlaneta_Click);
            // 
            // buttonAgregarSatelite
            // 
            this.buttonAgregarSatelite.Location = new System.Drawing.Point(312, 150);
            this.buttonAgregarSatelite.Name = "buttonAgregarSatelite";
            this.buttonAgregarSatelite.Size = new System.Drawing.Size(284, 23);
            this.buttonAgregarSatelite.TabIndex = 19;
            this.buttonAgregarSatelite.Text = "Agregar Satelite";
            this.buttonAgregarSatelite.UseVisualStyleBackColor = true;
            this.buttonAgregarSatelite.Click += new System.EventHandler(this.buttonAgregarSatelite_Click);
            // 
            // buttonMostrarInfo
            // 
            this.buttonMostrarInfo.Location = new System.Drawing.Point(15, 235);
            this.buttonMostrarInfo.Name = "buttonMostrarInfo";
            this.buttonMostrarInfo.Size = new System.Drawing.Size(581, 23);
            this.buttonMostrarInfo.TabIndex = 20;
            this.buttonMostrarInfo.Text = "Mostrar informacion";
            this.buttonMostrarInfo.UseVisualStyleBackColor = true;
            this.buttonMostrarInfo.Click += new System.EventHandler(this.buttonMostrarInfo_Click);
            // 
            // buttonMoverAstros
            // 
            this.buttonMoverAstros.Location = new System.Drawing.Point(15, 276);
            this.buttonMoverAstros.Name = "buttonMoverAstros";
            this.buttonMoverAstros.Size = new System.Drawing.Size(581, 23);
            this.buttonMoverAstros.TabIndex = 21;
            this.buttonMoverAstros.Text = "Mover Astros";
            this.buttonMoverAstros.UseVisualStyleBackColor = true;
            this.buttonMoverAstros.Click += new System.EventHandler(this.buttonMoverAstros_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(625, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 277);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(312, 194);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(284, 23);
            this.buttonAgregar.TabIndex = 23;
            this.buttonAgregar.Text = "button1";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 316);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonMoverAstros);
            this.Controls.Add(this.buttonMostrarInfo);
            this.Controls.Add(this.buttonAgregarSatelite);
            this.Controls.Add(this.buttonAgregarPlaneta);
            this.Controls.Add(this.comboBoxPlaneta);
            this.Controls.Add(this.comboBoxTipoPlaneta);
            this.Controls.Add(this.numericUpDownRotacionSatelite);
            this.Controls.Add(this.numericUpDownOrbitaSatelite);
            this.Controls.Add(this.numericUpDownLunas);
            this.Controls.Add(this.numericUpDownRotacionPlaneta);
            this.Controls.Add(this.txtSateliteNombre);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtPlanetaNombre);
            this.Controls.Add(this.lblRotacionSatelite);
            this.Controls.Add(this.lblOrbtiaSatelite);
            this.Controls.Add(this.lblSateliteNombre);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblPlanetaTipo);
            this.Controls.Add(this.lblLunas);
            this.Controls.Add(this.lblRotacionPlaneta);
            this.Controls.Add(this.lblOrbitaPlaneta);
            this.Controls.Add(this.lblPlanetaNombre);
            this.Name = "FormSistemaSolar";
            this.Text = "Peñaranda Florencia 2D";
            this.Load += new System.EventHandler(this.FormSistemaSolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotacionPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanetaNombre;
        private System.Windows.Forms.Label lblOrbitaPlaneta;
        private System.Windows.Forms.Label lblRotacionPlaneta;
        private System.Windows.Forms.Label lblLunas;
        private System.Windows.Forms.Label lblPlanetaTipo;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblSateliteNombre;
        private System.Windows.Forms.Label lblOrbtiaSatelite;
        private System.Windows.Forms.Label lblRotacionSatelite;
        private System.Windows.Forms.TextBox txtPlanetaNombre;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.TextBox txtSateliteNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownRotacionPlaneta;
        private System.Windows.Forms.NumericUpDown numericUpDownLunas;
        private System.Windows.Forms.NumericUpDown numericUpDownOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numericUpDownRotacionSatelite;
        private System.Windows.Forms.ComboBox comboBoxTipoPlaneta;
        private System.Windows.Forms.ComboBox comboBoxPlaneta;
        private System.Windows.Forms.Button buttonAgregarPlaneta;
        private System.Windows.Forms.Button buttonAgregarSatelite;
        private System.Windows.Forms.Button buttonMostrarInfo;
        private System.Windows.Forms.Button buttonMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonAgregar;
    }
}

