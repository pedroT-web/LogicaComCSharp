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
            // Declarando as variáveis
            int numParticipante = 10;
            int numJurados = 5;

            //Declarando as matrizes, a vírgula entre o [] da variável notas serve para identificar que é um array multidimensional, um array de linhas e colunas.
            double[,] notas = new double[numParticipante, numJurados];
            double[] mediaFinalDeCadaParticipante = new double[numParticipante];

            // Coleta De Notas
            for (int i = 0; i < numParticipante; i++)
                {
             Console.WriteLine($"Digite a nota para o {i + 1}° Participante: ");
                  
                   
                 for (int j = 0; j < numJurados; j++)
                 {
                     Console.WriteLine($"Nota do Participante {j + 1}");
                      while (!double.TryParse(Console.ReadLine(), out notas[i, j]) || notas[i, j] < 0 || notas[i, j] > 10)
                      {
                       Console.WriteLine("\tNota inválida,Digite Novamente");
                       Console.WriteLine($"\tNota do Jurado {j + 1}: ");
                      }
                 }
            }
            for (int i = 0; i < numParticipante; i++)
            {
                double soma = 0;
                for(int j = 0; j < numJurados; j++)
                {
                    soma += notas[i, j];
                }
                mediaFinalDeCadaParticipante[i] = soma / numJurados;
                            
            }

            // Exibição da média Final de Cada Participante

            Console.WriteLine($" Médias Finais");
            for (int i = 0; i < numParticipante; i++)
            {
                Console.WriteLine($"A média final do {i + 1}° participante é: {mediaFinalDeCadaParticipante:F2}");
            }
        }
    }
}
