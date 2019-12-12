using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(SateliteException))]
        public void TestSateliteRepetido()
        {
            Planeta<Satelite> planeta = new Planeta<Satelite>(20, 20, "Jupiter");
            Satelite s1 = new Satelite(20, 20, "prueba");
            Satelite s2 = new Satelite(20, 20, "prueba");
            planeta += s1;
            planeta += s2;
        }

        [TestMethod]
        public void GuardarYLeer()
        {
            List<Satelite> lista = new List<Satelite>();
            Satelite satelite = new Satelite(20, 20, "Jupiter");
            SateliteDB sb = new SateliteDB();
            sb.Guardar(satelite);
            sb.Leer(lista);
            foreach (Satelite item in lista)
            {
                if (item.DuraOrbita == satelite.DuraOrbita && item.DuraRotacion == satelite.DuraRotacion && item.Nombre == satelite.Nombre)
                {
                    return;
                }
            }
            Assert.Fail();
        }



    }
}
