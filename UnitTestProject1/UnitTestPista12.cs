using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmosGeneticos.Domain.Pistas;
using AlgoritmosGeneticos.Domain;
using System.Collections.Generic;

namespace UnitTestProject
{ 
    [TestClass]
    class UnitTestPista12
    {
        public void TestCondicionVerdadera()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Renault 19", "azul", 1, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "blanco", 2, "jaula"));
            Pista12 pista = new Pista12();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBlanco()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Renault 19", "azul", 1, "tostadora"));
            modelos.Add(new Modelo("Chevrolet Corsa", "negro", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "blanco", 3, "jaula"));
            Pista12 pista = new Pista12();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
