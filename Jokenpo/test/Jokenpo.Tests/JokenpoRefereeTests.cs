namespace Jokenpo.Tests;

public class JokenpoRefereeTests
{
    [Theory]
    [InlineData("rock", "rock")]
    [InlineData("paper", "paper")]
    [InlineData("scissors", "scissors")]
    public void DetermineWinner_Draw_WhenRockAndRock(string gesture1, string gesture2)
    {
        var expected = "draw";

        var result = JokenpoReferee.DetermineWinner(gesture1, gesture2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("rock", "scissors")]
    [InlineData("scissors", "rock")]
    public void DetermineWinner_RockBeatsScissors_WhenRockAndScissors(string gesture1, string gesture2)
    {
        var expected = "rock beats scissors";

        var result = JokenpoReferee.DetermineWinner(gesture1, gesture2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("paper", "rock")]
    [InlineData("rock", "paper")]
    public void DetermineWinner_PaperBeatsRock_WhenPaperAndRock(string gesture1, string gesture2)
    {
        var expected = "paper beats rock";

        var result = JokenpoReferee.DetermineWinner(gesture1, gesture2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("scissors", "paper")]
    [InlineData("paper", "scissors")]
    public void DetermineWinner_ScissorsBeatsPaper_WhenScissorAndPaper(string gesture1, string gesture2)
    {
        var expected = "scissors beats paper";

        var result = JokenpoReferee.DetermineWinner(gesture1, gesture2);

        Assert.Equal(expected, result);
    }
}