namespace EscrevendoCelular.Tests;

public class UnitTest1
{
    [Theory]
    // Arrange
    [InlineData("A", "2")]
    [InlineData("B", "22")]
    [InlineData("C", "222")]
    public void Translate_ReturnsNumber_WhenTypyingALetter(string word, string expected)
    {
        // Act
        var result = new Translator().Interprete(word);

        // Assertsdasd
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Translate_Returns2_22_WhenTypyingAB()
    {
        // Arrange
        var word = "AB";

        // Act
        var result = new Translator().Interprete(word);

        // Assert
        Assert.Equal("2_22", result);
    }
    
}