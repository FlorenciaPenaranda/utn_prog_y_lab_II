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
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        private Queue<Patente> cola;
        private List<Thread> threads;
        public event MostrarPatente EventoPatente;
        public FrmPpal()
        {
            InitializeComponent();
            this.threads = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            EventoPatente += vistaPatente1.MostrarPatente;
            EventoPatente += vistaPatente2.MostrarPatente;
            //this.vistaPatente1.finExposicion += this.fin;
            //this.vistaPatente2.finExposicion += this.fin;
        }

       
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            
            Xml<List<Patente>> xml = new Xml<List<Patente>>();

            List<Patente> lp = new List<Patente>();
            try
            {
                xml.Leer("patentes.xml", out lp);
                this.cola.Clear();
                this.cola = new Queue<Patente>(lp);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.inicializarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto txt = new Texto();
            try
            {
                txt.Leer("patentes.txt", out this.cola);
            }
            catch(PatenteInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch( Exception ext)
            {
                MessageBox.Show(ext.Message, "erro2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.inicializarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            
            Sql sql = new Sql();
            try
            {
                sql.Leer("dbo.Patentes", out this.cola);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.inicializarSimulacion();


        }

        private void inicializarSimulacion()
        {
            this.FinalizarSimulacion();
            while(this.cola.Count >=1)
            {
                this.proximaPatente(this.cola.Dequeue());
            }
           
        }

        private void proximaPatente(Patente PATENTEYNOESCONSTANTE)
        {
            Thread t = new Thread(new ParameterizedThreadStart(EventoPatente.Invoke));
            this.threads.Add(t);
            t.Start(PATENTEYNOESCONSTANTE);
        }

        
        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.threads)
            {
                if (item != null && item.IsAlive) item.Abort();
            }
        }
    }
}
