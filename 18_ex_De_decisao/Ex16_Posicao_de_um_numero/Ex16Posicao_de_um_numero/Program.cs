﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Posição_de_um_número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
██████╗░░█████╗░░██████╗██╗░█████╗░░█████╗░░█████╗░	██████╗░███████╗	██╗░░░██╗███╗░░░███╗
██╔══██╗██╔══██╗██╔════╝██║██╔══██╗██╔══██╗██╔══██╗	██╔══██╗██╔════╝	██║░░░██║████╗░████║
██████╔╝██║░░██║╚█████╗░██║██║░░╚═╝███████║██║░░██║	██║░░██║█████╗░░	██║░░░██║██╔████╔██║
██╔═══╝░██║░░██║░╚═══██╗██║██║░░██╗██╔══██║██║░░██║	██║░░██║██╔══╝░░	██║░░░██║██║╚██╔╝██║
██║░░░░░╚█████╔╝██████╔╝██║╚█████╔╝██║░░██║╚█████╔╝	██████╔╝███████╗	╚██████╔╝██║░╚═╝░██║
╚═╝░░░░░░╚════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░	╚═════╝░╚══════╝	░╚═════╝░╚═╝░░░░░╚═╝
 
███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");
            double numero;
 
            Console.Write("\nDigite um numero: ");
            numero = double.Parse(Console.ReadLine());
 
            if (numero > 0)
            {
                Console.WriteLine("Numero positivo");
            }
 
            else if (numero < 0)
            {
                Console.WriteLine("Numero negativo");
            }
 
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
