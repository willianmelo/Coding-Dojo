using System.Collections.Generic;
namespace EscrevendoCelular;
public class Translator
{
    private IDictionary<string, string> _translators = new Dictionary<string, string>
    {
        {"A", "2"},
        {"B", "22"},
        {"C", "222"},
        {"D", "3"},
        {"E", "33"},
        {"F", "333"},
        {"P", "7"},
        {"Q", "77"},
        {"R", "777"},
        {"S", "7777"}
    };

    public string Interprete(string word)
    {
        var expected = string.Empty;
        var previousKey = string.Empty;
        
        foreach (var letter in word)
        {
            var typeSequence = _translators[letter.ToString()];

            if (!HasPreviousKey(previousKey) && typeSequence.Contains(previousKey))
                expected += "_";

            expected += typeSequence;
            previousKey = typeSequence[0].ToString();
        }

        return expected;
    }

    private KeyValuePair<string, string> GetKeyValuePair(char letter)
    {
        return _translators.First(x => x.Key.Contains(letter));
    }

    private bool HasPreviousKey(string previousKey) => string.IsNullOrWhiteSpace(previousKey);
}
