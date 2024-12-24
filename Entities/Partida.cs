namespace GambitApi.Entities;

public class Partida
{
    public int Id { get; set; }
    public Equipe Eles { get; set; }
    public Equipe Nos { get; set; }
    public List<Mao> Maos { get; set; }
}