using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_idade_e_responda_o_ano_While
{
    internal class Program
    {
        static void Main(string[] args)
        // Programa que pergunte sua idade e responda o ano que você nasceu.
        // O programa deverá permanecer perguntando idades até que o usuário digite como a idade o número 0 (zero)
        {
            int idade, anoDeNasc, contador = 1, anoAtual;

            while(contador > 0)
            {
                Console.Write("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o ano atual: ");
                anoAtual = int.Parse(Console.ReadLine());

                anoDeNasc = anoAtual - idade;

                Console.WriteLine("Você Nasceu em: " + anoDeNasc);

              if(idade == 0)
              {
                    Console.WriteLine("Fim do programa, idade 0");
                return;
              }
            }   
        }
    }
}
