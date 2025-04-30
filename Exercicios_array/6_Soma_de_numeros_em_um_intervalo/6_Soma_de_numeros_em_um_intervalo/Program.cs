using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Soma_de_numeros_em_um_intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        // Crie um programa que armazene os números de 1 a 100 em um array e calcule a soma desses números.

        {
            int soma = 0;
            int[] numeros = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = i + 1;

                Console.WriteLine(i);

                soma += numeros[i];
                
            }

            Console.WriteLine(soma);
        }
    }
}
