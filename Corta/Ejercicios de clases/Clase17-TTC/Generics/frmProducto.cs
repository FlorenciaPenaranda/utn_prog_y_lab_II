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
    public partial class frmProducto<T> : Form
    {
        private List<object> list;
        public frmProducto(List<object> lista)
        {
            InitializeComponent();
            this.list = lista;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoProd));
            this.txtFecha.Enabled = false;
            this.txtPeso.Enabled = false;
            this.lblfecha.Enabled = false;
            this.lblpeso.Enabled = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedValue)
            {

                case TipoProd.Alimenticio:
                    this.txtFecha.Enabled = true;
                    this.txtPeso.Enabled = false;
                    this.lblfecha.Enabled = true;
                    this.lblpeso.Enabled = false;
                    break;
                case TipoProd.Ferreteria:
                    this.txtFecha.Enabled = false;
                    this.txtPeso.Enabled = true;
                    this.lblfecha.Enabled = false;
                    this.lblpeso.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedValue)
            {

                case TipoProd.Alimenticio:
                    this.list.Add(new Alimenticio(Convert.ToInt32(this.txtIdProd.Text), this.txtDesc.Text, new DateTime()));
                    break;
                case TipoProd.Ferreteria:
                    this.list.Add(new Ferreteria(float.Parse(this.txtPeso.Text), Convert.ToInt32(this.txtIdProd.Text), this.txtDesc.Text));
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public enum TipoProd
    {

        Alimenticio,
        Ferreteria
    }
}
