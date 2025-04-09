using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_De_Semaforo_Facil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O");
            Thread.Sleep(15000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("O");
            Thread.Sleep(15000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O");
            Thread.Sleep(15000);
            Console.Clear();
        }
    }
}
