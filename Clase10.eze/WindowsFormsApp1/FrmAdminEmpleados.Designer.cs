﻿namespace WindowsFormsApp1
{
    partial class FrmAdminEmpleados
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
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblBono = new System.Windows.Forms.Label();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(44, 21);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEmpleado.TabIndex = 0;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(45, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuil";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(48, 124);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 4;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(30, 156);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 5;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(48, 181);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 6;
            // 
            // lblBono
            // 
            this.lblBono.AutoSize = true;
            this.lblBono.Location = new System.Drawing.Point(27, 214);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(32, 13);
            this.lblBono.TabIndex = 7;
            this.lblBono.Text = "Bono";
            this.lblBono.Visible = false;
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(48, 230);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(100, 20);
            this.txtBono.TabIndex = 8;
            this.txtBono.Visible = false;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(30, 214);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(46, 13);
            this.lblObjetivo.TabIndex = 9;
            this.lblObjetivo.Text = "Objetivo";
            this.lblObjetivo.Visible = false;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(48, 230);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(100, 20);
            this.txtObjetivo.TabIndex = 10;
            this.txtObjetivo.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(191, 270);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(30, 270);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 33);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(191, 19);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 13;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // FrmAdminEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(278, 317);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.lblBono);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Name = "FrmAdminEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAdminEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblBono;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAumentar;
    }
}

