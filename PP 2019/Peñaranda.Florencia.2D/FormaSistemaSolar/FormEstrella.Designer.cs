namespace FormaSistemaSolar
{
    partial class FormEstrella
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAgregarEstrella;
            this.lblEstrellaNombre = new System.Windows.Forms.Label();
            this.lblOrbitaEstrella = new System.Windows.Forms.Label();
            this.lblRotacionEstrella = new System.Windows.Forms.Label();
            this.lblCantidadPlanetas = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.numRotacionEstrella = new System.Windows.Forms.NumericUpDown();
            this.numPlanetas = new System.Windows.Forms.NumericUpDown();
            this.txtNombreEstrella = new System.Windows.Forms.TextBox();
            this.txtOrbitaEstrella = new System.Windows.Forms.TextBox();
            btnAgregarEstrella = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionEstrella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEstrella
            // 
            btnAgregarEstrella.Location = new System.Drawing.Point(29, 198);
            btnAgregarEstrella.Name = "btnAgregarEstrella";
            btnAgregarEstrella.Size = new System.Drawing.Size(263, 31);
            btnAgregarEstrella.TabIndex = 10;
            btnAgregarEstrella.Text = "Agregar estrella";
            btnAgregarEstrella.UseVisualStyleBackColor = true;
            btnAgregarEstrella.Click += new System.EventHandler(this.btnAgregarEstrella_Click);
            // 
            // lblEstrellaNombre
            // 
            this.lblEstrellaNombre.AutoSize = true;
            this.lblEstrellaNombre.Location = new System.Drawing.Point(26, 30);
            this.lblEstrellaNombre.Name = "lblEstrellaNombre";
            this.lblEstrellaNombre.Size = new System.Drawing.Size(106, 13);
            this.lblEstrellaNombre.TabIndex = 0;
            this.lblEstrellaNombre.Text = "Nombre de la estrella";
            // 
            // lblOrbitaEstrella
            // 
            this.lblOrbitaEstrella.AutoSize = true;
            this.lblOrbitaEstrella.Location = new System.Drawing.Point(26, 61);
            this.lblOrbitaEstrella.Name = "lblOrbitaEstrella";
            this.lblOrbitaEstrella.Size = new System.Drawing.Size(137, 13);
            this.lblOrbitaEstrella.TabIndex = 1;
            this.lblOrbitaEstrella.Text = "Tiempo en completar Orbita";
            // 
            // lblRotacionEstrella
            // 
            this.lblRotacionEstrella.AutoSize = true;
            this.lblRotacionEstrella.Location = new System.Drawing.Point(26, 93);
            this.lblRotacionEstrella.Name = "lblRotacionEstrella";
            this.lblRotacionEstrella.Size = new System.Drawing.Size(147, 13);
            this.lblRotacionEstrella.TabIndex = 2;
            this.lblRotacionEstrella.Text = "Tiempo en completar rotacion";
            // 
            // lblCantidadPlanetas
            // 
            this.lblCantidadPlanetas.AutoSize = true;
            this.lblCantidadPlanetas.Location = new System.Drawing.Point(26, 121);
            this.lblCantidadPlanetas.Name = "lblCantidadPlanetas";
            this.lblCantidadPlanetas.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadPlanetas.TabIndex = 3;
            this.lblCantidadPlanetas.Text = "Cantidad planetas";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(26, 151);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 4;
            this.lblClase.Text = "Clase";
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(191, 143);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(100, 21);
            this.cmbClase.TabIndex = 5;
            // 
            // numRotacionEstrella
            // 
            this.numRotacionEstrella.Location = new System.Drawing.Point(191, 86);
            this.numRotacionEstrella.Name = "numRotacionEstrella";
            this.numRotacionEstrella.Size = new System.Drawing.Size(101, 20);
            this.numRotacionEstrella.TabIndex = 6;
            // 
            // numPlanetas
            // 
            this.numPlanetas.Location = new System.Drawing.Point(192, 114);
            this.numPlanetas.Name = "numPlanetas";
            this.numPlanetas.Size = new System.Drawing.Size(100, 20);
            this.numPlanetas.TabIndex = 7;
            // 
            // txtNombreEstrella
            // 
            this.txtNombreEstrella.Location = new System.Drawing.Point(192, 23);
            this.txtNombreEstrella.Name = "txtNombreEstrella";
            this.txtNombreEstrella.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEstrella.TabIndex = 8;
            // 
            // txtOrbitaEstrella
            // 
            this.txtOrbitaEstrella.Location = new System.Drawing.Point(191, 54);
            this.txtOrbitaEstrella.Name = "txtOrbitaEstrella";
            this.txtOrbitaEstrella.Size = new System.Drawing.Size(100, 20);
            this.txtOrbitaEstrella.TabIndex = 9;
            // 
            // FormEstrella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 264);
            this.Controls.Add(btnAgregarEstrella);
            this.Controls.Add(this.txtOrbitaEstrella);
            this.Controls.Add(this.txtNombreEstrella);
            this.Controls.Add(this.numPlanetas);
            this.Controls.Add(this.numRotacionEstrella);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.lblCantidadPlanetas);
            this.Controls.Add(this.lblRotacionEstrella);
            this.Controls.Add(this.lblOrbitaEstrella);
            this.Controls.Add(this.lblEstrellaNombre);
            this.Name = "FormEstrella";
            this.Text = "SistemaSolar";
            this.Load += new System.EventHandler(this.FormEstrella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionEstrella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstrellaNombre;
        private System.Windows.Forms.Label lblOrbitaEstrella;
        private System.Windows.Forms.Label lblRotacionEstrella;
        private System.Windows.Forms.Label lblCantidadPlanetas;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.NumericUpDown numRotacionEstrella;
        private System.Windows.Forms.NumericUpDown numPlanetas;
        private System.Windows.Forms.TextBox txtNombreEstrella;
        private System.Windows.Forms.TextBox txtOrbitaEstrella;
    }
}