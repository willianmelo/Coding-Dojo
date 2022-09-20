namespace AtmChallenge;
public static class Atm
{
    public static List<int> Withdraw(int amount)
    {
        List<int> notes = new List<int>(); 

        while (amount > 0)
        {
            if (amount >= 100)
            {
                amount = amount - 100;
                notes.Add(100);
            }
            else if (amount >= 50)
            {
                amount = amount - 50;
                notes.Add(50);
            }
            else if (amount >= 20)
            {
                amount = amount - 20;
                notes.Add(20);
            }
            else
            {
                amount = amount - 10;
                notes.Add(10);
            }
         }
        
        return notes.OrderBy(note => note).ToList();
    }
}
