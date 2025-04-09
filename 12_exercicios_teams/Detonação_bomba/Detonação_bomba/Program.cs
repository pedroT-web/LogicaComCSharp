using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Detonação_bomba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 3;
           
            // Laço de repetição
            while (contador > 0) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
                        ▄▄▄▄ 
                           █ 
                        ▀▀▀█ 
                        ▄▄▄█ ");
                Thread.Sleep(800);
                Console.Clear();
               

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
                        ▄▄▄▄ 
                           █ 
                        █▀▀▀ 
                        █▄▄▄ ");
                Thread.Sleep(800);
                Console.Clear();

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
                        █ 
                        █ 
                        █ 
                        █ ");
                Thread.Sleep(800);
                Console.Clear();


                Console.ResetColor();

                contador = contador - 1;


                Console.WriteLine(@"
 ____    ___    ___    ___    ___    ___    ___    ___   ___ ___  ___ ___  ___ ___  ___ ___  ___ ___  __  __  __ 
|    \  /   \  /   \  /   \  /   \  /   \  /   \  /   \ |   |   ||   |   ||   |   ||   |   ||   |   ||  ||  ||  |
|  o  )|     ||     ||     ||     ||     ||     ||     || _   _ || _   _ || _   _ || _   _ || _   _ ||  ||  ||  |
|     ||  O  ||  O  ||  O  ||  O  ||  O  ||  O  ||  O  ||  \_/  ||  \_/  ||  \_/  ||  \_/  ||  \_/  ||__||__||__|
|  O  ||     ||     ||     ||     ||     ||     ||     ||   |   ||   |   ||   |   ||   |   ||   |   | __  __  __ 
|     ||     ||     ||     ||     ||     ||     ||     ||   |   ||   |   ||   |   ||   |   ||   |   ||  ||  ||  |
|_____| \___/  \___/  \___/  \___/  \___/  \___/  \___/ |___|___||___|___||___|___||___|___||___|___||__||__||__|
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             


                return;


            }

           
              
                  
        }

    }
}

