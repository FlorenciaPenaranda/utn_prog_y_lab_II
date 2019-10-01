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

namespace WindowsFormsClase10
{
    public partial class Form1 : Form
    {
        public List<Persona> Personas;
        public Form1()
        {
            InitializeComponent();
            this.Personas = new List<Persona>();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Persona P = new Empleado(textNombre.Text, double.Parse(textCuil.Text), float.Parse(textSueldo.Text));
            
            
        }
    }
}
