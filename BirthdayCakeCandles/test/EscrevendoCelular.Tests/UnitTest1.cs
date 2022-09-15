namespace EscrevendoCelular.Tests;

public class UnitTest1
{
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
    public void Metodo_UmaListComQuatroInteiros_RetornarDois()
    {
        //Arrange
        var velas = new List<int>{3, 1, 2, 3};
        var calculadoraVelas = new Calcular();
        var esperado = 2;

        //Act
        var resultado = calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
     public void Metodo_UmaListComQuatroInteiro_RetornarTres()
    {
        //Arrange
        var velas = new List<int>{3, 1, 3, 3};
        var calculadoraVelas = new Calcular();
        var esperado = 3;

        //Act
        var resultado = calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
     public void Metodo_UmaListComDoisIguais_RetornarDois()
    {
        //Arrange
        var velas = new List<int>{3, 3};
        var calculadoraVelas = new Calcular();
        var esperado = 2;

        //Act
        var resultado = calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Metodo_UmaListComDoisDiferentes_RetornaUm()
    {
        //Arrange
        var velas = new List<int>{3, 2};
        var calculadoraVelas = new Calcular();
        var esperado = 1;

        //Act
        var resultado = calculadoraVelas.ObterMaior(velas);

        //Assert
        Assert.Equal(esperado, resultado);
    }
}

