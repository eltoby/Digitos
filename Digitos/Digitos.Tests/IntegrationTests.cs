namespace Digitos.Tests
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegrationTests
    {
        private IBuscador buscador;

        [TestInitialize]
        public void Setup()
        {
            var generador = new Generador();
            this.buscador = new Buscador(generador);

        }

        [TestMethod]
        public void Test15()
        {
            var result = this.buscador.Buscar(15);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Test34()
        {
            var result = this.buscador.Buscar(34);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test142()
        {
            var result = this.buscador.Buscar(142);
            Assert.AreEqual(73, result);
        }
    }
}
