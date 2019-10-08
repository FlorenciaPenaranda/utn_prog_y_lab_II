using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClase8;

namespace Ejercicio_Clase_8
{
  public partial class frmCarga : Form
  {
    public frmCarga()
    {
      InitializeComponent();
    }


    private void btnLimpiarForm_Click(object sender, EventArgs e)
    {
      foreach(Control controls in this.Controls)
      {
        if(controls is TextBox)
        {
          (controls as TextBox).Clear();
        }else if(controls is MaskedTextBox)
        {
          (controls as MaskedTextBox).Clear();
        }else if(controls is ComboBox)
        {
          (controls as ComboBox).SelectedIndex = -1;
        }
      }
    }

    private void btnEmpresa_Click(object sender, EventArgs e)
    {

    }

    private void frmCarga_Load(object sender, EventArgs e)
    {
      cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
    }
  }
}
