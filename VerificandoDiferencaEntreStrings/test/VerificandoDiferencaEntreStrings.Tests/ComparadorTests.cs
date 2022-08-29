namespace Comparador.Tests;

public class ComparadorTests
{
    [Theory]
    [InlineData("Teste","Test")]
    [InlineData("Testeeeeee","Test")]
    public void Comparar_RetornaLetraDiferente_QuandoPalavrasSãoDiferentes()
    {
        const string frase1 = "Teste";
        const string frase2 = "Test";

        var comparacao = new Comparador().Comparar(frase1, frase2);

        Assert.Equal("Test[e] Test", comparacao);
    }

    [Fact]
    public void Comparar_RetornaLetraDiferente_QuandoPalavrasSãoDiferentes2()
    {
        const string frase1 = "Testeeeeee";
        const string frase2 = "Test";

        var comparacao = new Comparador().Comparar(frase1, frase2);

        Assert.Equal("Test[eeeeee] Test", comparacao);
    }

    [Fact]
    public void Comparar_RetornaLetraDiferente_QuandoPalavrasSãoIguais()
    {
        const string frase1 = "Teste";

        var comparacao = new Comparador().Comparar(frase1, frase1);

        Assert.Equal("Teste Teste", comparacao);
    }

    // [Fact]
    // public void Comparar_Destaques_EmUmaUnicaPalavra()
    // {
    //     const string frase1 = "vermelho";
    //     const string frase2 = "amarelo";

    //     var comparacao = new Comparador().Comparar(frase1, frase2);

    //     Assert.Equal("[vermelh]o [amarel]o", comparacao);
    // }
}