using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista9
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha9()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Honda Civic", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista9 pista = new Pista9();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaIzquierda9()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Honda Civic", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista9 pista = new Pista9();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsoNoTostadora9()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "noteboook"));
            modelos.Add(new Modelo("Honda Civic", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista9 pista = new Pista9();
            Assert.AreEqual(-1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsoNoCivic9()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "noteboook"));
            modelos.Add(new Modelo("Toyota Corolla", "Gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista9 pista = new Pista9();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
