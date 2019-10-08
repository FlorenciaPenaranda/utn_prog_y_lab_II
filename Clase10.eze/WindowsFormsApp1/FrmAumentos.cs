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

namespace WindowsFormsApp1
{
    public partial class FrmAumentos : Form
    {
        private List<Persona> personas;
        public FrmAumentos()
        {
            InitializeComponent();
            this.personas = new List<Persona>();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in this.personas)
            {
                item.Aumentar(int.Parse(txtPorcentaje.Text));
            }

            this.lstNomina.DataSource = null;
            this.lstNomina.DataSource = personas;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAdminEmpleados frmAdminEmpleados = new FrmAdminEmpleados();
            if(frmAdminEmpleados.ShowDialog() == DialogResult.OK)
            {
                this.personas.Add(frmAdminEmpleados.persona);
            }

            this.lstNomina.DataSource = null;
            this.lstNomina.DataSource = personas;

        }
    }
}
