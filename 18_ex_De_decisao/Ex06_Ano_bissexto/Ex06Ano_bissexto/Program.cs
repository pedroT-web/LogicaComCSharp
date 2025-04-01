using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Ano_bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        // Determine se um ano é bissexto.
        // Um ano é bissexto se for divisível por 4, mas não por 100, a não ser que seja divisível por 400.
        {
            int ano;

            Console.Write("Digite o ano atual: ");
            ano = int.Parse(Console.ReadLine());

            if(ano % 4 == 0 && ano% 100 != 0)
            {
                Console.WriteLine("Ano Bissexto");
            }
            else
            {
                Console.WriteLine("Ano não Bissexto");
            }
        }
    }
}
