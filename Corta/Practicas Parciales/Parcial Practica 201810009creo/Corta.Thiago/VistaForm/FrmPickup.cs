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

namespace VistaForm
{
    public partial class FrmPickup : Form
    {
        public FrmPickup()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(txtPatente.Text.Length == 6)
            {
                Vehiculo v1 = new PickUp(txtPatente.Text, txtModelo.Text);
                MessageBox.Show(v1.ConsultarDatos(), "Pickup Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error en la patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
