using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo = 1518, salarioUsuario, quantidadeDeSalario;

            Console.Write("Digite o seu salário: ");
            salarioUsuario = double.Parse(Console.ReadLine());

            quantidadeDeSalario = (int) (salarioUsuario / salarioMinimo);

            Console.WriteLine("Você recebe " + quantidadeDeSalario + " Salários mínimos");
        }
    }
}
