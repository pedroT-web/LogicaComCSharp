using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Dia_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        // Determine se o dia informado é um dia útil ou final de semana
        {
            int DiaDaSemana;

            Console.Write("Digite o numero do dia da semana desejado: ");
            DiaDaSemana = int.Parse(Console.ReadLine());

            if(DiaDaSemana > 7)
            {
                Console.WriteLine("Dia Inválido");

            }
            else if(DiaDaSemana == 1 || DiaDaSemana == 7)
            // Ou = ||
            {
                Console.WriteLine("Final de Semana");
            }
            else
            {
                Console.WriteLine("Dia Útil");
            }
        }
    }
}
