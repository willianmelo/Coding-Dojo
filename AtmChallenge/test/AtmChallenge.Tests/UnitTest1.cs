using AtmChallenge;

namespace AtmChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void Withdrawl_WhenAskedTenReais_ReturnsOneNoteOfTenReais()
    {
        var expected = new List<int>(){10};

        var result = Atm.Withdraw(10);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedThirtyReais_ReturnsOneNoteOfTenReaisAndOneOfTwenty()
    {
        var expected = new List<int>{ 10, 20 };
 
        var result = Atm.Withdraw(30);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedEightyReais_ReturnsOneNoteOfFiftyReaisAndOneOfTwentyAndOneNoteOfTen()
    {
        var expected = new List<int>{ 10, 20, 50 };
 
        var result = Atm.Withdraw(80);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedHundredReais_ReturnsOneNoteOfHundredReais()
    {
        var expected = new List<int>{ 100 };
 
        var result = Atm.Withdraw(100);

        Assert.Equal(expected, result);
    }
}