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
    public delegate void Mensaje(string msg);

    public partial class FrmAccion : Form
    {
        public event Mensaje eventMsg;

        public FrmAccion()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            eventMsg.Invoke(this.textBox1.Text);
        }
    }
}
