using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoritmosGeneticos.Domain;
using AlgoritmosGeneticos.Domain.Pistas;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPista8
    {
        [TestMethod]
        public void TestCondicionVerdaderaDerecha8()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "botiquin"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista8 pista = new Pista8();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionVerdaderaIzquierda8()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "botiquin"));
            modelos.Add(new Modelo("Toyota Corolla", "gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista8 pista = new Pista8();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBotiquin8()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "gris", 5, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista8 pista = new Pista8();
            Assert.AreEqual(-1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoTelevisor8()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 2, "tostadora"));
            modelos.Add(new Modelo("Fiat Uno", "negro", 3, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "rojo", 4, "pelota de futbol"));
            modelos.Add(new Modelo("Toyota Corolla", "gris", 5, "notebook"));
            modelos.Add(new Modelo("Toyota Corolla", "blanco", 6, "jaula"));
            modelos.Add(new Modelo("Toyota Corolla", "verde", 7, "palo de golf"));

            Pista8 pista = new Pista8();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
