using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17__Verificar_um_triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        // Dado os três lados de um triângulo, determine se ele é equilátero, isósceles ou escaleno.
        {
            double lado1, lado2, lado3;

            Console.Write("Digite o primeiro lado do triângulo: ");
            lado1 = double.Parse(Console.ReadLine());


            Console.Write("Digite o segundo lado do triângulo: ");
            lado2 = double.Parse(Console.ReadLine());


            Console.Write("Digite o terceiro lado do triângulo: ");
            lado3 = double.Parse(Console.ReadLine());

            if(lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Esse Triângulo é equilátero");
            }
            else if(lado1 != lado2 && lado2 == lado3 || lado1 != lado3 && lado2 == lado1 || lado1 == lado3 && lado2 != lado3)
            {
                Console.WriteLine("Esse triângulo é isósceles");
            }
            else
            {
                Console.WriteLine("Esse triângulo é escaleno");
            }
        }
    }
}
