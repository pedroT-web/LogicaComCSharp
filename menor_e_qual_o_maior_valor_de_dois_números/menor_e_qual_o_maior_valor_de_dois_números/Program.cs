using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compreendido_entre_20_e_90_ou_não
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.Write("Digite o Primeiro Número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            if(numero1 > numero2)
            {
                Console.WriteLine("O " + numero1 + " É o maior e o " + numero2 + " É o menor");
            }
            else if (numero1 < numero2) 
            {
                Console.WriteLine("O " + numero2 + " É o maior e o " + numero1 + " É o menor");
            }
            else
            {
                Console.WriteLine("Eles São iguais");
            }
        }
    }
}
