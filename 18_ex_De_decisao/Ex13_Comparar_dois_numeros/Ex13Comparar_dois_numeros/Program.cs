using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Comparar_dois_números
{
    internal class Program
    {
        static void Main(string[] args)
        //Verifique se dois números são iguais ou diferentes.
        {
            double num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Eles são números iguais ! ");
            }
            else
            {
                Console.WriteLine("Eles são números diferentes ! ");
            }
        }
    }
}
