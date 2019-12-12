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
    public partial class frmEstanteria : Form
    {
        private List<object> Estantes;
        public frmEstanteria(List<object>lista)
        {
            InitializeComponent();
            this.Estantes = lista;
            
        }

        private void btnAgregarEstante_Click(object sender, EventArgs e)
        {
            switch (cmbParametro.SelectedValue)
            {
                case Tipo.Producto:
                    this.Estantes.Add(new Estanteria<Producto>(Convert.ToInt32(txtTamano.Text)));
                    break;
                case Tipo.Alimenticio:
                    this.Estantes.Add(new Estanteria<Alimenticio>(Convert.ToInt32(txtTamano.Text)));
                    break;
                case Tipo.Ferreteria:
                    this.Estantes.Add(new Estanteria<Ferreteria>(Convert.ToInt32(txtTamano.Text)));
                    break;
                default:
                    break;
            }
        }

        private void frmEstanteria_Load(object sender, EventArgs e)
        {
            cmbParametro.DataSource = Enum.GetValues(typeof(Tipo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public enum Tipo
    {
        Producto,
        Alimenticio,
        Ferreteria
    }
}
