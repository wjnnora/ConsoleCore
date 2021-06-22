using System;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            IJogador jogador1 = new Jogador("Wellington Nora");
            IJogador jogador2 = new Jogador("Giovane Nora");

            Console.WriteLine(jogador1.Chutar());
            Console.WriteLine(jogador2.Chutar());
        }
    }
}
