using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04__múltiplo_de_3_ou_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

              if(numero % 3 == 0 && numero % 5 == 0)
              {
                Console.WriteLine("Esse número é multiplo de 3 e 5");
              }
              else if(numero % 3 == 0 && numero % 5 != 0)
              {
                Console.WriteLine("Número multiplo de 3");
              }
              else if(numero % 5 == 0 && numero % 3 != 0)
              {
                Console.WriteLine("Número multiplo de 5");
              }
            
              else
              {
               Console.WriteLine("Não é multiplo de 3 nem de 5");
              }
        }          
    }
}
