using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_Peixe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra;

            Console.Write("Digite o peso pescado: ");
            peso = int.Parse(Console.ReadLine());

            sobra = (peso - 50);

            Console.WriteLine("A sobra é de: " + sobra + "Kg");
        }
    }
}
