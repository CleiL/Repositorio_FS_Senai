using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //clasee de teste a executar
    [TestClass]
    public class CalculoIMCTests
    {
        //método de teste
        [TestMethod]
        public void CalcularIMC()
        {
            //arange - organizar e prepara o teste
            double peso = 110;
            double altura = 1.79;

            //act - agir - execução / chamado do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //assert - comportamento esperado, comportamento obtido
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
