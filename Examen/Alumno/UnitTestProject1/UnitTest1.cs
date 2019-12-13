using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades; 
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NoAgregaException))]
        public void TestMethod1()
        {
            Canasta<Fruta> canasta = new Canasta<Fruta>(2);
            Fruta fruta1 = new Fruta(15, ReinoVegetal.Gusto.Dulce, ConsoleColor.Black);
            Fruta fruta2 = new Fruta(100, ReinoVegetal.Gusto.Dulce, ConsoleColor.Black);
            Fruta fruta3 = new Fruta(75, ReinoVegetal.Gusto.Dulce, ConsoleColor.Black);

            canasta += fruta1;
            canasta = canasta + fruta2;
            canasta += fruta3;
        }
    }
}



