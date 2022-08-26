namespace Comparador;
public class Comparador
{
    public string Comparar(string frase1, string frase2)
    {
        if (frase1 == frase2)
            return $"{frase1} {frase2}";

        var lengthFrase1 = frase1.Length;
        var lengthFrase2 = frase2.Length;

        int indiceDiferenca = -1;

        var resultadoFrase1 = string.Empty;
        var resultadoFrase2 = string.Empty;

        if (lengthFrase1 > lengthFrase2)
        {
            for (var i = 0; i < lengthFrase2; i++)
            {
                if (frase1[i] != frase2[i] && indiceDiferenca < 0)
                {
                    indiceDiferenca = i;

                    resultadoFrase1 += resultadoFrase1.Contains("[") ? "]" : "[";
                    resultadoFrase2 += resultadoFrase2.Contains("[") ? "]" : "[";
                }

                resultadoFrase1 += frase1[i].ToString();
                resultadoFrase2 += frase2[i].ToString();

                //frase2 Test for
                //frase1 Test[e]
                if (i == lengthFrase2 - 1)
                {
                    var substring = frase1.Substring(i +1);
                    resultadoFrase1 += $"[{substring}]";
                }
            }

            // resultadoFrase1 += "]";
            // resultadoFrase2 += "]";
        }
        else
        {
            //for
        }

        return $"{resultadoFrase1} {resultadoFrase2}";
    }
}
