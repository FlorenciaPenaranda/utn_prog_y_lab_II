namespace WindowsFormsApp1
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
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrecioA = new System.Windows.Forms.TextBox();
            this.textBoxDescrpcionA = new System.Windows.Forms.TextBox();
            this.textBoxCodigoA = new System.Windows.Forms.TextBox();
            this.buttonAgregarA = new System.Windows.Forms.Button();
            this.labelVencimientoA = new System.Windows.Forms.Label();
            this.labelprecioA = new System.Windows.Forms.Label();
            this.labelDescripcionA = new System.Windows.Forms.Label();
            this.labelCodigoA = new System.Windows.Forms.Label();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.textBoxPrecioB = new System.Windows.Forms.TextBox();
            this.textBoxDescrpcionB = new System.Windows.Forms.TextBox();
            this.textBoxCodigoB = new System.Windows.Forms.TextBox();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.buttonAgregarB = new System.Windows.Forms.Button();
            this.labelTamañoB = new System.Windows.Forms.Label();
            this.labelPrecioB = new System.Windows.Forms.Label();
            this.labelDescripcionB = new System.Windows.Forms.Label();
            this.labelCodigoB = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.dateTimePicker);
            this.groupBoxA.Controls.Add(this.textBoxPrecioA);
            this.groupBoxA.Controls.Add(this.textBoxDescrpcionA);
            this.groupBoxA.Controls.Add(this.textBoxCodigoA);
            this.groupBoxA.Controls.Add(this.buttonAgregarA);
            this.groupBoxA.Controls.Add(this.labelVencimientoA);
            this.groupBoxA.Controls.Add(this.labelprecioA);
            this.groupBoxA.Controls.Add(this.labelDescripcionA);
            this.groupBoxA.Controls.Add(this.labelCodigoA);
            this.groupBoxA.Location = new System.Drawing.Point(12, 25);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(385, 213);
            this.groupBoxA.TabIndex = 0;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Producto A";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(112, 135);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // textBoxPrecioA
            // 
            this.textBoxPrecioA.Location = new System.Drawing.Point(112, 105);
            this.textBoxPrecioA.Name = "textBoxPrecioA";
            this.textBoxPrecioA.Size = new System.Drawing.Size(247, 20);
            this.textBoxPrecioA.TabIndex = 8;
            // 
            // textBoxDescrpcionA
            // 
            this.textBoxDescrpcionA.Location = new System.Drawing.Point(112, 67);
            this.textBoxDescrpcionA.Name = "textBoxDescrpcionA";
            this.textBoxDescrpcionA.Size = new System.Drawing.Size(247, 20);
            this.textBoxDescrpcionA.TabIndex = 7;
            // 
            // textBoxCodigoA
            // 
            this.textBoxCodigoA.Location = new System.Drawing.Point(112, 34);
            this.textBoxCodigoA.Name = "textBoxCodigoA";
            this.textBoxCodigoA.Size = new System.Drawing.Size(247, 20);
            this.textBoxCodigoA.TabIndex = 6;
            // 
            // buttonAgregarA
            // 
            this.buttonAgregarA.Location = new System.Drawing.Point(284, 167);
            this.buttonAgregarA.Name = "buttonAgregarA";
            this.buttonAgregarA.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarA.TabIndex = 4;
            this.buttonAgregarA.Text = "Agregar";
            this.buttonAgregarA.UseVisualStyleBackColor = true;
            this.buttonAgregarA.Click += new System.EventHandler(this.buttonAgregarA_Click);
            // 
            // labelVencimientoA
            // 
            this.labelVencimientoA.AutoSize = true;
            this.labelVencimientoA.Location = new System.Drawing.Point(18, 141);
            this.labelVencimientoA.Name = "labelVencimientoA";
            this.labelVencimientoA.Size = new System.Drawing.Size(65, 13);
            this.labelVencimientoA.TabIndex = 3;
            this.labelVencimientoA.Text = "Vencimiento";
            // 
            // labelprecioA
            // 
            this.labelprecioA.AutoSize = true;
            this.labelprecioA.Location = new System.Drawing.Point(18, 108);
            this.labelprecioA.Name = "labelprecioA";
            this.labelprecioA.Size = new System.Drawing.Size(37, 13);
            this.labelprecioA.TabIndex = 2;
            this.labelprecioA.Text = "Precio";
            // 
            // labelDescripcionA
            // 
            this.labelDescripcionA.AutoSize = true;
            this.labelDescripcionA.Location = new System.Drawing.Point(18, 70);
            this.labelDescripcionA.Name = "labelDescripcionA";
            this.labelDescripcionA.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionA.TabIndex = 1;
            this.labelDescripcionA.Text = "Descripción";
            // 
            // labelCodigoA
            // 
            this.labelCodigoA.AutoSize = true;
            this.labelCodigoA.Location = new System.Drawing.Point(18, 37);
            this.labelCodigoA.Name = "labelCodigoA";
            this.labelCodigoA.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoA.TabIndex = 0;
            this.labelCodigoA.Text = "Código";
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.textBoxPrecioB);
            this.groupBoxB.Controls.Add(this.textBoxDescrpcionB);
            this.groupBoxB.Controls.Add(this.textBoxCodigoB);
            this.groupBoxB.Controls.Add(this.cmbTamanio);
            this.groupBoxB.Controls.Add(this.buttonAgregarB);
            this.groupBoxB.Controls.Add(this.labelTamañoB);
            this.groupBoxB.Controls.Add(this.labelPrecioB);
            this.groupBoxB.Controls.Add(this.labelDescripcionB);
            this.groupBoxB.Controls.Add(this.labelCodigoB);
            this.groupBoxB.Location = new System.Drawing.Point(403, 25);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(385, 213);
            this.groupBoxB.TabIndex = 1;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Producto B";
            // 
            // textBoxPrecioB
            // 
            this.textBoxPrecioB.Location = new System.Drawing.Point(107, 105);
            this.textBoxPrecioB.Name = "textBoxPrecioB";
            this.textBoxPrecioB.Size = new System.Drawing.Size(247, 20);
            this.textBoxPrecioB.TabIndex = 8;
            // 
            // textBoxDescrpcionB
            // 
            this.textBoxDescrpcionB.Location = new System.Drawing.Point(107, 67);
            this.textBoxDescrpcionB.Name = "textBoxDescrpcionB";
            this.textBoxDescrpcionB.Size = new System.Drawing.Size(247, 20);
            this.textBoxDescrpcionB.TabIndex = 7;
            // 
            // textBoxCodigoB
            // 
            this.textBoxCodigoB.Location = new System.Drawing.Point(107, 34);
            this.textBoxCodigoB.Name = "textBoxCodigoB";
            this.textBoxCodigoB.Size = new System.Drawing.Size(247, 20);
            this.textBoxCodigoB.TabIndex = 6;
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Location = new System.Drawing.Point(107, 140);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(247, 21);
            this.cmbTamanio.TabIndex = 5;
            
            // 
            // buttonAgregarB
            // 
            this.buttonAgregarB.Location = new System.Drawing.Point(279, 167);
            this.buttonAgregarB.Name = "buttonAgregarB";
            this.buttonAgregarB.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarB.TabIndex = 4;
            this.buttonAgregarB.Text = "Agregar";
            this.buttonAgregarB.UseVisualStyleBackColor = true;
            this.buttonAgregarB.Click += new System.EventHandler(this.buttonAgregarB_Click);
            // 
            // labelTamañoB
            // 
            this.labelTamañoB.AutoSize = true;
            this.labelTamañoB.Location = new System.Drawing.Point(20, 141);
            this.labelTamañoB.Name = "labelTamañoB";
            this.labelTamañoB.Size = new System.Drawing.Size(46, 13);
            this.labelTamañoB.TabIndex = 3;
            this.labelTamañoB.Text = "Tamaño";
            // 
            // labelPrecioB
            // 
            this.labelPrecioB.AutoSize = true;
            this.labelPrecioB.Location = new System.Drawing.Point(20, 108);
            this.labelPrecioB.Name = "labelPrecioB";
            this.labelPrecioB.Size = new System.Drawing.Size(37, 13);
            this.labelPrecioB.TabIndex = 2;
            this.labelPrecioB.Text = "Precio";
            // 
            // labelDescripcionB
            // 
            this.labelDescripcionB.AutoSize = true;
            this.labelDescripcionB.Location = new System.Drawing.Point(20, 70);
            this.labelDescripcionB.Name = "labelDescripcionB";
            this.labelDescripcionB.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionB.TabIndex = 1;
            this.labelDescripcionB.Text = "Descripción";
            // 
            // labelCodigoB
            // 
            this.labelCodigoB.AutoSize = true;
            this.labelCodigoB.Location = new System.Drawing.Point(20, 37);
            this.labelCodigoB.Name = "labelCodigoB";
            this.labelCodigoB.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoB.TabIndex = 0;
            this.labelCodigoB.Text = "Código";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 233);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(713, 503);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 3;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 536);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.Button buttonAgregarA;
        private System.Windows.Forms.Label labelVencimientoA;
        private System.Windows.Forms.Label labelprecioA;
        private System.Windows.Forms.Label labelDescripcionA;
        private System.Windows.Forms.Label labelCodigoA;
        private System.Windows.Forms.Button buttonAgregarB;
        private System.Windows.Forms.Label labelTamañoB;
        private System.Windows.Forms.Label labelPrecioB;
        private System.Windows.Forms.Label labelDescripcionB;
        private System.Windows.Forms.Label labelCodigoB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxPrecioA;
        private System.Windows.Forms.TextBox textBoxDescrpcionA;
        private System.Windows.Forms.TextBox textBoxCodigoA;
        private System.Windows.Forms.TextBox textBoxPrecioB;
        private System.Windows.Forms.TextBox textBoxDescrpcionB;
        private System.Windows.Forms.TextBox textBoxCodigoB;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonImprimir;
    }
}

