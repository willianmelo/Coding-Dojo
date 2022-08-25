using System.Collections.Generic;
namespace EscrevendoCelular;
public class Translator
{
    private IDictionary<string, string> _translators = new Dictionary<string, string>
    {
        { "A" , "2"},
        { "B" , "22"},
        { "C" , "222"}
    };

    public string Interprete(string word)
    {
        //_translators.TryGetValue(word, out var expected);
        var expected = string.Empty;
        var previousKey = string.Empty;

        foreach (var letter in word)
        {
            var keyValue = GetKeyValuePair(letter);
            //var quantity = keyValue.Key.IndexOf(letter) + 1;

            if(keyValue.Value.Length > 1 && keyValue.Value.Equals(previousKey[0]))
                expected += "_";

            expected += keyValue.Value;
            previousKey = keyValue.Value[0].ToString();
        }

        return expected;
    }

    private KeyValuePair<string, string> GetKeyValuePair(char letter)
    {
        return _translators.First(x => x.Key.Contains(letter));
    }
}
