namespace FormParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.numRotacionPlaneta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTiempoOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.numCantLunasPlaneta = new System.Windows.Forms.NumericUpDown();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.numTiempoRotacSatelite = new System.Windows.Forms.NumericUpDown();
            this.numTiempoCompOrbitaSat = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnInfo_Click = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.cmbTipoPlaneta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantLunasPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoRotacSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoCompOrbitaSat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del planeta :";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(180, 18);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(120, 20);
            this.txtNombrePlaneta.TabIndex = 1;
            // 
            // numRotacionPlaneta
            // 
            this.numRotacionPlaneta.Location = new System.Drawing.Point(180, 81);
            this.numRotacionPlaneta.Name = "numRotacionPlaneta";
            this.numRotacionPlaneta.Size = new System.Drawing.Size(120, 20);
            this.numRotacionPlaneta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo en completar orbita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo en completar rotacion:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de lunas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Planeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Planeta : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre de satelite:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tiempo en completar orbita:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tiempo en completar rotacion:\r\n";
            // 
            // txtTiempoOrbitaPlaneta
            // 
            this.txtTiempoOrbitaPlaneta.Location = new System.Drawing.Point(180, 52);
            this.txtTiempoOrbitaPlaneta.Name = "txtTiempoOrbitaPlaneta";
            this.txtTiempoOrbitaPlaneta.Size = new System.Drawing.Size(120, 20);
            this.txtTiempoOrbitaPlaneta.TabIndex = 11;
            // 
            // numCantLunasPlaneta
            // 
            this.numCantLunasPlaneta.Location = new System.Drawing.Point(180, 112);
            this.numCantLunasPlaneta.Name = "numCantLunasPlaneta";
            this.numCantLunasPlaneta.Size = new System.Drawing.Size(120, 20);
            this.numCantLunasPlaneta.TabIndex = 12;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(507, 52);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(120, 20);
            this.txtNombreSatelite.TabIndex = 15;
            // 
            // numTiempoRotacSatelite
            // 
            this.numTiempoRotacSatelite.Location = new System.Drawing.Point(507, 81);
            this.numTiempoRotacSatelite.Name = "numTiempoRotacSatelite";
            this.numTiempoRotacSatelite.Size = new System.Drawing.Size(120, 20);
            this.numTiempoRotacSatelite.TabIndex = 16;
            // 
            // numTiempoCompOrbitaSat
            // 
            this.numTiempoCompOrbitaSat.Location = new System.Drawing.Point(507, 112);
            this.numTiempoCompOrbitaSat.Name = "numTiempoCompOrbitaSat";
            this.numTiempoCompOrbitaSat.Size = new System.Drawing.Size(120, 20);
            this.numTiempoCompOrbitaSat.TabIndex = 17;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(26, 182);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(274, 38);
            this.btnAgregarPlaneta.TabIndex = 18;
            this.btnAgregarPlaneta.Text = "Agregar Planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.btnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(337, 182);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(290, 38);
            this.btnAgregarSatelite.TabIndex = 19;
            this.btnAgregarSatelite.Text = "Agregar Satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnInfo_Click
            // 
            this.btnInfo_Click.Location = new System.Drawing.Point(26, 226);
            this.btnInfo_Click.Name = "btnInfo_Click";
            this.btnInfo_Click.Size = new System.Drawing.Size(601, 38);
            this.btnInfo_Click.TabIndex = 20;
            this.btnInfo_Click.Text = "Mostrar Informacion";
            this.btnInfo_Click.UseVisualStyleBackColor = true;
            this.btnInfo_Click.Click += new System.EventHandler(this.btnInfo_Click_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(26, 270);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(601, 38);
            this.btnMoverAstros.TabIndex = 21;
            this.btnMoverAstros.Text = "Mover Astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.btnMoverAstros_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(633, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 296);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(507, 22);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaneta.TabIndex = 23;
            // 
            // cmbTipoPlaneta
            // 
            this.cmbTipoPlaneta.FormattingEnabled = true;
            this.cmbTipoPlaneta.Location = new System.Drawing.Point(180, 144);
            this.cmbTipoPlaneta.Name = "cmbTipoPlaneta";
            this.cmbTipoPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPlaneta.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 318);
            this.Controls.Add(this.cmbTipoPlaneta);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo_Click);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.numTiempoCompOrbitaSat);
            this.Controls.Add(this.numTiempoRotacSatelite);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.numCantLunasPlaneta);
            this.Controls.Add(this.txtTiempoOrbitaPlaneta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRotacionPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thiago Tomas Corta 2.D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantLunasPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoRotacSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoCompOrbitaSat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.NumericUpDown numRotacionPlaneta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTiempoOrbitaPlaneta;
        private System.Windows.Forms.NumericUpDown numCantLunasPlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.NumericUpDown numTiempoRotacSatelite;
        private System.Windows.Forms.NumericUpDown numTiempoCompOrbitaSat;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnInfo_Click;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.ComboBox cmbTipoPlaneta;
    }
}

