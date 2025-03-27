using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_1_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        // for = Para
        // if = Se
        // else = senão
        // else if = senão se
        {
            int contador;

            for (contador = 2; contador <= 100; contador++)
            
            {
                if (contador % 2 == 0) 
                {
                    Console.Write(contador + "\n");
                }
            }

        }
    }
}
