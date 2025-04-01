using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Calcular_desconto
{
    internal class Program
    {
        static void Main(string[] args)
        // Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário,
        // o desconto é de 5%. Dado o preço, calcule o valor do desconto.
        {
            double PrecoProduto, desconto;

            Console.Write("Digite o valor do produto para aplicarmos o desconto: ");
            PrecoProduto = double.Parse(Console.ReadLine());

            if(PrecoProduto > 100)
            {
                desconto = PrecoProduto * 0.10;

            }
            else
            {
                desconto = PrecoProduto * 0.05;
            }
            Console.WriteLine(" O valor do desconto é de: R$" + desconto + "\n O valor final do produto é de : R$ " + (PrecoProduto + desconto));
        }
    }
}
