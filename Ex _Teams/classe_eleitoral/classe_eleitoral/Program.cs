using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_eleitoral
{
    internal class Program
    {
        static void Main(string[] args)
        // Crie um algoritmo em PORTUGOL que leia a idade de uma pessoa e informe a sua classe eleitoral:
        // não eleitor (abaixo de 16 anos); eleitor obrigatório (entre a faixa de 18 e menor de 65 anos); eleitor facultativo (de 16 até 18 anos e maior de 65 anos, inclusive).
        
        {
            int idade;

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18 && idade <= 65)
            {
                Console.WriteLine("Eleitor Obrigatório");
            }
            else if( idade < 16 )
            {
                Console.WriteLine("Não eleitor");
            }
            else
            {
                Console.WriteLine("Eleitor facultativo");
            }
        }
    }
}
