using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somente_os_números_pares_de_1_a_100_While
{
    internal class Program
    {
        static void Main(string[] args)
            // while = enquanto
        {
            int contador = 0;

            while(contador <= 100)
            {
                if(contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
        }
    }
}
