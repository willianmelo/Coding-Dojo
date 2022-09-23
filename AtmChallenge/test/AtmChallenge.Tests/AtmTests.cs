using System.Runtime.InteropServices.ComTypes;
using AtmChallenge;

namespace AtmChallenge.Tests;

public class AtmTests
{
    private Atm _atm;
    public AtmTests()
    {
        _atm = new Atm();
    }
    [Fact]
    public void Withdrawl_WhenAskedTenReais_ReturnsOneNoteOfTenReais()
    {
        var expected = new List<int>(){10};

        var result = _atm.Withdraw(10);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedThirtyReais_ReturnsOneNoteOfTenReaisAndOneOfTwenty()
    {
        var expected = new List<int>{ 10, 20 };

        var result = _atm.Withdraw(30);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedEightyReais_ReturnsOneNoteOfFiftyReaisAndOneOfTwentyAndOneNoteOfTen()
    {
        var expected = new List<int>{ 10, 20, 50 };

        var result = _atm.Withdraw(80);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Withdrawl_WhenAskedHundredReais_ReturnsOneNoteOfHundredReais()
    {
        var expected = new List<int>{ 100 };

        var result = _atm.Withdraw(100);

        Assert.Equal(expected, result);
    }
}
