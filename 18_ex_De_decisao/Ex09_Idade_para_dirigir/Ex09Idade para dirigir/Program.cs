using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Idade_para_dirigir
{
    internal class Program
    {
        static void Main(string[] args)
        // Verifique se uma pessoa tem idade suficiente para obter a carteira de motorista,
        // considerando que a idade mínima é 18 anos.
        {
            int idade;

            Console.Write("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Você pode tirar a carteira de motorista");
            }
            else
            {
                Console.WriteLine("Menor de idade, Você não pode tirar a carta de motorista");
            }
            
        }
    }
}
