using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Factura f = new Factura("UTN", "20-12345678-2");
            //Producto p1 = new ProductoA("111", "Producto1", 100, new DateTime(2018, 07, 01));
            //Producto pd = new ProductoA("111", "Duplicado1", 100, new DateTime(2018, 07, 01));
            //Producto p2 = new ProductoB("112", "Producto2", 200, Tamanios.CHICO);
            //Producto p3 = new ProductoB("113", "Producto3", 250, Tamanios.MEDIANO);
            //Producto p4 = new ProductoB("114", "Producto4", 300, Tamanios.GRANDE);
            //Producto p5 = new ProductoB("115", "Producto5", 400);
            //f += p1;
            //f += pd;
            //f += p2;
            //f += p3;
            //f += p4;
            //f += p5;
            //try
            //{
            //    Producto p6 = new ProductoA("116", "Producto6", 100, new DateTime(2018, 06, 15));
            //    f += p6;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine((string)f);
            //Console.ReadKey();
        }
    }
}
