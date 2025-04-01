using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Positivo_negativo_0
{
    internal class Program
    {
        static void Main(string[] args)
        // Dado um número, determine se ele é positivo, negativo ou zero.
        {
            double numero;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine("O " + numero + " È positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O " + numero + " È negativo");
            }
            else
            {
                Console.WriteLine("O numero é " + numero);
            }
        }
    }
}
