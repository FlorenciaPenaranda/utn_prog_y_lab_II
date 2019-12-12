namespace Ej23
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.txtCotizDolar = new System.Windows.Forms.TextBox();
            this.txtCotizPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLockOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(85, 53);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(89, 20);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(85, 90);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(89, 20);
            this.txtDolar.TabIndex = 4;
            this.txtDolar.TextChanged += new System.EventHandler(this.txtDolar_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(85, 126);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(89, 20);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cotizacion";
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(180, 52);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 20);
            this.btnConvertEuro.TabIndex = 7;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(180, 88);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 8;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(180, 124);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 9;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // btnLock
            // 
            this.btnLock.ImageIndex = 0;
            this.btnLock.ImageList = this.imageList1;
            this.btnLock.Location = new System.Drawing.Point(180, 10);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 10;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(261, 52);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 14;
            this.txtEuroAEuro.TextChanged += new System.EventHandler(this.txtEuroAEuro_TextChanged);
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(367, 53);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 15;
            this.txtEuroADolar.TextChanged += new System.EventHandler(this.txtEuroADolar_TextChanged);
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(473, 53);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPeso.TabIndex = 16;
            this.txtEuroAPeso.TextChanged += new System.EventHandler(this.txtEuroAPeso_TextChanged);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(261, 90);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 17;
            this.txtDolarAEuro.TextChanged += new System.EventHandler(this.txtDolarAEuro_TextChanged);
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(367, 90);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 18;
            this.txtDolarADolar.TextChanged += new System.EventHandler(this.txtDolarADolar_TextChanged);
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(473, 90);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPeso.TabIndex = 19;
            this.txtDolarAPeso.TextChanged += new System.EventHandler(this.txtDolarAPeso_TextChanged);
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(261, 122);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAEuro.TabIndex = 20;
            this.txtPesoAEuro.TextChanged += new System.EventHandler(this.txtPesoAEuro_TextChanged);
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(367, 122);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoADolar.TabIndex = 21;
            this.txtPesoADolar.TextChanged += new System.EventHandler(this.txtPesoADolar_TextChanged);
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(473, 122);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAPeso.TabIndex = 22;
            this.txtPesoAPeso.TextChanged += new System.EventHandler(this.txtPesoAPeso_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(261, 12);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 23;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // txtCotizDolar
            // 
            this.txtCotizDolar.Location = new System.Drawing.Point(367, 12);
            this.txtCotizDolar.Name = "txtCotizDolar";
            this.txtCotizDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizDolar.TabIndex = 24;
            this.txtCotizDolar.TextChanged += new System.EventHandler(this.txtCotizDolar_TextChanged);
            // 
            // txtCotizPeso
            // 
            this.txtCotizPeso.Location = new System.Drawing.Point(473, 12);
            this.txtCotizPeso.Name = "txtCotizPeso";
            this.txtCotizPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotizPeso.TabIndex = 25;
            this.txtCotizPeso.TextChanged += new System.EventHandler(this.txtCotizPeso_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dolar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Peso";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Tomato;
            this.imageList1.Images.SetKeyName(0, "iconfinder_icon-114-lock_314692.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_icon-115-lock-open_314693.png");
            // 
            // btnLockOpen
            // 
            this.btnLockOpen.ImageKey = "iconfinder_icon-115-lock-open_314693.png";
            this.btnLockOpen.ImageList = this.imageList1;
            this.btnLockOpen.Location = new System.Drawing.Point(180, 12);
            this.btnLockOpen.Name = "btnLockOpen";
            this.btnLockOpen.Size = new System.Drawing.Size(75, 23);
            this.btnLockOpen.TabIndex = 29;
            this.btnLockOpen.TabStop = false;
            this.btnLockOpen.UseVisualStyleBackColor = true;
            this.btnLockOpen.Click += new System.EventHandler(this.btnLockOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 165);
            this.Controls.Add(this.btnLockOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCotizPeso);
            this.Controls.Add(this.txtCotizDolar);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtEuro;
    private System.Windows.Forms.TextBox txtDolar;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnConvertEuro;
    private System.Windows.Forms.Button btnConvertDolar;
    private System.Windows.Forms.Button btnConvertPeso;
    private System.Windows.Forms.Button btnLock;
    private System.Windows.Forms.TextBox txtEuroAEuro;
    private System.Windows.Forms.TextBox txtEuroADolar;
    private System.Windows.Forms.TextBox txtEuroAPeso;
    private System.Windows.Forms.TextBox txtDolarAEuro;
    private System.Windows.Forms.TextBox txtDolarADolar;
    private System.Windows.Forms.TextBox txtDolarAPeso;
    private System.Windows.Forms.TextBox txtPesoAEuro;
    private System.Windows.Forms.TextBox txtPesoADolar;
    private System.Windows.Forms.TextBox txtPesoAPeso;
    private System.Windows.Forms.TextBox textBox13;
    private System.Windows.Forms.TextBox txtCotizDolar;
    private System.Windows.Forms.TextBox txtCotizPeso;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Button btnLockOpen;
  }
}

