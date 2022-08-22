using Dojo;
namespace DojoSimpleArraySum.Tests;

public class UnitTest1
{
    [Fact]
    public void SumArray_ReturnsSix_WhenArrayIsArray123()
    {
        //Arrange
        var valorEsperado = 6;

        var array = new List<int>{1, 2, 3};

        var resultado = new SomarValoresArray().SumArray(array);
        
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void SummArray_ArrayIsNull_ThrowException()
    {
        //Arrange
        var soma = new SomarValoresArray();

        //Act
        Action result = () => soma.SumArray(null);

        //Assert
        Assert.Throws<ArgumentNullException>(result);
    }
}
