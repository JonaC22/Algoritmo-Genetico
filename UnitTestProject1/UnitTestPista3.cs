using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista3
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha3()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Ford F100", "Rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaizquierda3()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "tostadora"));
            modelos.Add(new Modelo("Ford F100", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa3()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "Blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "Rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
