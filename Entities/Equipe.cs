namespace GambitApi.Entities;

public class Equipe
{
    public int Id { get; set; }
    public List<Jogador> Jogadores { get; set; }
    public int Pontos { get; set; }
}