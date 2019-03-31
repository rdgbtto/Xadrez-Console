﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colcarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colcarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colcarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
            
            Console.ReadKey();
        }
    }
}
