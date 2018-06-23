using BaltaStore.Domain.LojaContexto.Entidades;
using BaltaStore.Domain.LojaContexto.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Cliente(
                new Nome("Rodrigo", "Ferreira"),
                new CpfVO("21439107401874"),
                new EmailVO("roferreira122@gmail.com"),
                "44999107295",
                "Rua Rio Tibiriça 95"
            );
              
        }
    }
}
