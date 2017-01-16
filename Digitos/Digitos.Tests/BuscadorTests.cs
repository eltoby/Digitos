namespace Digitos.Tests
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BuscadorTests
    {
        [TestMethod]
        public void Buscar1()
        {
            var buscador = new Buscador();
            var result = buscador.Buscar(1);
            Assert.AreEqual(1, result);
        }
    }
}
