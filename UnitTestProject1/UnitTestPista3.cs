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
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Ford F100", "rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaizquierda3()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "tostadora"));
            modelos.Add(new Modelo("Ford F100", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa3()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 4, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "Negro", 3, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 6, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 5, "jaula"));

            Pista3 pista = new Pista3();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
