using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmosGeneticos.Domain;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista2
    {
        [TestMethod]
        public void TestCondicionVerdadera2()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "palo de golf"));

            Pista2 pista = new Pista2();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa2()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 7, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "palo de golf"));

            Pista2 pista = new Pista2();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
