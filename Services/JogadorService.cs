using GambitApi.Services.Interfaces;
using Microsoft.Extensions.Logging.Console;
using System.Reflection.Metadata.Ecma335;

namespace GambitApi.Services
{
    public class JogadorService : IJogadorService
    {


        public int SolicitarAumentoPontacaoPartida(int quantidadePontosAtual = 1)
        {
            int novaPontuacao = quantidadePontosAtual switch
            {
                1 => 3,
                3 => 6,
                6 => 9,
                9 => 12,
                _ => throw new NotImplementedException(),
            };

            return novaPontuacao;
        }

        public int ResponderSolicitacaoAumentoPontuacaoPartida()
        {




        }


    }
}
