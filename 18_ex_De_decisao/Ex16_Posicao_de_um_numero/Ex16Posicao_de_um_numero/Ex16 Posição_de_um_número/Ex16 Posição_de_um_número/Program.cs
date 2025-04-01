using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Posição_de_um_número
{
    internal class Program
    {
        static void Main(string[] args)
        //Dado um número, verifique se ele está na faixa de 1 a 10, 11 a 20 ou acima de 20.
        {
            double numero1;

                Console.Write("Digite o número desejado: ");
                numero1 = double.Parse(Console.ReadLine());

            if(numero1 >= 1 && numero1 <= 10)
            {
                Console.WriteLine("O número " + numero1 + " Está entre 1 e 10");
            }
            else if(numero1 >= 11 && numero1 <= 20)
            {
                Console.WriteLine("O número " + numero1 + " Está entre 11 e 20");
            }
            else if(numero1 > 20)
            {
                Console.WriteLine("O número " + numero1 + " É maior que 20");
            }
            else
            {
                Console.WriteLine("O número " + numero1 + " É negativo"); 
            }
        }
    }
}
