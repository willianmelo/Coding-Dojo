using GeracaoFatoresPrimos;

namespace tests{
    public class GeracaoFatoresTests
    {
        [Fact]
        public void RetornarPrimos_consegue_calcular_fatores_para_6()
        {
            var numeroInteiroNaoPrimo = 6;

            var resultado = new GeracaoFatores().RetornarPrimos(numeroInteiroNaoPrimo);
            Assert.Equal("2x3", resultado);
        }


        [Fact]
        public void VerificarPrimo_retorna_verdadeiro_se_primo()
        {
            var numeroInteiroPrimo = 21;

            var resultado = new GeracaoFatores().VerificarPrimo(numeroInteiroPrimo);
            
            Assert.Equal(false, resultado);
        }

        [Theory]
        [InlineData(5,"5")]
        [InlineData(2,"2")]
        [InlineData(7,"7")]
        public void RetornarPrimos_retorna_proprio_numero_se_for_primo(int numeroInteiro, string resultadoDeveria)
        {
            var resultado = new GeracaoFatores().RetornarPrimos(numeroInteiro);

            Assert.Equal(resultadoDeveria, resultado);
        }

        [Theory]
        [InlineData(33,"3x11")]
        [InlineData(100,"2x2x5x5")]
        public void RetornarPrimos_consegue_calcular_fatores_para_nao_primos(int numeroInteiro, string resultadoDeveria)
        {
            var resultado = new GeracaoFatores().RetornarPrimos(numeroInteiro);

            Assert.Equal(resultadoDeveria, resultado);
        }
    }
}