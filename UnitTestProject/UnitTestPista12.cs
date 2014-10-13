using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmosGeneticos.Domain.Pistas;
using AlgoritmosGeneticos.Domain;

namespace UnitTestProject
{ 
    [TestClass]
    public class UnitTestPista12
    {
        [TestMethod]
        public void TestCondicionVerdadera12()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 5, "tostadora"));
            modelos.Add(new Modelo("Ford F100", "rojo", 3, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "bordo", 1, "televisor"));
            modelos.Add(new Modelo("Honda Civic", "verde", -1, "notebook"));
            modelos.Add(new Modelo("Volkswagen Gol", "blanco", -1, "pelota de futbol"));
            modelos.Add(new Modelo("Renault 19", "azul", 3, "jaula"));
            modelos.Add(new Modelo("Fiat Uno", "blanco", 4, "jaula"));

            Pista12 pista = new Pista12();
            Assert.AreEqual(1, pista.validar(modelos));
        }

        [TestMethod]
        public void TestCondicionFalsaNoBlanco12()
        {
            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo("Chevrolet Corsa", "blanco", 5, "tostadora"));
            modelos.Add(new Modelo("Ford F100", "rojo", 3, "televisor"));
            modelos.Add(new Modelo("Toyota Corolla", "bordo", 1, "televisor"));
            modelos.Add(new Modelo("Honda Civic", "verde", -1, "notebook"));
            modelos.Add(new Modelo("Volkswagen Gol", "blanco", -1, "pelota de futbol"));
            modelos.Add(new Modelo("Renault 19", "azul", 3, "jaula"));
            modelos.Add(new Modelo("Fiat Uno", "blanco", 6, "jaula"));
            
            Pista12 pista = new Pista12();
            Assert.AreEqual(-1, pista.validar(modelos));
        }
    }
}
