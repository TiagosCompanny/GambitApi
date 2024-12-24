using GambitApi.Entities;
using GambitApi.Entities.Enums;
using GambitApi.Services.Interfaces;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace GambitApi.Services
{
    public class CartasService : ICartasService
    {
        public List<Carta> GerarBaralho()
        {
            var baralho = new List<Carta>();

            foreach (EValorCarta valor in Enum.GetValues(typeof(EValorCarta)))
            {
                foreach (ENaipes naipe in Enum.GetValues(typeof(ENaipes)))
                {
                    baralho.Add(new Carta
                    {
                        ValorCarta = valor,
                        Naipe = naipe
                    });
                }
            }

            return new List<Carta>();
        }

        public List<List<Carta>> GerarCartasRodada(int jogadores)
        {
            if (jogadores % 2 == 0) throw new Exception("A mesa deve ter um numero par de jogadores");

            int quantidadeCartasPorJogador = 3;
            var baralho = GerarBaralho();
            var random = new Random();

            List<List<Carta>> cartasRodada = new List<List<Carta>>();

            for (int i = 0; i < jogadores; i++)
            {
                var listaCartasJogador = new List<Carta>();

                for (int y = 0; y < quantidadeCartasPorJogador; y++)
                {
                    int indice = random.Next(baralho.Count);
                    var carta = baralho[indice];
                    baralho.RemoveAt(indice);

                    listaCartasJogador.Add(carta);
                }

                cartasRodada.Add(listaCartasJogador);
            }

            return cartasRodada;
        }

    }
}
