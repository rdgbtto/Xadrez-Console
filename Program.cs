using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console //PROJETO FINALIZADO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Tela.imprimirPartida(partida);
                        Console.WriteLine("");
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Console.WriteLine("");
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino); 
                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {

                        Console.WriteLine(e.Message + " Precione ENTER para prosseguir...");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);
                Console.WriteLine("ENTER para sair...");
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
