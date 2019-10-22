namespace FormSistemaSolar
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
            this.lblNombrePlaneta = new System.Windows.Forms.Label();
            this.lblOrbitaPlaneta = new System.Windows.Forms.Label();
            this.lblRotacionPlaneta = new System.Windows.Forms.Label();
            this.lblLunas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblNombreSatelite = new System.Windows.Forms.Label();
            this.lblOrbitaSatelite = new System.Windows.Forms.Label();
            this.lblRotacionSatelite = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionPlaneta = new System.Windows.Forms.NumericUpDown();
            this.numLunas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePlaneta
            // 
            this.lblNombrePlaneta.AutoSize = true;
            this.lblNombrePlaneta.Location = new System.Drawing.Point(12, 42);
            this.lblNombrePlaneta.Name = "lblNombrePlaneta";
            this.lblNombrePlaneta.Size = new System.Drawing.Size(99, 13);
            this.lblNombrePlaneta.TabIndex = 0;
            this.lblNombrePlaneta.Text = "Nombre del planeta";
            // 
            // lblOrbitaPlaneta
            // 
            this.lblOrbitaPlaneta.AutoSize = true;
            this.lblOrbitaPlaneta.Location = new System.Drawing.Point(12, 68);
            this.lblOrbitaPlaneta.Name = "lblOrbitaPlaneta";
            this.lblOrbitaPlaneta.Size = new System.Drawing.Size(135, 13);
            this.lblOrbitaPlaneta.TabIndex = 1;
            this.lblOrbitaPlaneta.Text = "Tiempo en completar orbita";
            // 
            // lblRotacionPlaneta
            // 
            this.lblRotacionPlaneta.AutoSize = true;
            this.lblRotacionPlaneta.Location = new System.Drawing.Point(12, 97);
            this.lblRotacionPlaneta.Name = "lblRotacionPlaneta";
            this.lblRotacionPlaneta.Size = new System.Drawing.Size(147, 13);
            this.lblRotacionPlaneta.TabIndex = 2;
            this.lblRotacionPlaneta.Text = "Tiempo en completar rotacion";
            // 
            // lblLunas
            // 
            this.lblLunas.AutoSize = true;
            this.lblLunas.Location = new System.Drawing.Point(12, 123);
            this.lblLunas.Name = "lblLunas";
            this.lblLunas.Size = new System.Drawing.Size(92, 13);
            this.lblLunas.TabIndex = 3;
            this.lblLunas.Text = "Cantidad de lunas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 150);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(81, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de planeta";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(275, 42);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(43, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta";
            // 
            // lblNombreSatelite
            // 
            this.lblNombreSatelite.AutoSize = true;
            this.lblNombreSatelite.Location = new System.Drawing.Point(275, 68);
            this.lblNombreSatelite.Name = "lblNombreSatelite";
            this.lblNombreSatelite.Size = new System.Drawing.Size(97, 13);
            this.lblNombreSatelite.TabIndex = 6;
            this.lblNombreSatelite.Text = "Nombre del satelite";
            // 
            // lblOrbitaSatelite
            // 
            this.lblOrbitaSatelite.AutoSize = true;
            this.lblOrbitaSatelite.Location = new System.Drawing.Point(275, 95);
            this.lblOrbitaSatelite.Name = "lblOrbitaSatelite";
            this.lblOrbitaSatelite.Size = new System.Drawing.Size(135, 13);
            this.lblOrbitaSatelite.TabIndex = 7;
            this.lblOrbitaSatelite.Text = "Tiempo en completar orbita";
            // 
            // lblRotacionSatelite
            // 
            this.lblRotacionSatelite.AutoSize = true;
            this.lblRotacionSatelite.Location = new System.Drawing.Point(275, 121);
            this.lblRotacionSatelite.Name = "lblRotacionSatelite";
            this.lblRotacionSatelite.Size = new System.Drawing.Size(147, 13);
            this.lblRotacionSatelite.TabIndex = 8;
            this.lblRotacionSatelite.Text = "Tiempo en completar rotacion";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(169, 35);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePlaneta.TabIndex = 9;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(169, 61);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(100, 20);
            this.txtOrbitaPlaneta.TabIndex = 10;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(431, 61);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSatelite.TabIndex = 11;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(431, 34);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(100, 21);
            this.cmbPlaneta.TabIndex = 12;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(169, 142);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 21);
            this.cmbTipo.TabIndex = 13;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(431, 88);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(100, 20);
            this.numOrbitaSatelite.TabIndex = 14;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(431, 114);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(100, 20);
            this.numRotacionSatelite.TabIndex = 15;
            // 
            // numRotacionPlaneta
            // 
            this.numRotacionPlaneta.Location = new System.Drawing.Point(169, 90);
            this.numRotacionPlaneta.Name = "numRotacionPlaneta";
            this.numRotacionPlaneta.Size = new System.Drawing.Size(100, 20);
            this.numRotacionPlaneta.TabIndex = 16;
            // 
            // numLunas
            // 
            this.numLunas.Location = new System.Drawing.Point(169, 116);
            this.numLunas.Name = "numLunas";
            this.numLunas.Size = new System.Drawing.Size(100, 20);
            this.numLunas.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar Planeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(278, 193);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(253, 23);
            this.btnAgregarSatelite.TabIndex = 19;
            this.btnAgregarSatelite.Text = "Agregar Satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(15, 222);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(516, 23);
            this.btnMostrarInfo.TabIndex = 20;
            this.btnMostrarInfo.Text = "Mostrar informacion";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(15, 251);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(516, 23);
            this.btnMoverAstros.TabIndex = 21;
            this.btnMoverAstros.Text = "Mover Astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.btnMoverAstros_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(537, 34);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(231, 240);
            this.richTextBox.TabIndex = 22;
            this.richTextBox.Text = "";
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 287);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numLunas);
            this.Controls.Add(this.numRotacionPlaneta);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.lblRotacionSatelite);
            this.Controls.Add(this.lblOrbitaSatelite);
            this.Controls.Add(this.lblNombreSatelite);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblLunas);
            this.Controls.Add(this.lblRotacionPlaneta);
            this.Controls.Add(this.lblOrbitaPlaneta);
            this.Controls.Add(this.lblNombrePlaneta);
            this.Name = "FormSistemaSolar";
            this.Text = "Peñaranda Florencia";
            this.Load += new System.EventHandler(this.FormSistemaSolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlaneta;
        private System.Windows.Forms.Label lblOrbitaPlaneta;
        private System.Windows.Forms.Label lblRotacionPlaneta;
        private System.Windows.Forms.Label lblLunas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblNombreSatelite;
        private System.Windows.Forms.Label lblOrbitaSatelite;
        private System.Windows.Forms.Label lblRotacionSatelite;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionPlaneta;
        private System.Windows.Forms.NumericUpDown numLunas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

