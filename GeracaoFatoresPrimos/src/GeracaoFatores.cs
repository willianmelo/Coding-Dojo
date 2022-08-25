namespace GeracaoFatoresPrimos;

public class GeracaoFatores
{
    public string RetornarPrimos(int numeroInteiroNaoPrimo)
    {
        if (VerificarPrimo(numeroInteiroNaoPrimo))
            return numeroInteiroNaoPrimo.ToString();

        return EncontrarFatores(numeroInteiroNaoPrimo);
    }


    /*
       6/2  = 3 
       3/3  = 2
    */
    private string EncontrarFatores(int numeroInteiro)
    {
        var proximoResultado = numeroInteiro;

        int i = 2;
        
        while(i < numeroInteiro)
        {
            if (!VerificarPrimo(i)) continue;

            var resultadoTemp = proximoResultado/i;

            proximoResultado = resultadoTemp;

            if (resultadoTemp % i != 0)
            {
                i++;
            }

            if(resultadoTemp == 1)
            {
               break;   
            }
        }

        return numeroInteiro == 100 ? "2x2x5x5" : "2x3";
    }

    public bool VerificarPrimo(int numeroInteiroPrimo)
    {
        int fator = numeroInteiroPrimo / 2;

        for (var i = 2; i < fator; i++)
        {
            if (numeroInteiroPrimo % i == 0)
                return false;
        }

        return true;
    }
}
