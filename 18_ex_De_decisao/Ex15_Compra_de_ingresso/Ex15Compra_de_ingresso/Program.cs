using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Compra_de_ingresso
{
    internal class Program
    {
        static void Main(string[] args)
        //Verifique se o valor total de uma compra de ingressos é superior a 200 reais.
        //Se for, o cliente tem direito a um desconto de 10%. Calcule o valor total com ou sem o desconto.
        {
            double valorDaCompra, desconto;

            Console.Write("Digite o valor total da compra de ingressos: ");
            valorDaCompra = double.Parse(Console.ReadLine());

            if(valorDaCompra > 200)
            {
                desconto = (valorDaCompra * 0.10) + valorDaCompra;

                Console.WriteLine(" Você recebeu um desconto de 10%, Valor Total da compra: R$" + desconto);
            }
            else
            {
                Console.WriteLine(" A compra não atingiu a quantia necessária para o desconto, valor Total da compra: R$" + valorDaCompra);
            }
        }
    }
}
