namespace clase8
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.btEmpresa = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbLegajo = new System.Windows.Forms.Label();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbLegajo = new System.Windows.Forms.TextBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mtbGanancias = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 43);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // btEmpresa
            // 
            this.btEmpresa.Location = new System.Drawing.Point(19, 222);
            this.btEmpresa.Name = "btEmpresa";
            this.btEmpresa.Size = new System.Drawing.Size(97, 41);
            this.btEmpresa.TabIndex = 1;
            this.btEmpresa.Text = "Empresa";
            this.btEmpresa.UseVisualStyleBackColor = true;
            this.btEmpresa.Click += new System.EventHandler(this.btEmpresa_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(173, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(16, 77);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido";
            // 
            // lbLegajo
            // 
            this.lbLegajo.AutoSize = true;
            this.lbLegajo.Location = new System.Drawing.Point(16, 107);
            this.lbLegajo.Name = "lbLegajo";
            this.lbLegajo.Size = new System.Drawing.Size(39, 13);
            this.lbLegajo.TabIndex = 4;
            this.lbLegajo.Text = "Legajo";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(16, 142);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(40, 13);
            this.lbPuesto.TabIndex = 5;
            this.lbPuesto.Text = "Puesto";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(17, 169);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(58, 13);
            this.lbSalario.TabIndex = 6;
            this.lbSalario.Text = "Ganancias";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(173, 74);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(165, 20);
            this.tbApellido.TabIndex = 7;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // tbLegajo
            // 
            this.tbLegajo.Location = new System.Drawing.Point(173, 104);
            this.tbLegajo.Name = "tbLegajo";
            this.tbLegajo.Size = new System.Drawing.Size(165, 20);
            this.tbLegajo.TabIndex = 8;
            this.tbLegajo.TextChanged += new System.EventHandler(this.tbLegajo_TextChanged);
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(173, 139);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(165, 21);
            this.cbPuesto.TabIndex = 10;
            this.cbPuesto.SelectedIndexChanged += new System.EventHandler(this.cbPuesto_SelectedIndexChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(138, 222);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(97, 41);
            this.btLimpiar.TabIndex = 11;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(241, 222);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(97, 41);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 269);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 247);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // mtbGanancias
            // 
            this.mtbGanancias.Location = new System.Drawing.Point(173, 166);
            this.mtbGanancias.Name = "mtbGanancias";
            this.mtbGanancias.Size = new System.Drawing.Size(100, 20);
            this.mtbGanancias.TabIndex = 14;
            this.mtbGanancias.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbGanancias_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 528);
            this.Controls.Add(this.mtbGanancias);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.tbLegajo);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.lbLegajo);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btEmpresa);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btEmpresa;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbLegajo;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbLegajo;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox mtbGanancias;
    }
}

