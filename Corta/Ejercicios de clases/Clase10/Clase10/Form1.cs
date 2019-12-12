using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Clase10
{
  public enum TipoEmpleado
  {
    Empleado,
    Vendedor,
    Jefe
  }

  public partial class Form1 : Form
  {
    public Persona personaNew;
    public TipoEmpleado emp;
    public Form1()
    {
      InitializeComponent();
    }

    private void cbTipoEmp_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.lbBono.Visible = (((TipoEmpleado)this.cbTipoEmp.SelectedItem == TipoEmpleado.Jefe));
      this.tbBono.Visible = (((TipoEmpleado)this.cbTipoEmp.SelectedItem == TipoEmpleado.Jefe));
      this.tbObjetivo.Visible = (((TipoEmpleado)this.cbTipoEmp.SelectedItem == TipoEmpleado.Vendedor));
      this.label4.Visible = (((TipoEmpleado)this.cbTipoEmp.SelectedItem == TipoEmpleado.Vendedor));
    }

    private void tbName_TextChanged(object sender, EventArgs e)
    {

    }

    private void mtbCuil_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void tbSueldo_TextChanged(object sender, EventArgs e)
    {

    }

    private void tbObjetivo_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.cbTipoEmp.DataSource = Enum.GetValues(typeof(TipoEmpleado));
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      try
      {

      
      switch (this.cbTipoEmp.Text)
      {
        case "Empleado":
          this.personaNew = (new Empleado(this.tbName.Text, Convert.ToInt32(this.mtbCuil.Text), ((float)(Convert.ToDouble(this.tbSueldo.Text)))));
          break;
        case "Vendedor":
          this.personaNew =(new Vendedor(this.tbName.Text, Convert.ToInt32(this.mtbCuil.Text), ((float)(Convert.ToDouble(this.tbSueldo.Text))), Convert.ToInt32(this.tbObjetivo.Text)));
          break;
        case "Jefe":
          this.personaNew =(new Jefe(this.tbName.Text, Convert.ToInt32(this.mtbCuil.Text), ((float)(Convert.ToDouble(this.tbSueldo.Text))), Convert.ToInt32(this.tbBono.Text)));
          break;
        default:
          break;
      }
      this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {

        MessageBox.Show(ex.Message);
      }
      finally
      {
        this.Limpiar();
      }
    }

    private void label4_Click(object sender, EventArgs e)
    {
      
    }

    private void tbBono_TextChanged(object sender, EventArgs e)
    {

    }

    private void lbBono_Click(object sender, EventArgs e)
    {

    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
     
        MessageBox.Show(personaNew.Mostrar());
      
    }

    public Persona Persona { get { return this.personaNew; } }
    private void btnAumentar_Click(object sender, EventArgs e)
    {
      
    }

    private void Limpiar()
    {
      this.tbBono.Text = "";
      this.tbName.Text = "";
      this.tbObjetivo.Text = "";
      this.tbSueldo.Text = "";
      this.mtbCuil.Text = "";
    }
  }
}
