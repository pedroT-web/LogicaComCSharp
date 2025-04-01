using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Média_de_notas
{
    internal class Program
    {
        static void Main(string[] args)
        // Calcule a média de quatro notas
        // e determine se o aluno foi aprovado ou reprovado. Considera-se aprovado quem tem média maior ou igual a 7.
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a nota do primeiro bimestre: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do segundo bimestre: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do terceiro bimestre: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do quarto bimestre: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(media > 7 && media <= 10)
            {
                Console.WriteLine(" O aluno foi aprovado");
            }
            else 
            {
                Console.WriteLine(" O aluno foi reprovado");
            }
        }
    }
}
