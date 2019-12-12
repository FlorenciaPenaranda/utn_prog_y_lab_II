using System;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        Planeta<Satelite> planeta;
        public FormSistemaSolar()
        {
            InitializeComponent();
            this.CenterToScreen();
            planeta = new Planeta<Satelite>(20, 20, "Jupiter");

        }

        private void BtnSatelite_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txNombre.Text) && !String.IsNullOrEmpty(txOrbita.Text) && !String.IsNullOrEmpty(txRota.Text))
            {
                Satelite satelite = new Satelite(int.Parse(txOrbita.Text), int.Parse(txRota.Text), txNombre.Text);
                this.planeta += satelite;


                SateliteDB sb = new SateliteDB();
                try
                {
                    sb.Guardar(satelite);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Agregado planeta a la base datos", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if (this.planeta.HiloRotacion is null)
            {
                Thread t = new Thread(this.planeta.RunEvntRotar);
                this.planeta.HiloRotacion = t;
                t.Start();
            }
            this.planeta.RunEvntRotar();
        }

        private void BtnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            if (this.planeta.HiloOrbita is null)
            {
                Thread t = new Thread(this.planeta.RunEvntRotar);
                this.planeta.HiloOrbita = t;
                t.Start();
            }
            this.planeta.RunEvntRotar();
        }

    }
}
