using Projeto_teste;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //act - a��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verifica��o
            Assert.Equal(rNum, resultado);

        }
        //arrange
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 2)]
        [InlineData(3, 3, 6)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - ac��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verifica��o
            Assert.Equal(rNum, resultado);

        }
    }
}