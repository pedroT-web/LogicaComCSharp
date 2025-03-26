using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01__Soma__Divisão_Subtração_e__multiplicação_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, subtracao, soma, divisao, multiplicacao;

            Console.Write("Digite um primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            subtracao = numero1 - numero2;

            soma = numero1 + numero2;

            divisao = numero1 / numero2;

            multiplicacao = numero1 * numero2;

            Console.WriteLine(" A subtração desses números é: " + subtracao + "\n A Soma desses números é: " + soma +
            "\n A divisão desses números é: " + divisao + "\n A multiplicação desses números é: " + multiplicacao);
        }
    }
}
