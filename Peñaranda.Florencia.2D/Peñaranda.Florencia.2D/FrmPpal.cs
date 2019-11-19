using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Peñaranda.Florencia._2D
{
    public partial class FrmPpal : Form
    {
        //aca creamos el hilo
        //private Thread miHilo;
        public FrmPpal()
        {
            InitializeComponent();
            // miHilo = new Thread(this.procesoACorrer);
            //hay que hacer el metodo dentro de esta clase.
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            lblEstadoIngresado.Text = "";
            lblEstadoEnViaje.Text = "";
            lblEstadoEntregado.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }

        /*private void hacerAlgoPorUnTiempo()
        {
            do
            {
                this.elemento.accion();
                Thread.Sleep(45);
            } while (true);
        }


        cuando hacemos un click:
        preguntamos si el hilo esta vivo y no es null, lo matamos para iniciar una nueva accion

        if (this.miHilo != null && this.miHilo.IsAlive)
            {
                this.miHilo.Abort(); //lo mato
            }
            else
            {
                this.miHilo = new Thread(this.hacerAlgo);
                this.miHilo.Start();
            }




        CLASE DE FEDE

        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Clase_22_Threads
{
    public partial class FrmPrueba : Form
    {
        private Thread miHiloCaballo;
        private Thread miHiloBarra;

        public FrmPrueba()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.miHiloCaballo != null && this.miHiloCaballo.IsAlive)
            {
                this.miHiloCaballo.Abort();
            }
            else
            {
                this.miHiloCaballo = new Thread(this.AnimarCaballito);
                this.miHiloCaballo.Start();
            }
        }

        private void AnimarCaballito()
        {
            do
            {
                caballito1.MoverCaballito();
                Thread.Sleep(45);
            } while (true);
        }

        private void FrmPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (miHiloCaballo.IsAlive)
                miHiloCaballo.Abort();
            if (miHiloBarra.IsAlive)
                miHiloBarra.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.miHiloBarra != null && this.miHiloBarra.IsAlive)
            {
                this.miHiloBarra.Abort();
            }
            else
            {
                this.miHiloBarra = new Thread(this.AnimarBarra);
                this.miHiloBarra.Start();
            }
        }

        private void AnimarBarra()
        {
            do
            {
                this.barra1.CorrerBarra();
                Thread.Sleep(45);
            } while (true);
        }
    }
}


        CLASE2 

        namespace WindowsFormsThreads
{
    public partial class FrmBarra : Form
    {
        Thread t;

        public FrmBarra()
        {
            InitializeComponent();

            t = new Thread(this.barra1.CorrerBarra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.IsAlive)
            {
                BarraDeProgreso.Barra.Seguir = false;
                t.Abort();
            }
            else
            {
                t = new Thread(this.Animar);
                t.Start();
            }
        }

        private void Animar()
        {
            do
            {
                this.barra1.CorrerBarra();
                System.Threading.Thread.Sleep(50);
            } while (true);
        }
    }
}         
         */

    }
}
