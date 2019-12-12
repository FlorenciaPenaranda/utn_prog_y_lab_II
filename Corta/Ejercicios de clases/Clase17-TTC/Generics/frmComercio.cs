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

namespace Generics
{
    public partial class frmComercio : Form
    {
        List<object> lista;
        public frmComercio()
        {
            InitializeComponent();
        }

        private void cmbEstanteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmComercio_Load(object sender, EventArgs e)
        {
            this.lista = new List<object>();
            foreach (object item in this.lista)
            {
                this.cmbEstanteria.Items.Add(item);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmEstanteria es = new frmEstanteria(lista);
            es.ShowDialog(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           if(cmbEstanteria.SelectedValue is Estanteria<Alimenticio>)
            {
                frmProducto<Alimenticio> asd = new frmProducto<Alimenticio>(this.lista);
                asd.ShowDialog(this);
            }

            if(cmbEstanteria.SelectedValue is Estanteria<Ferreteria>)
            {
                frmProducto<Ferreteria> asd = new frmProducto<Ferreteria>(this.lista);
                asd.ShowDialog(this);
            }
            

        }
    }
}
