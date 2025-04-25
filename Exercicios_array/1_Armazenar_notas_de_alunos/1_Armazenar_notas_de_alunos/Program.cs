using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Armazenar_notas_de_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        //Crie um programa que armazene as notas de 30 alunos e calcule a média da turma.
        {
            double media = 0;
            double[] notaDosAlunos = new double[10];
            double somaNotas = 0;

            for (int i = 0; i < notaDosAlunos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"digite a nota do {i + 1}° aluno : ");
                double notas = double.Parse(Console.ReadLine());
                notaDosAlunos[i] = notas;
                Console.ResetColor();
                
                while (notas > 10 || notas < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nota Inválina, Digite a nota novamente");
                    Console.ResetColor();
                    notas = double.Parse(Console.ReadLine());
                }
                somaNotas += notaDosAlunos[i];
                media = somaNotas / 10;

                Console.Clear();
            }

            if (media >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"A média final da turma é: {media.ToString("F1")}");
                    Console.ResetColor();
            }
            else
            {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine($"A média final da turma é: {media.ToString("F1")}");
                    Console.ResetColor();
            }
            
        }
    }
}
