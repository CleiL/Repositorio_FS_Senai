using Projeto_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verificação
            Assert.AreEqual(rNum, resultado);

        }
        //arrange
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,2)]
        [DataRow(3,3,6)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - acção
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verificação
            Assert.AreEqual(rNum, resultado);

        }

    }
}