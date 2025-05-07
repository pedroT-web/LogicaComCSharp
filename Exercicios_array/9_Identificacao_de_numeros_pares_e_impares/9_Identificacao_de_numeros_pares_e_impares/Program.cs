using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Identificacao_de_numeros_pares_e_impares
{
    internal class Program
    {
        static void Main(string[] args)
        //	Crie um programa que armazene 20 números e separe-os em dois arrays: um com números pares e outro com números ímpares.
        {
            int[] pares = new int[20];
            int[] impares = new int[20];
            int[] numeros = new int[20];

            int impar = 0, par = 0;

            int i , j;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° numero: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    pares[par++] = numeros[i];
                   
                }
                else
                {
                    impares[impar++] = numeros[i];
                }
            }

            Console.WriteLine("\n\t numeros Pares");
            for (j = 0; j < par; j++)
            {
                Console.Write(pares[i] + " ");
            }

            Console.WriteLine("\n\t numeros impares");
            for(j = 0; j < impar; j++)
            {
                Console.Write(impares[i] + " ");
            }
        }
    }
}
