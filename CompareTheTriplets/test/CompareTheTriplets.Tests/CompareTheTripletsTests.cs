//namespace CompareTheTriplets.Tests;

public class CompareTheTripletsTests
{
    private readonly Comparador _comparador;
    
    public CompareTheTripletsTests()
    {
        _comparador = new Comparador();
    }
    
    [Fact]
    public void CompareTriplets_AliceMaiorPontuacao_Alice3Bob0()
    {
        // arrange 
        var pontuacaoAlice = new List<int> { 5, 5, 5 };
        var pontuacaoBob = new List<int> { 1, 1, 1 };

        // act
        var resultado =_comparador.CompareTriplets(pontuacaoAlice, pontuacaoBob);

        // assert
        Assert.Equal(new List<int> { 3, 0 }, resultado);
    }

    [Fact]
    public void CompareTriplets_AliceMenorPontuacao_Alice0Bob3()
    {
        // arrange 
        var pontuacaoAlice = new List<int> { 1, 1, 1 };
        var pontuacaoBob = new List<int> { 5, 5, 5 };

        // act
        var resultado =_comparador.CompareTriplets(pontuacaoAlice, pontuacaoBob);

        // assert
        Assert.Equal(new List<int> { 0, 3 }, resultado);
    }

    [Fact]
    public void CompareTriplets_AliceBobIgual_Alice0Bob0()
    {
        // arrange 
        var pontuacaoAlice = new List<int> { 1, 97, 3 };
        var pontuacaoBob = new List<int> { 1, 97, 3 };

        // act
        var resultado = _comparador.CompareTriplets(pontuacaoAlice, pontuacaoBob);

        // assert
        Assert.Equal(new List<int> { 0, 0 }, resultado);
    }

    [Fact]
    public void CompareTriplets_AliceMaiorMisto_Alice2Bob1()
    {
        // arrange 
        var pontuacaoAlice = new List<int> { 2, 97, 3 };
        var pontuacaoBob = new List<int> { 1, 90, 5 };

        // act
        var resultado = _comparador.CompareTriplets(pontuacaoAlice, pontuacaoBob);

        // assert
        Assert.Equal(new List<int> { 2, 1 }, resultado);
    }
}
