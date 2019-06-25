using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1("Renan"),
                new Jogador3()
            );
            jogo.IniciarJogo();
        }
    }
}
