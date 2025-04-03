using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08uma_pessoa_nasceu
{
    internal class Program
    {
        static void Main(string[] args)
        //Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu.Leve em
        //consideração o ano com 365 dias e o mês com 30 dias.
        //(Ex: 5 anos, 2 meses e 15 dias de vida)

        {
            double anoAtual, anodeNasc, AnosVividos, mesesVividos, diasVividos;

            Console.Write("Digite o ano em que você nasceu: ");
            anodeNasc = double.Parse(Console.ReadLine());

            Console.Write("Digite o ano em que você está atualmente: ");
            anoAtual = double.Parse(Console.ReadLine());


            AnosVividos =  anoAtual - anodeNasc;

            mesesVividos = AnosVividos * 12 + (anoAtual - 1);

            diasVividos = ((AnosVividos * 365) + (mesesVividos - 1) * 30);

            Console.WriteLine(AnosVividos + " anos " + mesesVividos % 12 + " meses e " + diasVividos % 30 + " dias de vida.");
        }
    }
}

