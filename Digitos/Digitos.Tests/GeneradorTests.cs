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
            var result = this.sut.GetCadena(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void GetSegundoCaracterTest()
        {
            var result = this.sut.GetCadena(2);
            Assert.AreEqual("12", result);
        }

        [TestMethod]
        public void GetVeinteCaracteresTest()
        {
            var result = this.sut.GetCadena(20);
            Assert.AreEqual("123456789101112131415", result);
        }
    }
}
