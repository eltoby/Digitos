namespace Digitos.Tests
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    [TestClass]
    public class BuscadorTests
    {
        private IBuscador buscador;

        [TestInitialize]
        public void Setup()
        {
            var generador = new Mock<IGenerador>();
            generador.Setup(x => x.GetCadena(It.IsInRange(1, 20, Range.Inclusive))).Returns("123456789101112131415");
            this.buscador = new Buscador(generador.Object); 
        }

        [TestMethod]
        public void Buscar1()
        {
            var result = this.buscador.Buscar(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Buscar2()
        {
            var result = this.buscador.Buscar(2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Buscar91()
        {
            var result = this.buscador.Buscar(91);
            Assert.AreEqual(9, result);
        }
    }
}
