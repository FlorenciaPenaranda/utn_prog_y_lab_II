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

namespace VistaForms
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnValidar.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (dt is null)
            {
                MessageBox.Show("Primero crear el dt");
            }
            else
            {
                if (dt.ValidarAptitud())
                {
                    MessageBox.Show("EL DT es Correcto!");
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("El dt es incorrecto modifique los campos");
                }
            }
           

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(this.tbNombre.Text, this.tbApellido.Text, (int)this.nudEdad.Value, (int)this.nudDni.Value, (int)this.nudExperiencia.Value);
            MessageBox.Show("Director Tecnico creado de forma correcta!");
            this.btnValidar.Enabled = true;
        }

        private void Limpiar()
        {
            this.tbApellido.Text = "";
            this.tbNombre.Text = "";
            this.nudDni.Value = 0;
            this.nudEdad.Value = 0;
            this.nudEdad.Value = 0;
            this.dt = null;
        }
    }
}
