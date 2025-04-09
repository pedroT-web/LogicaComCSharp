using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace posto_de_gasolina
{
    internal class Program
    {
        static void Main(string[] args)
        //Em um posto de gasolina 10 clientes estão em uma fila para chegar em uma bomba de abastecimento, nessa bomba o
        //pagamento tem que ser feito em dinheiro ou pix, se caso o pagamento for feita em cartão o cliente tem que mudar para a bomba de abastecimento do lado.
        {
            int i = 1;
            String formaDePagamento;

            for (i = 0; i >= 0 && i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
                
                 ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
                 ║    _____ _        ______                        _           _                                       _          ║ 
                 ║   |  _  | |       | ___ \                      (_)         | |                                     | |         ║ 
                 ║   | | | | | __ _  | |_/ / ___ _ __ ___   __   ___ _ __   __| | ___     __ _  ___    _ __   ___  ___| |_ ___    ║ 
                 ║   | | | | |/ _` | | ___ \/ _ \ '_ ` _ \  \ \ / / | '_ \ / _` |/ _ \   / _` |/ _ \  | '_ \ / _ \/ __| __/ _ \   ║ 
                 ║   \ \_/ / | (_| | | |_/ /  __/ | | | | |  \ V /| | | | | (_| | (_) | | (_| | (_) | | |_) | (_) \__ \ || (_) |  ║ 
                 ║    \___/|_|\__,_| \____/ \___|_| |_| |_|   \_/ |_|_| |_|\__,_|\___/   \__,_|\___/  | .__/ \___/|___/\__\___/   ║ 
                 ║                                                                                    | |                         ║ 
                 ║                                                                                    |_|                         ║ 
                 ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝                                                                                                                              
                                                                                                                                             
");

                Console.ResetColor();

                Console.ForegroundColor= ConsoleColor.DarkGray;
                Console.WriteLine("Digite o numero da forma de pagamento por favor ");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Formas de pagamento: \n 1 - Dinheiro \n 2 - Pix \n 3 - Cartão ");
                formaDePagamento = Console.ReadLine();

                Console.ResetColor();
                if(formaDePagamento == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Devido ao método de pagamento ser cartão, Você deverá se locomover até a bomba ao lado,Obrigado");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Ok, começarei a abastecer seu veículo.");
                }
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}
