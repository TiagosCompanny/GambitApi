namespace GambitApi.Entities;

public class Mao
{
    public int Id { get; set; }
    public List<Rodada> Rodadas { get; set; }

    public int PartidaId { get; set; }  
    public virtual Partida Partida { get; set; }
}