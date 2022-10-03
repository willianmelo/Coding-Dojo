namespace Jokenpo;

public static class JokenpoReferee
{

    public static string DetermineWinner(string gesture1, string gesture2) => 
    ((gesture1, gesture2)) switch
        {
            ("rock", "paper") or ("paper", "rock") => "paper beats rock",
            ("rock", "scissors") or ("scissors", "rock") => "rock beats scissors",
            ("paper", "scissors") or ("scissors", "paper") => "scissors beats paper",
            (_, _) => "draw"
        };
}

