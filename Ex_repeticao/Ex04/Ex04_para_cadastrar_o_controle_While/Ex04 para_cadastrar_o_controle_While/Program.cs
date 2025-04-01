using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_para_cadastrar_o_controle_While
{
    internal class Program
    {
        static void Main(string[] args)
        // 	Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionário controla a qualidade, cadastrando o número da peça e o seu estado
        // 	(aprovado ou reprovado).
        // 	Criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.
        {
            int numeroPeca, pecaAprovada = 0, pecaReprovada = 0, contador = 1;
            string estado;

            while(contador <= 4)
            {
                Console.WriteLine("Digite o numero da peca: ");
                numeroPeca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o estado da peça, Digite('A' para aprovado e 'R' para reprovado): ");
                estado = Console.ReadLine();

              if(estado == "A")
              {
                    pecaAprovada += 1;
              }
              else
              {
                    pecaReprovada += 1; 
              }
                    contador++;
            }

            Console.WriteLine("Total de peças aprovadas: " + pecaAprovada + "\nTotal de peças reprovadas: " + pecaReprovada);
        }
    }
}
