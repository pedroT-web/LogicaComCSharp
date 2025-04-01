using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achar_o_menor_número
{
    internal class Program
    {
        static void Main(string[] args)
        // Dado três números, determine qual é o menor entre eles.
        {
            double num1, num2, num3;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());

            if(num1 < num2 && num1 < num3)
            {
                Console.WriteLine("O numero " + num1 + " é o menor entre eles");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("O numero " + num2 + " é o menor entre eles");
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("O numero " + num3 + " é o menor entre eles");
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
        }
    }
}
