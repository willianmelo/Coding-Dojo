//namespace CompareTheTriplets;
public class Comparador
{
    public List<int> CompareTriplets(List<int> playerA, List<int> playerB)
    {
        var scoreA = 0;
        var scoreB = 0;

        for(var i = 0; i < 3; i++)
        {
            if (playerA[i] > playerB[i]) 
            {
                scoreA++;
            }
            else if(playerB[i] > playerA[i])
            {
                scoreB++;
            }
        }

        return new List<int> { scoreA, scoreB };
    }
}
