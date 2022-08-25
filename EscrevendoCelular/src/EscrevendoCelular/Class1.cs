using System.Collections.Generic;
namespace EscrevendoCelular;
public class Translator
{
    private IDictionary<string, string> _translators = new Dictionary<string, string>
    {
        { "ABC" , "2"}
    };

    public string Interprete(string word)
    {
        //_translators.TryGetValue(word, out var expected);
        var expected = string.Empty;
        foreach (var item in word)
        {
            var keyValue = GetKeyValuePair(item);
            var quantity = keyValue.Key.IndexOf(item) + 1;
            expected += keyValue.Value;
        }

        return expected;
    }

    private KeyValuePair<string, string> GetKeyValuePair(char letter)
    {
        return _translators.First(x => x.Key.Contains(letter));
    }
}
