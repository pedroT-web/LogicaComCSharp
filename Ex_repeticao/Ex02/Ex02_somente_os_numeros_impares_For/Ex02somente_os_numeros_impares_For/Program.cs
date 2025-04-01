using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_somente_os_números_ímpares_For
{
    internal class Program
    {
        static void Main(string[] args)
        // 	Mostre somente os números ímpares de 1 a 100.
        {
            int contador;

            for(contador = 1; contador <= 100; contador++)
            {
                if (contador % 2 != 0)
                    Console.WriteLine(contador);
            }
        }
    }
}
