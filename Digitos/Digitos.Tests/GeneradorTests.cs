namespace Digitos.Tests
{
    using Domain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneradorTests
    {
        IGenerador sut;
         
        [TestInitialize]
        public void Setup()
        {
            this.sut = new Generador();
        }

        [TestMethod]
        public void GetPrimerCaracterTest()
        {
            var result = this.sut.GetParteCadena(1, 1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void GetSegundoCaracterTest()
        {
            var result = this.sut.GetParteCadena(2, 1);
            Assert.AreEqual("2", result);
        }
    }
}
