using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Maior_número
{
    internal class Program
    {
        static void Main(string[] args)
        // Dado três números, determine qual é o maior entre eles.
        {
            double numero1, numero2, numero3;

            Console.Write("Digite o Primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro número: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 < numero2 && numero3 < numero2)
            {
                Console.Write("O número " + numero2 + " É o maior entre eles");
            }
            else if (numero2 < numero1 && numero3 < numero1)
            {
                Console.Write("O número " + numero1 + " É o maior entre eles");
            }
            else if (numero1 < numero3 && numero2 < numero3)
            {
                Console.Write("O número " + numero3 + " É o maior entre eles");
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }

        }
    }
}
