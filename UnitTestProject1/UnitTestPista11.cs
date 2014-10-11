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
    class UnitTestPista11
    {
        public void TestCondicionVerdadera()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "azul", 1, "tostadora"));
            Pista11 pista = new Pista11();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBlanco()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Azul", 2, "tostadora"));
            Pista11 pista = new Pista11();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
