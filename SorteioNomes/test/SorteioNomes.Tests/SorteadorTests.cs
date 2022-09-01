namespace SorteioNomes.Tests;

public class SorteadorTests
{
    [Fact]
    public void Sortear_DadoTresNomesEmOrdemAlfabetica_RetornaListaEmOrdemAleatoria()
    {
        // Arrange
        var nomes = new List<string>{"Anna", "Bob", "Charlie"};
        var sorteador = new Sorteador();

        // Act
        var result = sorteador.Sortear(nomes);

        // Assert
        Assert.NotEqual(nomes, result);
    }

    [Fact]
    public void Sortear_DadoTresNomes_NaoPossuiRepeticao() 
    {
        // Arrange
        var nomes = new List<string>{"Anna", "Bob", "Charlie"};
        var sorteador = new Sorteador();

        // Act
        var result = sorteador.Sortear(nomes);

        // Assert
        Assert.True(result.Contains("Anna"));
        Assert.True(result.Contains("Bob"));
        Assert.True(result.Contains("Charlie"));
        Assert.True(result.Count == 3);
    }

    [Fact]
    public void Sortear_DadoDoisNomes_RetornaListaEmOrdemAleatoria()
    {
        // Arrange
        var nomes = new List<string>{"Anna", "Bob"};
        var sorteador = new Sorteador();

        // Act
        var result = sorteador.Sortear(nomes);

        // Assert
        Assert.NotEqual(nomes, result);
    }
    
    [Fact]
    public void Sortear_UmNome_RetornaNome()
    {
        // Arrange
        var nomes = new List<string>{"Anna"};
        var sorteador = new Sorteador();

        // Act
        var result = sorteador.Sortear(nomes);

        // Assert
        Assert.Equal(nomes, result);
    }
}
