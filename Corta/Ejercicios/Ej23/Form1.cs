using System;
using System.Windows.Forms;
using Moneda;

namespace Ej23
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void txtEuro_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtDolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPeso_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnConvertEuro_Click(object sender, EventArgs e)
    {
      double cotizrespecdolar;
      double cantEuro;
      if (double.TryParse(textBox13.Text, out cotizrespecdolar) && double.TryParse(txtEuro.Text, out cantEuro)){
        Euro euro = new Euro(cantEuro, cotizrespecdolar);
        txtEuroAEuro.Text = euro.GetCantidad().ToString();
        txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
        txtEuroAPeso.Text = ((Peso)euro).GetCantidad().ToString();

      }
    }

    private void btnConvertDolar_Click(object sender, EventArgs e)
    {
      double cotizrespecdolar;
      double cantDolar;
      if (double.TryParse(txtCotizDolar.Text, out cotizrespecdolar) && double.TryParse(txtDolar.Text, out cantDolar))
      {
        Dolar dola = new Dolar(cantDolar, cotizrespecdolar);
        txtDolarADolar.Text = dola.GetCantidad().ToString();
        txtDolarAEuro.Text = ((Euro)dola).GetCantidad().ToString();
        txtDolarAPeso.Text = ((Peso)dola).GetCantidad().ToString();

      }

    }

    private void btnConvertPeso_Click(object sender, EventArgs e)
    {
      double cotizrespecdolar;
      double cantPeso;
      if (double.TryParse(txtCotizPeso.Text, out cotizrespecdolar) && double.TryParse(txtPeso.Text, out cantPeso))
      {
        Peso pes = new Peso(cantPeso, cotizrespecdolar);
        txtPesoAPeso.Text = pes.GetCantidad().ToString();
        txtPesoAEuro.Text = ((Euro)pes).GetCantidad().ToString();
        txtPesoADolar.Text = ((Dolar)pes).GetCantidad().ToString();

      }

    }

    private void btnLock_Click(object sender, EventArgs e)
    {
      txtCotizDolar.Enabled = true;
      txtCotizPeso.Enabled = true; 
      textBox13.Enabled = true; 
      txtDolarADolar.Enabled = true;
      txtDolarAEuro.Enabled = true;
      txtDolarAPeso.Enabled = true;
      txtEuroADolar.Enabled = true;
      txtEuroAPeso.Enabled = true;
      txtEuroAEuro.Enabled = true;
      txtPesoADolar.Enabled = true;
      txtPesoAEuro.Enabled = true;
      txtPesoAPeso.Enabled = true;
      btnLock.Hide();
      btnLockOpen.Show();

    }

    private void textBox13_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtCotizDolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtCotizPeso_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEuroAEuro_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEuroADolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEuroAPeso_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtDolarAEuro_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtDolarADolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPesoAEuro_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPesoADolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtPesoAPeso_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtDolarAPeso_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnLockOpen_Click(object sender, EventArgs e)
    {
      txtCotizDolar.Enabled = false;
      txtCotizPeso.Enabled = false;
      textBox13.Enabled = false;
      txtDolarADolar.Enabled = false;
      txtDolarAEuro.Enabled = false;
      txtDolarAPeso.Enabled = false;
      txtEuroADolar.Enabled = false;
      txtEuroAPeso.Enabled = false;
      txtEuroAEuro.Enabled = false;
      txtPesoADolar.Enabled = false;
      txtPesoAEuro.Enabled = false;
      txtPesoAPeso.Enabled = false;
      btnLockOpen.Hide();
      btnLock.Show();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      btnLock.Hide();
    }
  }
}
