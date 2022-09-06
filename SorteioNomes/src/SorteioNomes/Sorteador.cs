using System.Linq;
namespace SorteioNomes;
public class Sorteador
{
    public List<string> Sortear(List<string> nomes)
    {
        if (nomes.Count == 1)
        {
            return nomes;
        }

        var listaSorteada = nomes.ToList();

        while (Enumerable.SequenceEqual(nomes, listaSorteada))
        {
            listaSorteada = this.RandomizarLista(nomes);
        }

        return listaSorteada;
    }

    private List<string> RandomizarLista(List<string> nomes)
    {
        var listaClone = new List<string>(nomes);
        var sorteado = new HashSet<string>();
        var random = new Random();

        while (listaClone.Any())
        {
            var newRandom = random.Next(listaClone.Count);
            sorteado.Add(listaClone[newRandom]);
            listaClone.Remove(sorteado.Last());
        }

        return sorteado.ToList();
    }
}
