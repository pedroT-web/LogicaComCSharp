using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_De_Semaforo
{
    internal class Program
    {
        static void Main(string[] args)
        // Sistema de um semáforo
        {
           // Console.ForegroundColor = ConsoleColor.Gray;
        
           //Console.WriteLine(@"╔═══════════════════════════════════╗
           //                    ║                                   ║
           //                    ║                                   ║         
           //                    ║                                   ║  
           //                    ║                                   ║  
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║  
           //                    ║                                   ║ 
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ║                                   ║           
           //                    ║                                   ║
           //                    ║                                   ║
           //                    ╚═══════════════════════════════════╝                                   ");

            int num, i1, i2, i3;
            for(int i = 0; i <= 45; i++)
            {
                i1 = i++;
                if (i1 <= 15)
                {
                    for(i1 = 0; i1 <= 15; i1++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(i1);
                        Thread.Sleep(500);
                        Console.Clear();
                        i1 = i1++;
                    }   
                }
                else if(i1 > 15)
                {
                    i2 = i1 - 15;
                    for (i2 = 0; i1 <= 15 && i2 <= 30; i1++)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i1);
                    Thread.Sleep(1000);
                    Console.Clear();
                    i1 = i1++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
            }
    }
}
