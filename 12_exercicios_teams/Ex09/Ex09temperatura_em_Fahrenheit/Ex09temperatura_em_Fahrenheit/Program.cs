using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09temperatura_em_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        //Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius.Imprima na tela as duas temperaturas.
        //Fórmula: C = (5 * (F - 32) / 9)

        {
            double temperaturaFarenheit, temperaturaCelcius;

            Console.Write("Digite a temperatura em farenheit: ");
            temperaturaFarenheit = double.Parse(Console.ReadLine());

            temperaturaCelcius = (5 * (temperaturaFarenheit - 32) / 9);

            Console.WriteLine("A temperatura de " + temperaturaFarenheit + " Farenheit transformado em graus celcius é de: " + temperaturaCelcius + " Graus celcius");
        }
    }
}
