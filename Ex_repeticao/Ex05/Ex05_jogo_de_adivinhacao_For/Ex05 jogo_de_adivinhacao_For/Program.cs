using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_jogo_de_adivinhação_For
{
    internal class Program
    {
        static void Main(string[] args)
        // Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10; o jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1.
        // Quando ele acertar, o algoritmo deve informar que ele acertou o número x (escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador 2).
        {
            int num1, num2, contador, tentativa = 1;

            Console.Write("Digite o numero para ser adivinhado: ");
            num1 = int.Parse(Console.ReadLine());

            for(contador = 1; contador <= 10; contador++)
            {
                Console.Write(tentativa + "° Tentativa: ");
                num2 = int.Parse(Console.ReadLine());



              if(num2 == num1)
              {
                    Console.WriteLine("Você acertou o número em: " + tentativa + " tentativas");
                    return;
              }
              else
              {
                    tentativa = contador + 1;
                    Console.WriteLine("\nTente novamente");
              }
        
            }  
        }

    }
}
