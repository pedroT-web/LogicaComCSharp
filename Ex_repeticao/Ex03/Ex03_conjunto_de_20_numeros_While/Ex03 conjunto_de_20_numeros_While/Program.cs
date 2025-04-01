using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        // 	Escreva um programa que leia um conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido pelo usuário
        {
               int num, contador, numMaior;


               numMaior = -1;
               contador = 1;


              while(contador <= 20){
              Console.Write("Digite "+ contador + "° número: ");
              num = int.Parse(Console.ReadLine());
              contador++;

                if(num > numMaior){
               numMaior = num;
                }
        
              }
                Console.WriteLine("O número maior é: " + numMaior);
        }  
    }
}

