using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista10
    {
        [TestMethod]
        public void TestCondicionVerdadera10()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Volkswagen Gol", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista10 pista = new Pista10();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa10()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Volkswagen Gol", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista10 pista = new Pista10();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
