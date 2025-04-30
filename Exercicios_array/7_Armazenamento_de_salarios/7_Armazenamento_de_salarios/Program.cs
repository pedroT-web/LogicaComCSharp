using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Armazenamento_de_salarios
{
    internal class Program
    {
        static void Main(string[] args)
        // Implemente um sistema que armazene os salários de 50 funcionários e calcule a média salarial da empresa.
        {
            int numFuncionarios = 50;

            double mediaSalarial = 0;

            double contaMedia = 0;

            double[] salarios = new double[numFuncionarios];
          
            for (int  i = 0; i < numFuncionarios; i++)
            {
                salarios[i] = i + 1;
                Console.WriteLine($"Digite o salário do {i + 1}° Funcionário: ");
                salarios[i] = double.Parse(Console.ReadLine());

                mediaSalarial += salarios[i];   
            }
            contaMedia = mediaSalarial / numFuncionarios;

            Console.WriteLine($"A média salárial da empresa é: {contaMedia}");

        }
    }
}
