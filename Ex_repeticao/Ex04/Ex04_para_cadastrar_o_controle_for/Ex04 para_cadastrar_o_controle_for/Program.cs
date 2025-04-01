using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_para_cadastrar_o_controle_for
{
    internal class Program
    {
        static void Main(string[] args)
        // 	Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionário controla a qualidade,
        // 	cadastrando o número da peça e o seu estado (aprovado ou reprovado). Criar um programa para cadastrar o controle de qualidade
        // 	e imprimir o total de peças aprovadas e reprovadas no final do dia.
        {
            int num, contador, numAprovada = 0, numReprovada = 0, quantidade1, quantidade2;
            string estado;

            for(contador = 1; contador <= 400; contador++)
            {
                Console.Write("Digite o número da peça: ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o estado da peça, Digite('A' para aprovado e 'R' para reprovado): ");
                estado = Console.ReadLine();


            if(estado == "A")
            {
                        numAprovada = numAprovada + 1;
            }
            else if(estado == "R")
            {
                       numReprovada = numReprovada + 1;
            }
            else
            {
                    Console.WriteLine("estado Inválido, digite R ou A");
                    contador = contador - 1; 
            }
        }           Console.WriteLine("Total de peças aprovadas: " + numAprovada + "\n total de peças reprovadas: " + numReprovada);
  
      }
    }
}
