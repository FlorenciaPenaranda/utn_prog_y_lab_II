using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase10;

namespace FormClase10
{
  public partial class frmAumentar : Form
  {
    frmClase10 frmReference = new frmClase10();
    List<Persona> Personas;
    public frmAumentar()
    {
      InitializeComponent();
    }

    public frmAumentar(List<Persona> personas)
    {
      InitializeComponent();
      this.Personas = personas;
      foreach(Empleado item in Personas)
      {
        lstEmpleados.Items.Add(item.Mostrar());
      }
    }

    private void btnAumentar_Click(object sender, EventArgs e)
    {
      foreach(Empleado item in Personas)
      {
        item.Aumentar(int.Parse(txtAumento.Text));
        lstEmpleados.Items.Add(item.Mostrar());
      }
    }

    private void frmAumentar_FormClosed(object sender, FormClosedEventArgs e)
    {
      frmReference.Show();
    }
  }
}
