using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows
{
  public partial class Form1 : Form
  {
    public Persona[] persona;
    private string nombre;
    private string dni;
    private string apellido;

    

    public Form1()
    {
      InitializeComponent();
      
    }

   
    private void Form1_Load(object sender, EventArgs e)
    {
      persona = new Persona[3];
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void LbName_Click(object sender, EventArgs e)
    {

    }

    private void LbApellido_Click(object sender, EventArgs e)
    {

    }

    private void LbDni_Click(object sender, EventArgs e)
    {

    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes == MessageBox.Show("Esta seguro ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        int dni;
        string sexo;
        if (int.TryParse(textBox3.Text, out dni) && textBox1.Text != String.Empty && textBox2.Text != String.Empty && ckVive.Checked) 
        {
          sexo = obtenerSexo();
          for (int i = 0; i < persona.Length; i++)
          {
            if (persona[i] is null)
            {
              persona[i] = new Persona(textBox1.Text, textBox2.Text, textBox3.Text, sexo, ckVive.Checked, cbProvincia.Text);
              MessageBox.Show("Persona guardada!");
              break;
            }
          }
        }
      else
      {
        MessageBox.Show("Error con la carga de datos amigoo!!");

      }
        Limpiar();
        }
    }

    public string obtenerSexo()
    {
      foreach(Control item in this.gbsexo.Controls)
      {
        if(item is RadioButton && ((RadioButton)item).Checked)
        {
          return item.Text;
        }
      }
      return "indefinido";
    }


    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Limpiar();
    }

    private void Limpiar()
    {
      textBox1.Text = String.Empty;
      textBox2.Text = String.Empty;
      textBox3.Text = String.Empty;
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
      FrMostrar mostrar = new FrMostrar();
      mostrar.Show(this);
    }

    private void gbsexo_Enter(object sender, EventArgs e)
    {

    }

    private void ckhombre_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void ckmujer_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void ckVive_CheckedChanged(object sender, EventArgs e)
    {

    }
  }
}
