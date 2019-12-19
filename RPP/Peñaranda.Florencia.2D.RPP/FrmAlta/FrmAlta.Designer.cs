namespace FrmAlta
{
    partial class FrmAlta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTransmision = new System.Windows.Forms.ComboBox();
            this.radioButtonMoto = new System.Windows.Forms.RadioButton();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.textBoxCilindrada = new System.Windows.Forms.TextBox();
            this.labelCilindrada = new System.Windows.Forms.Label();
            this.textBoxPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTransmision = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDni);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos dueño";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(83, 79);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(172, 20);
            this.textBoxDni.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(83, 32);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTransmision);
            this.groupBox2.Controls.Add(this.radioButtonMoto);
            this.groupBox2.Controls.Add(this.comboBoxColor);
            this.groupBox2.Controls.Add(this.radioButtonAuto);
            this.groupBox2.Controls.Add(this.textBoxCilindrada);
            this.groupBox2.Controls.Add(this.labelCilindrada);
            this.groupBox2.Controls.Add(this.textBoxPatente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTransmision);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos vehiculo";
            // 
            // comboBoxTransmision
            // 
            this.comboBoxTransmision.FormattingEnabled = true;
            this.comboBoxTransmision.Location = new System.Drawing.Point(128, 137);
            this.comboBoxTransmision.Name = "comboBoxTransmision";
            this.comboBoxTransmision.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTransmision.TabIndex = 5;
            // 
            // radioButtonMoto
            // 
            this.radioButtonMoto.AutoSize = true;
            this.radioButtonMoto.Location = new System.Drawing.Point(206, 106);
            this.radioButtonMoto.Name = "radioButtonMoto";
            this.radioButtonMoto.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMoto.TabIndex = 2;
            this.radioButtonMoto.TabStop = true;
            this.radioButtonMoto.Text = "Moto";
            this.radioButtonMoto.UseVisualStyleBackColor = true;
            this.radioButtonMoto.CheckedChanged += new System.EventHandler(this.RadioButtonMoto_CheckedChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(128, 68);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(127, 21);
            this.comboBoxColor.TabIndex = 4;
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(128, 106);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAuto.TabIndex = 2;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "Auto";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.RadioButtonAuto_CheckedChanged);
            // 
            // textBoxCilindrada
            // 
            this.textBoxCilindrada.Location = new System.Drawing.Point(128, 172);
            this.textBoxCilindrada.Name = "textBoxCilindrada";
            this.textBoxCilindrada.Size = new System.Drawing.Size(127, 20);
            this.textBoxCilindrada.TabIndex = 3;
            // 
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.Location = new System.Drawing.Point(16, 179);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(76, 13);
            this.labelCilindrada.TabIndex = 5;
            this.labelCilindrada.Text = "Cilindrada (CC)";
            // 
            // textBoxPatente
            // 
            this.textBoxPatente.Location = new System.Drawing.Point(128, 36);
            this.textBoxPatente.Name = "textBoxPatente";
            this.textBoxPatente.Size = new System.Drawing.Size(127, 20);
            this.textBoxPatente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patente Vehiculo";
            // 
            // labelTransmision
            // 
            this.labelTransmision.AutoSize = true;
            this.labelTransmision.Location = new System.Drawing.Point(16, 145);
            this.labelTransmision.Name = "labelTransmision";
            this.labelTransmision.Size = new System.Drawing.Size(63, 13);
            this.labelTransmision.TabIndex = 4;
            this.labelTransmision.Text = "Transmision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo vehiculo";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(43, 438);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(88, 38);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(192, 438);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 38);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 498);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAlta";
            this.Text = "Alta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlta_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTransmision;
        private System.Windows.Forms.Label labelCilindrada;
        private System.Windows.Forms.RadioButton radioButtonMoto;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.TextBox textBoxCilindrada;
        private System.Windows.Forms.TextBox textBoxPatente;
        private System.Windows.Forms.ComboBox comboBoxTransmision;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}

