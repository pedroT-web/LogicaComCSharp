using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Maioridade_penal
{
    internal class Program
    {
        static void Main(string[] args)
        // Determine se uma pessoa atingiu a maioridade penal, que ocorre aos 18 anos no Brasil.
        {
            int idade;

            Console.Write("Digite a sua idade atual: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Você atingiu a maioridade penal: ");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
