using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_idade_e_responda_o_ano
{
    internal class Program
    {
        static void Main(string[] args)
        // Programa que pergunte sua idade e responda o ano que você nasceu.
        // O programa deverá permanecer perguntando idades até que o usuário digite como a idade o número 0 (zero)
        {
            int idade, contador, anoDeNasc, anoAtual;

            for (contador = 1; contador > 0; contador++)
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Digite o ano em que Você está: ");
                anoAtual = int.Parse(Console.ReadLine());

                anoDeNasc = anoAtual - idade;

                Console.WriteLine("Você nasceu em " + anoDeNasc);

                if (idade == 0)
                {
                    Console.WriteLine("Fim do programa, idade 0");
                    return;
                }
            }
        }
    }
}
