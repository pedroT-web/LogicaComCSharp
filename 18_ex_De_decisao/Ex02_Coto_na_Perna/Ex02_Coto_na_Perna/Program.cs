using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Cotó_na_Perna
{
    internal class Program
    {
        static void Main(string[] args)
        /// Crie um algoritmo para verificar se o Keno possui uma perna mais curta que a outra, 
        //  peça a medida exata de cada perna e verifique a metragem exibindo as seguintes possibilidades de mensagem:  
        //  peça a medida exata de cada perna e verifique a metragem exibindo as seguintes possibilidades de mensagem:  
        //  peça a medida exata de cada perna e verifique a metragem exibindo as seguintes possibilidades de mensagem:  
        //  Cotó na perna esquerda, cotó na perna direita ou normal.

        {
            double PernaE, PernaD;

            Console.Write("Digite a metragem da perna esquerda: ");
            PernaE = double.Parse(Console.ReadLine());

            Console.Write("Digite a medida da perna Direira: ");
            PernaD = double.Parse(Console.ReadLine());

            if (PernaE > PernaD)
            {
                Console.WriteLine("Cotó na perna Direita");
            }
            else if (PernaD > PernaE)
            {
                Console.WriteLine("Cotó na perna Esquerda");
            }
            else
            {
                Console.WriteLine("Pernas normais");
            }
        }
    }
}
