using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmosGeneticos.Domain.Pistas;
using AlgoritmosGeneticos.Domain;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista13
    {
        [TestMethod]
        public void TestCondicionVerdadera13()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 5, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "negro", 4, "tostadora"));

            Pista13 pista = new Pista13();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBlanco13()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 5, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "negro", 4, "tostadora"));

            Pista13 pista = new Pista13();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
