using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace Formulario
{
    public partial class FrmMostrar : Form
    {
        private Centralita central;
        public FrmMostrar()
        {
            InitializeComponent();
            this.central = new Centralita();
            this.CenterToScreen();
        }

        private void BtnGenerateCall_Click(object sender, EventArgs e)
        {
            FrmLlamador frm = new FrmLlamador(central);
            frm.ShowDialog(this);
        }

        private void BtnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmVisual frmvis = new FrmVisual(central, Llamada.TipoLlamada.Todas);
            frmvis.ShowDialog(this);
        }

        private void BtnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmVisual frmvis = new FrmVisual(central, Llamada.TipoLlamada.Local);
            frmvis.ShowDialog(this);
        }

        private void BtnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmVisual frmvis = new FrmVisual(central, Llamada.TipoLlamada.Provincial);
            frmvis.ShowDialog(this);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
