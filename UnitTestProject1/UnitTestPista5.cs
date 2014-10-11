using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista5
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha5()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Negro", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista5 pista = new Pista5();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaIzquierda5()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Negro", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista5 pista = new Pista5();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBlanco5()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Verde", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Verde", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Negro", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista5 pista = new Pista5();
            Assert.AreEqual(-1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoNegro5()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Verde", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista5 pista = new Pista5();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
