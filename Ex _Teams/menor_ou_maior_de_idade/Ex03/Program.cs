using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_ou_maior_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Informe a sua Idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 17)
            {
                Console.WriteLine("Você é menor de idade!! ");
            }
            else 
            {
                Console.WriteLine("Você é maior de idade!! ");
            }
           
        }
    }
}
