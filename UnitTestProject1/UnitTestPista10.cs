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
            modelos.Add(new Modelo("Chevrolet Corsa", "gris", 5, "televisor"));
            modelos.Add(new Modelo("Ford F100", "verde", 7, "palo de golf"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Honda Civic", "verde", 7, "palo de golf"));
            modelos.Add(new Modelo("Volkswagen Gol", "blanco", 5, "tostadora"));
            modelos.Add(new Modelo("Renault 19", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            
            Pista10 pista = new Pista10();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa10()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "gris", 5, "televisor"));
            modelos.Add(new Modelo("Ford F100", "verde", 7, "palo de golf"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Honda Civic", "verde", 7, "palo de golf"));
            modelos.Add(new Modelo("Volkswagen Gol", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Renault 19", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));

            Pista10 pista = new Pista10();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
