using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07valor_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
            //Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
        {
            double A, B;

            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine(" invertendo os valores, o valor de A é: " + B + "\n e o valor de B é: " + A);

        }
    }
}
