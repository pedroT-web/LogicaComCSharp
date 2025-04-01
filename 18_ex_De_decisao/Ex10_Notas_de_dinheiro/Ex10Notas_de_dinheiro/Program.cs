using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_Notas_de_dinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        // Se um valor de dinheiro for maior ou igual a 100 reais, o caixa deverá 
        //dar 1 nota de 100 reais. Se for maior ou igual a 50 reais, dar uma nota de 50 reais, e assim por diante.
        {
            int valor;

            Console.Write("Digite o valor para ser trocado: ");
            valor = int.Parse(Console.ReadLine());

            if(valor >= 100)
            {
                Console.WriteLine(" 1 nota de R$100 ");
                valor = valor - 100;
            }
            if(valor >= 50)
            {
                Console.WriteLine(" 1  nota de R$50 ");
                valor = valor - 50;
            }
            if(valor >= 20)
            {
                Console.WriteLine(" 1 nota de R$20 ");
                valor = valor - 20;
            }
            if(valor >= 10)
            {
                Console.WriteLine(" 1 nota de R$10 ");
                valor = valor - 10;
            }
            if(valor >= 5)
            {
                Console.WriteLine(" 1 nota de R$5 ");
                valor = valor - 5;
             }
        }
    }
}
