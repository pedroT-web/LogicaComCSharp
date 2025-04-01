using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_jogo_de_adivinhação_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJogador1, numJogador2, tentativas = 1;
            

            Console.Write("Jogador 1 escolha um numero de (1 a 10): ");
            numJogador1 = int.Parse(Console.ReadLine());

            while(tentativas <=10)
            {
                Console.Write("\nJogador 2 digite o numero escolhido pela jogador 1 (1 a 10): ");
                numJogador2 = int.Parse(Console.ReadLine());
              
              if(numJogador2 == numJogador1)
              {
                    Console.WriteLine("Voce acertou !\nTentativas: " + tentativas + "\nNumero escolhido pelo jogador1: " + numJogador1);
                    return;
              }
              else
              {
                    Console.WriteLine("Tente Novamente");
                    tentativas++;

              }
            }
        }   
    }
}
