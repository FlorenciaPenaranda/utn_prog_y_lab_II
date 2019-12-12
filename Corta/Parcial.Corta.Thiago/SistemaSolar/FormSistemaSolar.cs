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
            FormClosed += finHilos;
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            
            //if (this.planeta.HiloOrbita is null)
            //{
            //    Thread t1 = new Thread(this.planeta.RunEvntOrb);
            //    this.planeta.HiloOrbita = t1;
            //    t1.Start();
            //}
            if(this.planeta.HiloRotacion is null)
            {
                Thread t2 = new Thread(this.planeta.RunEvntRotar);
                this.planeta.HiloRotacion = t2;
                t2.Start();
            }
            if (!this.planeta.NececitaInvocacion())
            {
                this.planeta.AstroEvent += this.MostrarMensaje;

            }
            this.planeta.RunEvntRotar();


        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            foreach (Satelite item in this.planeta.Satelites)
            {
                if (item.HiloOrbita is null)
                {
                    Thread t1 = new Thread(this.planeta.RunEvntOrb);
                    this.planeta.HiloOrbita = t1;
                    t1.Start();
                }
                //if (item.HiloRotacion is null)
                //{
                //    Thread t2 = new Thread(this.planeta.RunEvntRotar);
                //    this.planeta.HiloRotacion = t2;
                //    t2.Start();
                   
                //}
                if (!item.NececitaInvocacion())
                {
                    item.AstroEvent += this.MostrarMensaje;

                }
                
                item.RunEvntOrb();
            }
            
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            int orbita;
            int rotacion;
            if (!String.IsNullOrEmpty(txNombre.Text) && !String.IsNullOrEmpty(txOrbita.Text) && !String.IsNullOrEmpty(txRota.Text))
            {

                int.TryParse(txOrbita.Text, out orbita);
                int.TryParse(txRota.Text, out rotacion);
                if (orbita >= 1 && rotacion >= 1)
                {
                    Satelite s = new Satelite(orbita, rotacion, txNombre.Text);
                    this.planeta += s;
                    if (this.planeta == s)
                    {
                        SateliteDB sb = new SateliteDB();
                        try
                        {
                            sb.Guardar(s);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Agregado planeta a la base datos", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void finHilos(object sender, EventArgs e)
        {
            if(this.planeta.HiloOrbita != null && this.planeta.HiloOrbita.IsAlive) this.planeta.HiloOrbita.Abort();
            if (this.planeta.HiloRotacion != null && this.planeta.HiloRotacion.IsAlive) this.planeta.HiloRotacion.Abort();
            foreach (Satelite item in this.planeta.Satelites)
            {
                if (item.HiloOrbita != null && item.HiloOrbita.IsAlive) item.HiloOrbita.Abort();

                if (item.HiloRotacion != null && item.HiloRotacion.IsAlive) item.HiloRotacion.Abort();

            }
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            SateliteDB sb = new SateliteDB();
            try
            {
                sb.Leer(this.planeta.Satelites);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(this.planeta.Satelites.Count >= 1)
            {
                MessageBox.Show("Satelites de la base de datos cargados", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
