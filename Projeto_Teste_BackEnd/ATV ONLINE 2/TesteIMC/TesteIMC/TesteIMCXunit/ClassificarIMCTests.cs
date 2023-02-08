using Xunit;
using TestarIMC;
using TesteIMC;

namespace TesteIMCXunit
{
    public class ClassificarIMCTests
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            //arange - organizar e prepara o teste
            double imc = 28;

            //act - agir - execução / chamado do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert - comportamento esperado, comportamento obtido
            Assert.Equal("Sobrepeso", classificacaoIMC);
        }
        [Theory]
        [InlineData(28,"Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]

        public void ClasificarIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
