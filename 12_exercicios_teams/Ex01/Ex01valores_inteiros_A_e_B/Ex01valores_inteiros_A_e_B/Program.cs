﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02valores_inteiros_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        //Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
        //caso contrário devera multiplicar A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
        //imprimir seu valor na tela.

        {
            int a, b, c;

            Console.Write("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Resultado: " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Resultado: " + c);
            }
        }
    }
}
