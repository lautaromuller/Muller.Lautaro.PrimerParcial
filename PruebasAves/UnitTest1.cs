using Entidades;
using System;

namespace PruebasAves
{
    [TestClass]
    public class ZoologicoTests
    {
        [TestMethod]
        public void OrdenarPorNombre_CuandoRecibeBYA_DeberiaRetornarPrimeroAYDespuesB()
        {
            // Arrange
            Zoologico<Ave> zoologico = new Zoologico<Ave>();
            Halcon halcon = new Halcon("B", Habitat.Bosque, 4, 1.5, "Amplio");
            Pinguino pinguino = new Pinguino("A", Habitat.Antartida, 2, 6, "Emperador");
            zoologico += halcon;
            zoologico += pinguino;

            // Act
            zoologico.OrdenarPorNombre();

            // Assert
            Assert.AreEqual("A", zoologico.Aves.First().Nombre);
            Assert.AreEqual("B", zoologico.Aves.Last().Nombre);
        }

        [TestMethod]
        public void OrdenarPorEdad_CuandoRecibe3Y5_DeberiaRetornarPrimero3YDespues5()
        {
            // Arrange
            Zoologico<Ave> zoologico = new Zoologico<Ave>();
            Halcon halcon = new Halcon("B", Habitat.Bosque, 3, 1.5, "Amplio");
            Pinguino pinguino = new Pinguino("A", Habitat.Antartida, 5, 6, "Emperador");
            zoologico += halcon;
            zoologico += pinguino;

            // Act
            zoologico.OrdenarPorEdad();

            // Assert
            Assert.AreEqual(3, zoologico.Aves.First().Edad);
            Assert.AreEqual(5, zoologico.Aves.Last().Edad);
        }
    }

    [TestClass]
    public class HalconTests
    {
        [TestMethod]
        public void Volar_DeberiaMostrarMensajeCorrecto()
        {
            //Arrange
            Halcon halcon = new Halcon("Jose", Habitat.Montaña, 6, 2, "Corto");

            //Act
            string resultado = halcon.Volar();

            //Assert
            Assert.AreEqual($"{halcon.Nombre} está volando con una envergadura de {halcon.Envergadura} metros.", resultado);
        }

        [TestMethod]
        public void RealizarAccion_DeberiaMostrarMensajeCorrecto()
        {
            //Arrange
            Halcon halcon = new Halcon("Jose", Habitat.Montaña, 6, 2, "Corto");
            string accion = "durmiendo";
            //Act
            string resultado = halcon.RealizarAccion(accion);

            //Assert
            Assert.AreEqual($"El halcón {halcon.Nombre} esta {accion}", resultado);
        }
    }

    [TestClass]
    public class AveTests
    {
        [TestMethod]
        public void Equals_ComparadoConAveIgual_DeberiaDevolverTrue()
        {
            // Arrange
            Pinguino pinguino1 = new Pinguino("Martin", Habitat.Antartida, 10, 5.0, "Antártico");
            Pinguino pinguino2 = new Pinguino("Martin", Habitat.Antartida, 10, 5.0, "Antártico");

            // Act
            var resultado = pinguino1.Equals(pinguino2);

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}