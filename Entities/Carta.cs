using GambitApi.Entities.Enums;

namespace GambitApi.Entities
{
    public class Carta
    {
        public ENaipes Naipe { get; set; }
        public EValorCarta ValorCarta { get; set; }

        public int RodadaId { get; set; }
        public virtual Rodada Rodada { get; set; }
    }
}
