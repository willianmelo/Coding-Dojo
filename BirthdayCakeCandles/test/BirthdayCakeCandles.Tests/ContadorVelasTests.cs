namespace BirthdayCakeCandles.Tests;

public class ContadorVelasTests
{
    private ContadorVelas _calculadoraVelas = new ContadorVelas();

    // Refatorar -> reescrever a mesma lógica sem novas regras de negócio porém de forma mais clean
    // e utilizando design patterns adequados. Começamos com XGH e terminamos com Clean Code + GoF patterns

    // {1} -> Retorna 1
    // {1, 2} -> Retorna 1, passa também
    // {1, 1} -> Aqui já iria requerer um "if", porém um if baseado em tamanho do array
    //   não resolve, logo já iniciariamos a implemetação do algoritmo em si
    //   Contudo, isso para este tipo de exercicio, pode ser que em outro usar um
    //   "if" pode ser usado -> if (len === 1) return 1; else if (len === 2) return 2;
    // {1, 2, 3} -> Retorna 1, passa também
    // {1, 1, 1} -> Retorna 3, como fizemos o algoritimo 2 passos atras, vai passar também
    // aqui já precisamos de teste mais complexos e isso pode gerar alteração do algoritmo 
    // implementado

    [Fact]
    public void ObterMaior_UmaListComQuatroInteiros_RetornarDois()
    {
        //Arrange
        var velas = new List<int> { 3, 1, 2, 3 };

        var esperado = 2;

        //Act
        var resultado = _calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObterMaior_UmaListComQuatroInteiro_RetornarTres()
    {
        //Arrange
        var velas = new List<int> { 3, 1, 3, 3 };

        var esperado = 3;

        //Act
        var resultado = _calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObterMaior_UmaListComDoisIguais_RetornarDois()
    {
        //Arrange
        var velas = new List<int> { 3, 3 };

        var esperado = 2;

        //Act
        var resultado = _calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObterMaior_UmaListComDoisDiferentes_RetornaUm()
    {
        //Arrange
        var velas = new List<int> { 3, 2 };

        var esperado = 1;

        //Act
        var resultado = _calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObterMaior_UmaListComDiversosInteiros_RetornarQuatro()
    {
        //Arrange
        var velas = new List<int> { 5, 2, 1, 5, 7, 5, 7, 3, 1, 7, 4, 7};

        var esperado = 4;

        //Act
        var resultado = _calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }
}

