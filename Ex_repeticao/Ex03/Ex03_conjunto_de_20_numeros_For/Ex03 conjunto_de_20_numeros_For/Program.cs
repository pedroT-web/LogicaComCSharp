using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_conjunto_de_20_números_For
{
    internal class Program
    {
        static void Main(string[] args)
        // 	Escreva um programa que leia um conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido pelo usuário
        {
            int num, contador = 1, numMaior = -1;           
           
            while (contador <= 4)
            {
                Console.WriteLine("Digite o " + contador + "° número: ");
                num = int.Parse(Console.ReadLine());
                contador++;

                if (num > numMaior)
                {
                    numMaior = num;
                }
            }
            Console.WriteLine("O número maior é: " + numMaior);
        }
    }
}
