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
       var fatores = string.Empty;

        int i = 2;
        
        while(i < numeroInteiro)
        {
            if (!VerificarPrimo(i)) 
            {
                i++;
                continue;
            }

            var resultadoTemp = proximoResultado/i;

          

            if (proximoResultado % i != 0)
            {
                i++;
            }
            else
            {
                proximoResultado = resultadoTemp;

                fatores += $"{i}x";
            }

            if(resultadoTemp == 1)
            {
               break;   
            }
        }

        return fatores;
        //numeroInteiro == 100 ? "2x2x5x5" : "2x3";
    }

    public bool VerificarPrimo(int numeroInteiroPrimo)
    {
        //int fator = numeroInteiroPrimo / 2;

        for (var i = 2; i < numeroInteiroPrimo; i++)
        {
            if (numeroInteiroPrimo % i == 0)
                return false;
        }

        return true;
    }
}
