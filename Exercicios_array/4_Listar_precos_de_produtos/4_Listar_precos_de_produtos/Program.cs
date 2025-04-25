using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Listar_precos_de_produtos
{
    internal class Program
    {
        static void Main(string[] args)
        // Desenvolva um sistema que armazene os preços de 10 produtos e aplique um desconto de 10% em todos os preços.
        {
            double[] precos = new double[10];

            for(int i = 0; i < precos.Length; i++)
            {
                Console.Write($"Digite o Preço do {i + 1}° Produto: R$");
                precos[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("\nPreços com 10% de desconto: ");

            for (int i = 0; i < precos.Length; i++)
            {
                double comDesconto = precos[i] * 0.10;
                Console.WriteLine($"Produto {i + 1}: R$ {comDesconto:0.00}");
            }
        }
    }
}
