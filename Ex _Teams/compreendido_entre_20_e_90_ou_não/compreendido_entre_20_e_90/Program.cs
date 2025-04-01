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
        // Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não (20 e 90 não estão na faixa de valores).
        {
            double numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 20 && numero < 90)
            {
                Console.WriteLine("O número " + numero + " Está compreendido entre 20 e 90");
            }
            else
            {
                Console.WriteLine("O número " + numero + " Não está compreendido entre 20 e 90");
            }
        }
    }
}
