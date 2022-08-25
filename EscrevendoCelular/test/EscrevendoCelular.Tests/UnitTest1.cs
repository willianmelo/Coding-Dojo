namespace EscrevendoCelular.Tests;

public class UnitTest1
{
    [Theory]
    // Arrange
    [InlineData("A", "2")]
    [InlineData("B", "22")]
    [InlineData("C", "222")]
    [InlineData("D", "3")]
    [InlineData("E", "33")]
    [InlineData("F", "333")]
    [InlineData("P", "7")]
    [InlineData("Q", "77")]
    [InlineData("R", "777")]
    [InlineData("S", "7777")]
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

    [Fact]
    public void Translate_Returns_2_22_2_WhenTypying_ABA()
    {
        // Arrange
        var word = "ABA";

        // Act
        var result = new Translator().Interprete(word);

        // Assert
        Assert.Equal("2_22_2", result);
    }

    [Fact]
    public void Translate_Returns_7337772_WhenTypying_PERA()
    {
        // Arrange
        var word = "PERA";

        // Act
        var result = new Translator().Interprete(word);

        // Assert
        Assert.Equal("7337772", result);
    }
}