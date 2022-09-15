namespace EscrevendoCelular;
public class Calcular
{
    public int ObterMaior(List<int> velas)
    {   
        return velas.GroupBy(vela => vela).Where(vela => vela.Count() > 1).First().Count();
    }
}
