using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{

    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarAccion_Click(object sender, EventArgs e)
        {
           
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmAccion)
                {
                    item.Focus();
                    return;
                }
            }

            FrmAccion acc = new FrmAccion();
            acc.MdiParent = this;
            acc.Show();

            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmMensaje)
                {
                    item.Focus();
                    acc.eventMsg += ((FrmMensaje)item).mostrarMensaje;
                    return;
                }
            }
           

        }

        private void btnMostrarMsj_Click(object sender, EventArgs e)
        {
          
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmMensaje)
                {
                    item.Focus();
                    return;
                }
            }
            FrmMensaje msg = new FrmMensaje();
            msg.MdiParent = this;
            msg.Show();
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmAccion)
                {
                    item.Focus();
                    ((FrmAccion)item).eventMsg += msg.mostrarMensaje;
                    return;
                }
            }
            

        }
    }
}
