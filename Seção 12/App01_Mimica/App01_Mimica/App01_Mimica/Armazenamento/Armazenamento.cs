using App01_Mimica.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App01_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static String[][] Palavras =
        {
            //Fáceis
            new string[] { "Olho", "Língua", "Chinelo", "Milho", "Penalti", "Bola", "Ping-pong" },

            //Médias
            new string[] { "Carpinteiro", "Amarelo", "Limão", "Abelha" },

            // Difíceis
            new string[] { "Cisterna", "Lanterna", "Batman vs Superman", "Notebook" },
        };
    }
}
