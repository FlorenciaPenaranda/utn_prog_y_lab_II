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

namespace clase8
{
    public partial class FrmEmpresa : Form
    {

        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            
        }

        private void tbRazonSocial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbGanancias_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            float aux = 0;
            float.TryParse(mtbGanancias.Text ,out aux);
            Empresa emp = new Empresa(tbRazonSocial.Text, tbDireccion.Text, aux);
            Form1 mostrar = new Form1();
            mostrar.Show(this);

        }

       
    }
}
