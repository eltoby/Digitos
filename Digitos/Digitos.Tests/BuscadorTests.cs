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
            generador.Setup(x => x.GetCadena(1)).Returns("1");
            generador.Setup(x => x.GetCadena(2)).Returns("12");
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
    }
}
