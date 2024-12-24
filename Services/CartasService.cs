using GambitApi.Entities;
using GambitApi.Entities.Enums;
using System;

namespace GambitApi.Services.Cards
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

        public Carta DefinirManilha()
        {
            var baralho = GerarBaralho();
            var cartaVirada = baralho[new Random().Next(baralho.Count)];
            return cartaVirada;
        }

        public List<List<Carta>> GerarCartasRodada(int jogadores, Carta cartaVirada)
        {
            if (jogadores % 2 == 0) throw new Exception("A mesa deve ter um numero par de jogadores");

            int quantidadeCartasPorJogador = 3;
            var baralho = GerarBaralho();

            //Remover a carta que foi virada
            baralho.Remove(cartaVirada);

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

        public List<Carta> RetornarCartasMaiores(List<Carta> listaCartas, EValorCarta valorManilha)
        {

            // Verificar se há manilhas
            var cartasManilha = listaCartas.Where(carta => carta.ValorCarta == valorManilha).ToList();

            if (cartasManilha.Any()) // Se houver manilhas, desempatar por naipe
            {
                var maiorNaipe = cartasManilha.Max(carta => carta.Naipe); // Maior naipe entre as manilhas
                return cartasManilha.Where(carta => carta.Naipe == maiorNaipe).ToList();
            }

            // Caso não haja manilhas, retornar todas as cartas com o maior valor
            var maiorValor = listaCartas.Max(carta => carta.ValorCarta);
            return listaCartas.Where(carta => carta.ValorCarta == maiorValor).ToList();

        }

    }
}
