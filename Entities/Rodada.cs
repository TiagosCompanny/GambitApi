using GambitApi.Entities.Enums;

namespace GambitApi.Entities;

public class Rodada
{
    public int Id { get; set; }
    public int Contador { get; set; }
    public EVencedorRodada VencedorRodada { get; set; }

    public int MaoId { get; set; }
    public virtual Mao Mao { get; set; }

    public List<CartaJogada> CartasJogadas { get; set; }
}