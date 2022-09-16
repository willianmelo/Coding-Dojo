namespace BirthdayCakeCandles;

public class ContadorVelas
{
    public int ObterMaior(List<int> velas)
    {
        return velas
            .GroupBy(vela => vela)
            .OrderByDescending(agrupamento => agrupamento.Count())
            .First()
            .Count();
    }
}
