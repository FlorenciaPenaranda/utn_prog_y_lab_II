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
            this.lblTiempoRotacion = new System.Windows.Forms.Label();
            this.lblCantLunas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.lblNombreSatelite = new System.Windows.Forms.Label();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.lblTiempoOrbitaSatelite = new System.Windows.Forms.Label();
            this.lblTiempoRotacionSatelite = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numSatelite = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.btnAbrirVnetana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePlaneta
            // 
            this.lblNombrePlaneta.AutoSize = true;
            this.lblNombrePlaneta.Location = new System.Drawing.Point(12, 26);
            this.lblNombrePlaneta.Name = "lblNombrePlaneta";
            this.lblNombrePlaneta.Size = new System.Drawing.Size(99, 13);
            this.lblNombrePlaneta.TabIndex = 0;
            this.lblNombrePlaneta.Text = "Nombre del planeta";
            // 
            // lblOrbitaPlaneta
            // 
            this.lblOrbitaPlaneta.AutoSize = true;
            this.lblOrbitaPlaneta.Location = new System.Drawing.Point(12, 59);
            this.lblOrbitaPlaneta.Name = "lblOrbitaPlaneta";
            this.lblOrbitaPlaneta.Size = new System.Drawing.Size(135, 13);
            this.lblOrbitaPlaneta.TabIndex = 1;
            this.lblOrbitaPlaneta.Text = "Tiempo en completar orbita";
            // 
            // lblTiempoRotacion
            // 
            this.lblTiempoRotacion.AutoSize = true;
            this.lblTiempoRotacion.Location = new System.Drawing.Point(12, 92);
            this.lblTiempoRotacion.Name = "lblTiempoRotacion";
            this.lblTiempoRotacion.Size = new System.Drawing.Size(150, 13);
            this.lblTiempoRotacion.TabIndex = 2;
            this.lblTiempoRotacion.Text = "Tiempor en completar rotacion";
            // 
            // lblCantLunas
            // 
            this.lblCantLunas.AutoSize = true;
            this.lblCantLunas.Location = new System.Drawing.Point(12, 122);
            this.lblCantLunas.Name = "lblCantLunas";
            this.lblCantLunas.Size = new System.Drawing.Size(92, 13);
            this.lblCantLunas.TabIndex = 3;
            this.lblCantLunas.Text = "Cantidad de lunas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Planeta";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(168, 19);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(156, 20);
            this.txtNombrePlaneta.TabIndex = 1;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(168, 52);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(156, 20);
            this.txtOrbitaPlaneta.TabIndex = 2;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(348, 26);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(43, 13);
            this.lblPlaneta.TabIndex = 7;
            this.lblPlaneta.Text = "Planeta";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(503, 19);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(192, 21);
            this.cmbPlanetas.TabIndex = 7;
            // 
            // lblNombreSatelite
            // 
            this.lblNombreSatelite.AutoSize = true;
            this.lblNombreSatelite.Location = new System.Drawing.Point(348, 59);
            this.lblNombreSatelite.Name = "lblNombreSatelite";
            this.lblNombreSatelite.Size = new System.Drawing.Size(97, 13);
            this.lblNombreSatelite.TabIndex = 0;
            this.lblNombreSatelite.Text = "Nombre del satelite";
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(503, 52);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(192, 20);
            this.txtNombreSatelite.TabIndex = 8;
            // 
            // lblTiempoOrbitaSatelite
            // 
            this.lblTiempoOrbitaSatelite.AutoSize = true;
            this.lblTiempoOrbitaSatelite.Location = new System.Drawing.Point(348, 92);
            this.lblTiempoOrbitaSatelite.Name = "lblTiempoOrbitaSatelite";
            this.lblTiempoOrbitaSatelite.Size = new System.Drawing.Size(149, 13);
            this.lblTiempoOrbitaSatelite.TabIndex = 2;
            this.lblTiempoOrbitaSatelite.Text = "Tiempor en completar la orbita";
            // 
            // lblTiempoRotacionSatelite
            // 
            this.lblTiempoRotacionSatelite.AutoSize = true;
            this.lblTiempoRotacionSatelite.Location = new System.Drawing.Point(348, 129);
            this.lblTiempoRotacionSatelite.Name = "lblTiempoRotacionSatelite";
            this.lblTiempoRotacionSatelite.Size = new System.Drawing.Size(150, 13);
            this.lblTiempoRotacionSatelite.TabIndex = 2;
            this.lblTiempoRotacionSatelite.Text = "Tiempor en completar rotacion";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(168, 148);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(156, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(15, 188);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(305, 32);
            this.btnAgregarPlaneta.TabIndex = 6;
            this.btnAgregarPlaneta.Text = "Agregar Planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.btnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(390, 188);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(305, 32);
            this.btnAgregarSatelite.TabIndex = 11;
            this.btnAgregarSatelite.Text = "Agregar Satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(15, 225);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(680, 42);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "Mostrar Informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(15, 273);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(680, 35);
            this.btnMoverAstros.TabIndex = 13;
            this.btnMoverAstros.Text = "Mover Astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.BtnMoverAstros_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(709, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(285, 292);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.ZoomFactor = 2F;
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(168, 85);
            this.numRotacion.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(152, 20);
            this.numRotacion.TabIndex = 3;
            // 
            // numSatelite
            // 
            this.numSatelite.Location = new System.Drawing.Point(168, 120);
            this.numSatelite.Name = "numSatelite";
            this.numSatelite.Size = new System.Drawing.Size(152, 20);
            this.numSatelite.TabIndex = 4;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(503, 85);
            this.numOrbitaSatelite.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(152, 20);
            this.numOrbitaSatelite.TabIndex = 9;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(503, 122);
            this.numRotacionSatelite.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(152, 20);
            this.numRotacionSatelite.TabIndex = 10;
            // 
            // btnAbrirVnetana
            // 
            this.btnAbrirVnetana.Location = new System.Drawing.Point(15, 314);
            this.btnAbrirVnetana.Name = "btnAbrirVnetana";
            this.btnAbrirVnetana.Size = new System.Drawing.Size(680, 33);
            this.btnAbrirVnetana.TabIndex = 19;
            this.btnAbrirVnetana.Text = "Abrir Ventana Nueva";
            this.btnAbrirVnetana.UseVisualStyleBackColor = true;
            this.btnAbrirVnetana.Click += new System.EventHandler(this.btnAbrirVnetana_Click);
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 371);
            this.Controls.Add(this.btnAbrirVnetana);
            this.Controls.Add(this.numSatelite);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantLunas);
            this.Controls.Add(this.lblTiempoOrbitaSatelite);
            this.Controls.Add(this.lblTiempoRotacionSatelite);
            this.Controls.Add(this.lblTiempoRotacion);
            this.Controls.Add(this.lblOrbitaPlaneta);
            this.Controls.Add(this.lblNombreSatelite);
            this.Controls.Add(this.lblNombrePlaneta);
            this.MaximizeBox = false;
            this.Name = "FormSistemaSolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabian Rolon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlaneta;
        private System.Windows.Forms.Label lblOrbitaPlaneta;
        private System.Windows.Forms.Label lblTiempoRotacion;
        private System.Windows.Forms.Label lblCantLunas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Label lblNombreSatelite;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.Label lblTiempoOrbitaSatelite;
        private System.Windows.Forms.Label lblTiempoRotacionSatelite;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numSatelite;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.Button btnAbrirVnetana;
    }
}

