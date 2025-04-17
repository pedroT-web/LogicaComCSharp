using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trabalhando com Arrays");
            string[] clientes = { "maria", "jose", "cleyton", "Keila"};
            int[] idades = { 19, 15, 35 , 16};
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Nome: {clientes[1]}");
            Console.WriteLine($"Idade: {idades[1]}");

            clientes[1] = "JOSÈ";
            Console.WriteLine($"Nome: {clientes[1]}");
            Console.WriteLine($"Idade: {idades[1]}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Total de Clientes: {clientes.Length}");
            Console.ResetColor();



            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nLISTAGEM DE CLIENTES");
            Console.ResetColor();

            Console.WriteLine("ID\tNome\t\tIdade");

            for(int i = 0; i < clientes.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write(i);
                Console.Write("\t");
                Console.Write(clientes[i]);
                Console.Write("\t\t");
                Console.WriteLine(idades[i]);
                Console.ResetColor();
            }
            

        }
    }
}
