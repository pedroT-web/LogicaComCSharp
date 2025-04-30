using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Historico_de_pedidos_de_clientes
{
    internal class Program
    {
        static void Main(string[] args)
        // Desenvolva um programa que armazene o histórico de compras de 100 clientes e mostre o total gasto por cada cliente.
        {

            int clientes = 5;

            double[,] historicoDeCompras = new double[clientes, 5];
            

            for (int i = 0; i < clientes; i++)
            {
                double total = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\tCompras do {i + 1}° Cliente");
                Console.ResetColor();


                for (int j = 0; j < clientes; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Digite o valor da {j + 1}° Compra");
                    Console.ResetColor();
                    historicoDeCompras[i, j] = double.Parse(Console.ReadLine());
                    

                    total += historicoDeCompras[i, j];
                }

                Console.WriteLine($"O valor da compra total do {i + 1}° Cliente é: {total}");
            }
            
        }
    }
}
