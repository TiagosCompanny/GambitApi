using GambitApi.Entities;

namespace GambitApi.Services.Interfaces
{
    public interface ICartasService
    {
        List<List<Carta>> GerarCartasRodada(int jogadores);

        List<Carta> GerarBaralho();
    }
}
