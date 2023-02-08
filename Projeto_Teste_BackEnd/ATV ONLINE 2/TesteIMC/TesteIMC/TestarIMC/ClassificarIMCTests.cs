using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteIMC;

namespace TestarIMC
{
    //clasee de teste a executar
    [TestClass]
    public class ClassificarIMCTests
    {
        //método de teste
        [TestMethod]
        public void ClassificarIMC()
        {
            //arange - organizar e prepara o teste
            double imc = 28;

            //act - agir - execução / chamado do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert - comportamento esperado, comportamento obtido
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
