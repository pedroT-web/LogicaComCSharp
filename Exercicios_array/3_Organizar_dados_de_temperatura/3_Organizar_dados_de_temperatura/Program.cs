using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Organizar_dados_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        //Crie um algoritmo que armazene as temperaturas diárias de uma cidade
        //durante uma semana e informe o dia mais quente e o mais frio
        {
            double[] temperaturas = new double[7];
            string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            double max = double.MinValue;
            double min = double.MaxValue;
            int diaMax = 0;
            int diaMin = 0;
              
            for(int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine($"Digite a temperatura de: {dias[i]}");
                temperaturas[i] = double.Parse(Console.ReadLine());

                if (temperaturas[i] > max)
                {
                    max = temperaturas[i];
                    diaMax = i;
                }
                if (temperaturas[i] < min)
                {
                    min = temperaturas[i];
                    diaMin = i;
                }
            }


            Console.WriteLine($"Dia Mais quente foi: {dias[diaMax]} Com {max}°C");
            Console.WriteLine($"Dia Mais Frio foi: {dias[diaMin]} Com {min}°C");
        }
    }
}
