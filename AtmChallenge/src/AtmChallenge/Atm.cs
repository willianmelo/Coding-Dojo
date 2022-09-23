namespace AtmChallenge;

public class Atm
{
    private List<int> _availableNotes;
    public Atm()
    {
        _availableNotes = new List<int> { 100, 50, 20, 10 };
    }

    public List<int> Withdraw(int amount)
    {
        var notes = new List<int>();

        foreach (var note in _availableNotes)
        {
            while (amount >= note) 
            {
                amount = AdjustBalance(notes, amount, note);
            }
                
            if (amount == 0) break;
        }

        return notes.OrderBy(note => note).ToList();
    }

    private int AdjustBalance(IList<int> notes, int amount, int note)
    {
        amount -= note;
        notes.Add(note);

        return amount;
    }
}
