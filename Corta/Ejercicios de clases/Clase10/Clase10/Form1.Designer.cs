namespace Clase10
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.tbObjetivo = new System.Windows.Forms.TextBox();
            this.mtbCuil = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoEmp = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbBono = new System.Windows.Forms.TextBox();
            this.lbBono = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Objetivo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(47, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(47, 141);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(167, 20);
            this.tbSueldo.TabIndex = 6;
            this.tbSueldo.TextChanged += new System.EventHandler(this.tbSueldo_TextChanged);
            // 
            // tbObjetivo
            // 
            this.tbObjetivo.Location = new System.Drawing.Point(47, 180);
            this.tbObjetivo.Name = "tbObjetivo";
            this.tbObjetivo.Size = new System.Drawing.Size(167, 20);
            this.tbObjetivo.TabIndex = 7;
            this.tbObjetivo.TextChanged += new System.EventHandler(this.tbObjetivo_TextChanged);
            // 
            // mtbCuil
            // 
            this.mtbCuil.Location = new System.Drawing.Point(47, 102);
            this.mtbCuil.Name = "mtbCuil";
            this.mtbCuil.Size = new System.Drawing.Size(167, 20);
            this.mtbCuil.TabIndex = 8;
            this.mtbCuil.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCuil_MaskInputRejected);
            // 
            // cbTipoEmp
            // 
            this.cbTipoEmp.FormattingEnabled = true;
            this.cbTipoEmp.Location = new System.Drawing.Point(47, 12);
            this.cbTipoEmp.Name = "cbTipoEmp";
            this.cbTipoEmp.Size = new System.Drawing.Size(167, 21);
            this.cbTipoEmp.TabIndex = 9;
            this.cbTipoEmp.SelectedIndexChanged += new System.EventHandler(this.cbTipoEmp_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(223, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbBono
            // 
            this.tbBono.Location = new System.Drawing.Point(47, 180);
            this.tbBono.Name = "tbBono";
            this.tbBono.Size = new System.Drawing.Size(167, 20);
            this.tbBono.TabIndex = 11;
            this.tbBono.TextChanged += new System.EventHandler(this.tbBono_TextChanged);
            // 
            // lbBono
            // 
            this.lbBono.AutoSize = true;
            this.lbBono.Location = new System.Drawing.Point(24, 164);
            this.lbBono.Name = "lbBono";
            this.lbBono.Size = new System.Drawing.Size(32, 13);
            this.lbBono.TabIndex = 12;
            this.lbBono.Text = "Bono";
            this.lbBono.Click += new System.EventHandler(this.lbBono_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 225);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(84, 37);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 274);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbBono);
            this.Controls.Add(this.tbBono);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbTipoEmp);
            this.Controls.Add(this.mtbCuil);
            this.Controls.Add(this.tbObjetivo);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.TextBox tbSueldo;
    private System.Windows.Forms.TextBox tbObjetivo;
    private System.Windows.Forms.MaskedTextBox mtbCuil;
    private System.Windows.Forms.ComboBox cbTipoEmp;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.TextBox tbBono;
    private System.Windows.Forms.Label lbBono;
    private System.Windows.Forms.Button btnMostrar;
  }
}

