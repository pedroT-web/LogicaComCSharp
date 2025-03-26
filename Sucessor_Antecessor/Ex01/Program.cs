using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, antecessor, sucessor;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            antecessor = numero - 1;

            sucessor = numero + 1;

            Console.WriteLine(" O numero " + numero + "\n Tem o antecessor " + antecessor + "\n E o sucessor " + sucessor);
        }
    }
}
