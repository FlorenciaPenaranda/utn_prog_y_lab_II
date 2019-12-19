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


namespace FrmAlta
{
    public partial class FrmPricnipal : Form
    {
        Estacionamiento estacionamiento;
        public FrmPricnipal()
        {
            InitializeComponent();
        }

        private void NuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta alta = FrmAlta.CrearInstancia(estacionamiento);
            alta.MdiParent = this;
            alta.Show();
        }

        private void FrmPricnipal_Load(object sender, EventArgs e)
        {
            estacionamiento = Estacionamiento.InstanciarEstacionamiento("Pirulo", 85, 120);
        }

        private void ListarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(estacionamiento.ToString());
        }
    }
}
