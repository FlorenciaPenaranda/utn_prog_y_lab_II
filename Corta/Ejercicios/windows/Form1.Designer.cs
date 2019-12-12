namespace windows
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
            this.LbName = new System.Windows.Forms.Label();
            this.LbApellido = new System.Windows.Forms.Label();
            this.LbDni = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.ckVive = new System.Windows.Forms.CheckBox();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.gbsexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(68, 35);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(44, 13);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "Nombre";
            this.LbName.Click += new System.EventHandler(this.LbName_Click);
            // 
            // LbApellido
            // 
            this.LbApellido.AutoSize = true;
            this.LbApellido.Location = new System.Drawing.Point(68, 70);
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(44, 13);
            this.LbApellido.TabIndex = 1;
            this.LbApellido.Text = "Apellido";
            this.LbApellido.Click += new System.EventHandler(this.LbApellido_Click);
            // 
            // LbDni
            // 
            this.LbDni.AutoSize = true;
            this.LbDni.Location = new System.Drawing.Point(68, 109);
            this.LbDni.Name = "LbDni";
            this.LbDni.Size = new System.Drawing.Size(23, 13);
            this.LbDni.TabIndex = 2;
            this.LbDni.Text = "Dni";
            this.LbDni.Click += new System.EventHandler(this.LbDni_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 38);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(71, 321);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(224, 32);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar personas";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ckVive
            // 
            this.ckVive.AutoSize = true;
            this.ckVive.Location = new System.Drawing.Point(77, 231);
            this.ckVive.Name = "ckVive";
            this.ckVive.Size = new System.Drawing.Size(54, 17);
            this.ckVive.TabIndex = 9;
            this.ckVive.Text = "Vivis?";
            this.ckVive.UseVisualStyleBackColor = true;
            this.ckVive.CheckedChanged += new System.EventHandler(this.ckVive_CheckedChanged);
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.radioButton2);
            this.gbsexo.Controls.Add(this.radioButton1);
            this.gbsexo.Controls.Add(this.groupBox2);
            this.gbsexo.Location = new System.Drawing.Point(71, 140);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(98, 85);
            this.gbsexo.TabIndex = 10;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo :";
            this.gbsexo.Enter += new System.EventHandler(this.gbsexo_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(145, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 23);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mujer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "CABA",
            "LANUS",
            "AVELLANEDA",
            "NOSE"});
            this.cbProvincia.Location = new System.Drawing.Point(175, 140);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cbProvincia.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 379);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.gbsexo);
            this.Controls.Add(this.ckVive);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.LbDni);
            this.Controls.Add(this.LbApellido);
            this.Controls.Add(this.LbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LbName;
    private System.Windows.Forms.Label LbApellido;
    private System.Windows.Forms.Label LbDni;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.CheckBox ckVive;
    private System.Windows.Forms.GroupBox gbsexo;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.ComboBox cbProvincia;
  }
}

