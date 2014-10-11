using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista6
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha6()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "notebook"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista6 pista = new Pista6();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaIzquierda6()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "notebook"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista6 pista = new Pista6();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBordo6()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "notebook"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista6 pista = new Pista6();
            Assert.AreEqual(-1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoNotebook6()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "palo de golf"));
            modelos.Add(new Modelo("Toyota Corolla", "Bordo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista6 pista = new Pista6();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
