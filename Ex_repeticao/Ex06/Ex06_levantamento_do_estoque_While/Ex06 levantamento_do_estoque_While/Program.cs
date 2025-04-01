using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_levantamento_do_estoque_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdVinhoTinto = 0, qtdVinhoBranco = 0;
            string tipoVinho = "", inicialização;

            Console.Write("Deseja iniciar o programa? ");
            inicialização = Console.ReadLine();

            if (inicialização == "sim")
            {
                while (tipoVinho == "")
                { 
                    Console.Write("Digite o tipo do vinho (t - tinto / b - branco) \n Para finalizar o programa Digite (f - finalizar) :");
                    tipoVinho = Console.ReadLine();


                    if (tipoVinho == "t")
                    {
                        qtdVinhoTinto++;
                    }
                    else if (tipoVinho == "b")
                    {
                        qtdVinhoBranco++;
                    }
                    else
                    {
                        Console.WriteLine("Você encerrou a contagem");
                    }
                }
            }
            else
            {
                Console.WriteLine("Você não iniciou o programa");
            }
                Console.WriteLine("Quantidade de vinho branco: " + qtdVinhoBranco +"\n");
                Console.WriteLine("Quantidade de vinho tinto: " + qtdVinhoTinto);
        }
    }
}
