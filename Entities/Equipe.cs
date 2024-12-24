namespace GambitApi.Entities;

public class Equipe
{
    public int Codigo { get; set; }
    public string Nome { get; set; }

    public List<Jogador> Jogadores { get; set; }

    public int Pontos { get; set; }
}