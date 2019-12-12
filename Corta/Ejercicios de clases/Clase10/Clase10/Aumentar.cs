using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase10
{
  public partial class Aumentar : Form
  {
    public List<Persona> ListaPersonas;
    public Persona per;
    public Aumentar()
    {
      InitializeComponent();
      this.ListaPersonas = new List<Persona>();

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Aumentar_Load(object sender, EventArgs e)
    {

      //aca sobreescribi el tostring haciendo que mustre, ya que el datasource hace solo el tostring y asi funciona! ;D
      this.listBox1.DataSource = ListaPersonas;
    }

    private void btnAumentar_Click(object sender, EventArgs e)
    {

      foreach (Empleado item in ListaPersonas)
      {
        item.Aumentar(Convert.ToInt32(textBox1.Text));
      }
      this.listBox1.DataSource = null;

      this.listBox1.DataSource = ListaPersonas;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      Form1 form1 = new Form1();
      form1.ShowDialog();

      if (form1.DialogResult == DialogResult.OK)
      {
        this.ListaPersonas.Add(form1.Persona);
        foreach (Empleado item in ListaPersonas)
        {
          item.Mostrar();
        }
        this.listBox1.DataSource = null;

        this.listBox1.DataSource = ListaPersonas;

      }


    }
  }
}
