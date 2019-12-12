namespace Generics
{
    partial class frmEstanteria
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbParametro = new System.Windows.Forms.ComboBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.lblTamano = new System.Windows.Forms.Label();
            this.btnAgregarEstante = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbParametro
            // 
            this.cmbParametro.FormattingEnabled = true;
            this.cmbParametro.Location = new System.Drawing.Point(56, 25);
            this.cmbParametro.Name = "cmbParametro";
            this.cmbParametro.Size = new System.Drawing.Size(166, 21);
            this.cmbParametro.TabIndex = 1;
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(56, 56);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(166, 20);
            this.txtTamano.TabIndex = 2;
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(4, 59);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(46, 13);
            this.lblTamano.TabIndex = 3;
            this.lblTamano.Text = "Tamaño";
            // 
            // btnAgregarEstante
            // 
            this.btnAgregarEstante.Location = new System.Drawing.Point(12, 99);
            this.btnAgregarEstante.Name = "btnAgregarEstante";
            this.btnAgregarEstante.Size = new System.Drawing.Size(97, 32);
            this.btnAgregarEstante.TabIndex = 4;
            this.btnAgregarEstante.Text = "Agregar";
            this.btnAgregarEstante.UseVisualStyleBackColor = true;
            this.btnAgregarEstante.Click += new System.EventHandler(this.btnAgregarEstante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(120, 99);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEstanteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 155);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarEstante);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.cmbParametro);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmEstanteria";
            this.Text = "frmEstanteria";
            this.Load += new System.EventHandler(this.frmEstanteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbParametro;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Button btnAgregarEstante;
        private System.Windows.Forms.Button btnSalir;
    }
}