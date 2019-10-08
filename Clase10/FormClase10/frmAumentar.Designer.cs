namespace FormClase10
{
  partial class frmAumentar
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
            this.btnAumentar = new System.Windows.Forms.Button();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(272, 14);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(113, 23);
            this.btnAumentar.TabIndex = 1;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(19, 16);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(247, 20);
            this.txtAumento.TabIndex = 2;
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(19, 42);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(366, 225);
            this.lstEmpleados.TabIndex = 3;
            // 
            // frmAumentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 272);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.btnAumentar);
            this.Name = "frmAumentar";
            this.Text = "Aumentar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAumentar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnAumentar;
    private System.Windows.Forms.TextBox txtAumento;
    private System.Windows.Forms.ListBox lstEmpleados;
  }
}