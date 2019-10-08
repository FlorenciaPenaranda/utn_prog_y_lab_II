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
  public enum ETipoEmpleado
  {
    Empleado,
    Jefe,
    Vendedor
  }
  public partial class frmClase10 : Form
  {
    public List<Persona> Personas;
    public frmClase10()
    {
      InitializeComponent();
      this.Personas = new List<Persona>();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cmbTipo.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch(cmbTipo.SelectedItem)
      {
        case ETipoEmpleado.Empleado:
          txtObjetivoBono.Visible = false;
          lblObjetivoBono.Visible = false;
          break;
        case ETipoEmpleado.Vendedor:
          txtObjetivoBono.Visible = true;
          lblObjetivoBono.Visible = true;
          lblObjetivoBono.Text = "Objetivo";
          break;
        case ETipoEmpleado.Jefe:
          txtObjetivoBono.Visible = true;
          lblObjetivoBono.Visible = true;
          lblObjetivoBono.Text = "Bono";
          break;
      }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      Persona personaActual;
      try
      {
        switch (cmbTipo.SelectedItem)
        {
          case ETipoEmpleado.Empleado:
            personaActual = new Empleado(txtNombre.Text, double.Parse(txtCuil.Text), float.Parse(txtSueldo.Text));
            break;
          case ETipoEmpleado.Vendedor:
            personaActual = new Vendedor(txtNombre.Text, double.Parse(txtCuil.Text), float.Parse(txtSueldo.Text), int.Parse(txtObjetivoBono.Text));
            break;
          case ETipoEmpleado.Jefe:
            personaActual = new Jefe(txtNombre.Text, double.Parse(txtCuil.Text), float.Parse(txtSueldo.Text), int.Parse(txtObjetivoBono.Text));
            break;
          default:
            personaActual = new Empleado(txtNombre.Text, double.Parse(txtCuil.Text), float.Parse(txtSueldo.Text));
            break;         
        }
        Personas.Add(personaActual);
        foreach (Control item in Controls)
        {
          if (item is TextBox)
          {
            (item as TextBox).Clear();
          }
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
      foreach(Persona item in Personas)
      {
        MessageBox.Show(item.Mostrar(), "Mostrar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnAumentar_Click(object sender, EventArgs e)
    {
      Form frm = new frmAumentar(Personas);
      frm.Show();
      this.Hide();     
    }

    
  }
}
