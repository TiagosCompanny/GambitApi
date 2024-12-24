namespace GambitApi.Entities;

public class CartaJogada
{
    public int Id { get; set; }
    public Carta Carta { get; set; }
    public Jogador Jogador { get; set; }
}