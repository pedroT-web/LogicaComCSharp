using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
           
            // Console.WriteLine = Escreva na linha de baixo
        {
            int ano_de_nasc, ano_atual, idade;
            // Declara a variável inteiro

            Console.Write("Digite o ano de seu nascimento: ");
            // Console.Write = Escreva 

            ano_de_nasc = int.Parse(Console.ReadLine());
            //int.Parse(Console.ReadLine()) = converte texto em número

            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_de_nasc;
            Console.Write("Sua idade é " + idade + " anos");



































        }
    }
}
