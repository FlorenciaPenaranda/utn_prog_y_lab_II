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

using Entidades;

namespace Final
{
    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void btnPunto1_Click(object sender, EventArgs e)
        {
            // TODAS las clases deberán ir en una Biblioteca de Clases llamada Entidades
            // ¡Reutilizar código siempre que se pueda!.

            //* Clase ReinoVegetal: Debe ser abstracta
            //* Enumerado Gusto contendrá Dulce, Salado y Toxica
            //* Agregar un atributo estático calcularValor:Random.
            //      **Este atributo sólo se podrá inicializar en un constructor estático.
            //* Un constructor que reciba ambos parámetros.
            //* Generar otro constructor que sólo reciba Gusto y asigne en valor un número aleatorio entre 1 y 100.

            //* Clases públicas Fruta, Verdura y Carnibora. Las 3 heredarán de ReinoVegetal.
            //* Enumerado TipoVerdura: Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma
            //* Enumerado Capturas: Pinzas, Pelos, Caída, Mecánicas, Combinada

            //* A las tres clases completarle sus constructores de la forma correcta.

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            ReinoVegetal v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);
            Verdura v3 = new Verdura((float)52.5, ReinoVegetal.Gusto.Salado, Verdura.TipoVerdura.Hoja);
            Verdura v4 = new Verdura((float)2.7, ReinoVegetal.Gusto.Toxica, Verdura.TipoVerdura.Raíz);
            Carnibora v5 = new Carnibora((float)14.5, ReinoVegetal.Gusto.Toxica, Carnibora.Captura.Combinada);
            ReinoVegetal v6 = new Carnibora((float)1.2, ReinoVegetal.Gusto.Toxica, Carnibora.Captura.Pelos, 10);
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            //* Los atributos de Fruta, Verdura y Carnibora generados en el punto anterior
            //* deberán tener propiedades publicas de sólo lectura que expongan sus datos.
            // (SOLO FINAL) ReinoVegetal contendrá una conversión explicita a String.
            // (SOLO FINAL) Fruta, Verdura y Carnibora contendrá una conversión implicita a String.
            // (SOLO RSP) Hacer las correcciones necesarias para que el código dado siga funcionando (inclusive comentar parte de los códigos)

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);
            Verdura v4 = new Verdura((float)2.7, ReinoVegetal.Gusto.Toxica, Verdura.TipoVerdura.Raíz);
            Carnibora v5 = new Carnibora((float)1.2, ReinoVegetal.Gusto.Toxica, Carnibora.Captura.Pelos, 10);

            //MessageBox.Show(v2);
            //MessageBox.Show(v4);
            //MessageBox.Show(v5);
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            //* Dos elementos del tipo ReinoVegetal serán iguales si son del mismo Tipo
            //* (dos frutas, dos verduras o dos carniboras) y tienen el mismo Gusto

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            Fruta v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);
            Verdura v3 = new Verdura((float)52.5, ReinoVegetal.Gusto.Salado, Verdura.TipoVerdura.Hoja);
            Verdura v4 = new Verdura((float)2.7, ReinoVegetal.Gusto.Toxica, Verdura.TipoVerdura.Raíz);
            Carnibora v5 = new Carnibora((float)14.5, ReinoVegetal.Gusto.Toxica, Carnibora.Captura.Combinada);
            Carnibora v6 = new Carnibora((float)1.2, ReinoVegetal.Gusto.Toxica, Carnibora.Captura.Pelos, 10);

            MessageBox.Show("Carnibora y Verdura:" + (v5 == v4));
            MessageBox.Show("Verdura y Verdura:" + (v3 == v4));
            MessageBox.Show("Carnibora y Carnibora:" + (v5 == v6));
        }

        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //* Clase Canasta:
            //* El atributo plantas:List del tipo genérico sólo se podrá inicializar en el constructor
            //      por defécto, que además será privado

            // Generar la Excepción propia NoAgregaException con un único constructor que reciba el mensaje a mostrar.

            //* Al sumar una canasta con un elemento del ReinoVegetal se deberá a gregar a la lista de plantas
            //* SÓLO si el tipo genérico de la Canasta es igual al elemento del ReinoVegetal y aun hay lugar en la canasta.
            //     Si no son del mismo tipo, el mensaje deberá ser "El elemento es del tipo {0}. Se esperaba {1}.". ¡Utilizar Format!
            //* Si la capacidad está al límite, el mensaje será "Capacidad excedida.".
            //* Utilizar T aux = (T)Convert.ChangeType(reinoVegetal, typeof(T)); para convertir un ReinoVegetal en T.

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            Fruta v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);
            Fruta v3 = new Fruta((float)10.2, ReinoVegetal.Gusto.Dulce, ConsoleColor.Green);
            Verdura v4 = new Verdura((float)2.7, ReinoVegetal.Gusto.Toxica, Verdura.TipoVerdura.Raíz);

            Canasta<Fruta> canasta1 = new Canasta<Fruta>(2);

            canasta1 += v1;
            canasta1 = canasta1 + v2;
            try
            {
                canasta1 += v3;
            }
            catch (NoAgregaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                canasta1 += v4;
            }
            catch (NoAgregaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {
            //* Generar la interfaz pública IVegetales, con la firma del método MostrarDatos:string.
            // Implementar la interfaz en Fruta, Verdura y Carnibora. Siempre rehutilizar código.
            // Canasta sólo deberá aceptar tipos T que implementen la interfaz.
            // Sobrecargar ToString de canasta para mostrar todos los datos de los elementos de la lista.

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            Fruta v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);

            Canasta<Fruta> canasta1 = new Canasta<Fruta>(2);

            canasta1 += v1;
            canasta1 = canasta1 + v2;
            MessageBox.Show(canasta1.ToString());
        }

        private void btnPunto6_Click(object sender, EventArgs e)
        {
            // Generar un método de Extención para la clase Fruta llamado GuardarElemento.
            // El método deberá retornar los datos del objeto, rehutilizando código, y guardar dicha información en un archivo de texto.
            // También deberá serializar el elemento de forma XML y *Binaria*.
            // Los 3 archivos deberán ser guardados en el escritorio de la máquina actual, con los nombres datos.txt, datos.xml y datos.bin respectivamente.

            // Descomentar el siguiente código, que deberá funcionar sin modificaciones:
            // -------------------------------------------------------------------------------------------------
            Fruta f = new Fruta((float)22.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.DarkYellow);

            MessageBox.Show(f.MostrarElemento());
        }

        private void btnPunto7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizar un Test Unitario que pruebe que la excepción NoAgregaException se lance al estar llena la Canasta. HECHO EN LA CLASE TestUnitario");
            //MessageBox.Show("(SOLO RSP) Agregar un botón que serialize en BINARIO. Hacer lo que corresponda para que funcione.");
        }

        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Lanzar mediante un hilo el método ProbarTodo. Comentar este MessageBox.");
            Thread t = new Thread(this.ProbarTodo);

            t.Start();
        }

        private void ProbarTodo()
        {
            object sender = this;
            EventArgs e = new EventArgs();


            btnPunto1_Click(sender, e);
            btnPunto2_Click(sender, e);
            btnPunto3_Click(sender, e);
            btnPunto4_Click(sender, e);
            btnPunto5_Click(sender, e);
        }


    }
}
