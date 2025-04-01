using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Classificação_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        // Dada uma temperatura, determine se o clima está "Frio", "Ameno" ou "Quente". A classificação segue a seguinte tabela:	
        // Menor que 15°C: Frio
    	// Entre 15°C e 25°C: Ameno
    	// Maior que 25°C: Quente


        {
            int temperatura;

            Console.Write("Digite a temperatura do ambiente: ");
            temperatura = int.Parse(Console.ReadLine());

            if(temperatura < 15)
            {
                Console.WriteLine(" O clima está Frio");
            }
            else if(temperatura >= 15 && temperatura <= 25)
            {
                Console.WriteLine("O clima está Ameno");
            }
            else
            {
                Console.WriteLine("O clima está Quente");
            }
        }
    }
}
