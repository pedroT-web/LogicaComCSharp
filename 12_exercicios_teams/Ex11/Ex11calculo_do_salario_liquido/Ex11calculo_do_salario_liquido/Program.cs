﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11calculo_do_salario_liquido
{
    internal class Program
    {
        static void Main(string[] args)
            //Faça um algoritmo que efetue o cálculo do salário líquido de um professor.As informações fornecidas serão: valor da hora aula, 
            //número de aulas lecionadas no mês e percentual de desconto do INSS.Imprima na tela o salário líquido final.
            //Até R$ 1.518,00: 7,5%
            //De R$ 1.518,01 até R$ 2.793,88: 9%
            //De R$ 2.793,89 até R$ 4.190,83: 12%
            //De R$ 4.190,84 até R$ 8.157,41: 14%
        {
            double valorDaAula, numeroDeAulas, Inss= 0, valorTotal;

            Console.Write("Digite O valor de cada aula dada: ");
            valorDaAula = double.Parse(Console.ReadLine());

            Console.Write("Digite O numer de aulas dadas: ");
            numeroDeAulas = double.Parse(Console.ReadLine());

            valorTotal = valorDaAula * numeroDeAulas;

            if(valorTotal <= 1518)
            {
                Inss = valorTotal-(valorTotal * 0.075);
                Console.WriteLine("O salário líquido é : " + Inss);
            }
            else if (valorTotal <= 2793.88)
            {
                Inss = valorTotal * 0.09;
                Console.WriteLine("O salário líquido é : " + Inss);
            }
            else if (valorTotal <= 2793.88)
            {
                Inss = valorTotal- (valorTotal * 0.12);
                Console.WriteLine("O salário líquido é : " + Inss);
            }
            else  
            {
                Inss = valorTotal - (valorTotal* 0.14);
                Console.WriteLine("O salário líquido é : " + Inss);
            }
           
        }
    }
}
