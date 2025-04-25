using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Armazenar_notas_de_votação
{
    internal class Program
    {
        static void Main(string[] args)
        // Implemente uma estrutura para armazenar as notas de 5 jurados para cada um dos
        // 10 participantes de uma competição e calcule a média final de cada participante
        {
            int[] participante = new int[10];
            int[] jurados = new int[5];
            double[] acumuladorDeMedia = new double[10];
            double mediaFinalDeCadaParticipante = 0;
            for(int i = 0; i < 11; i++)
            {
                for (i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Jurado {jurados[i]} Digite a nota para o {i + 1} Participante");
                    participante[i] = int.Parse(Console.ReadLine());

                    mediaFinalDeCadaParticipante += participante[i];

                    
                    
                }
             acumuladorDeMedia[i] = mediaFinalDeCadaParticipante / 5;
            }
            for ( int i = 0; i < 11; i++)
            {
                Console.WriteLine()
            }
        }
    }
}
