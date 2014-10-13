using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista4
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha4()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "bordo", 5, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista4 pista = new Pista4();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaIzquierda4()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "bordo", 3, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista4 pista = new Pista4();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsa4()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "bordo", 3, "tostadora"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista4 pista = new Pista4();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
