namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            this.btnMostrarAccion = new System.Windows.Forms.Button();
            this.btnMostrarMsj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarAccion
            // 
            this.btnMostrarAccion.Location = new System.Drawing.Point(49, 37);
            this.btnMostrarAccion.Name = "btnMostrarAccion";
            this.btnMostrarAccion.Size = new System.Drawing.Size(263, 48);
            this.btnMostrarAccion.TabIndex = 0;
            this.btnMostrarAccion.Text = "Mostrar_accion";
            this.btnMostrarAccion.UseVisualStyleBackColor = true;
            this.btnMostrarAccion.Click += new System.EventHandler(this.btnMostrarAccion_Click);
            // 
            // btnMostrarMsj
            // 
            this.btnMostrarMsj.Location = new System.Drawing.Point(49, 109);
            this.btnMostrarMsj.Name = "btnMostrarMsj";
            this.btnMostrarMsj.Size = new System.Drawing.Size(263, 48);
            this.btnMostrarMsj.TabIndex = 1;
            this.btnMostrarMsj.Text = "Mostrar_Msj";
            this.btnMostrarMsj.UseVisualStyleBackColor = true;
            this.btnMostrarMsj.Click += new System.EventHandler(this.btnMostrarMsj_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 201);
            this.Controls.Add(this.btnMostrarMsj);
            this.Controls.Add(this.btnMostrarAccion);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarAccion;
        private System.Windows.Forms.Button btnMostrarMsj;
    }
}

