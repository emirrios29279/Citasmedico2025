using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;

namespace WebApplication1.Tests
{
    [TestClass]
    public class OperacionesTests
    {
        [TestMethod]
        public void Sumar_DeberiaDevolverResultadoCorrecto()
        {
            // ✅ Éxito
            var op = new Operaciones();
            int resultado = op.Sumar(2, 3);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Sumar_DeberiaDevolverCincoCuandoSumaDosMasTres()
        {
            // ✅ Éxito también
            var op = new Operaciones();
            int resultado = op.Sumar(2, 3);
            Assert.AreEqual(5, resultado);
        }
    }
}
