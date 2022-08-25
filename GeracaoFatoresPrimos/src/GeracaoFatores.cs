namespace GeracaoFatoresPrimos;

public class GeracaoFatores
{
    public string RetornarPrimos(int numeroInteiroNaoPrimo)
    {
        if (VerificarPrimo(numeroInteiroNaoPrimo))
            return numeroInteiroNaoPrimo.ToString();

        return EncontrarFatores(numeroInteiroNaoPrimo);
    }

    private string EncontrarFatores(int numeroInteiro)
    {
       var proximoResultado = numeroInteiro;
       var fatores = string.Empty;

        int i = 2;
        
        while(proximoResultado != 1)
        {
            if (!VerificarPrimo(i)) 
            {
                i++;
                continue;
            }

            if (proximoResultado % i != 0) i++;
            else
            {
                proximoResultado = proximoResultado / i;
                fatores += fatores == string.Empty ? i.ToString() :  $"x{i}";
            }
        }

        return fatores;
    }

    public bool VerificarPrimo(int numeroInteiroPrimo)
    {
        for (var i = 2; i < numeroInteiroPrimo; i++)
        {
            if (numeroInteiroPrimo % i == 0)
                return false;
        }

        return true;
    }
}
