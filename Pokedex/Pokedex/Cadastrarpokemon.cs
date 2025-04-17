using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Cadastrarpokemon
    {

        // Função de cadastro de pokemons
        public static void pokemons()
        {
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░██████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔════╝
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║╚█████╗░
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║░╚═══██╗
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝╚═════╝░");

            Console.WriteLine("Digite quantos Pokemons Você quer cadastrar: ");
            int qtdPokemons = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdPokemons ; i++)
            {
                string[] nomePokemon = new string[qtdPokemons];
                Console.WriteLine("Digite o nome do pokemon para cadastrar: ");
                nomePokemon[i] = Console.ReadLine();

                string[] tipoPokemon = new string[qtdPokemons];
                Console.WriteLine("Digite o tipo do pokemon: ");
                tipoPokemon[i] = Console.ReadLine();

                double[] tamanhoPokemon = new double[qtdPokemons];
                Console.WriteLine("Digite o tamanho do pokemon: ");
                tamanhoPokemon[i] = double.Parse(Console.ReadLine());

                double[] pesoPokemon = new double[qtdPokemons];
                Console.WriteLine("Digite o peso do pokemon: ");
                pesoPokemon[i] = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"{i+1}° Pokemon cadastrado com sucesso!!");
            }
            Console.WriteLine("Pokemons Cadastrados com sucesso!!");

            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadKey();
            
        }
    }
}
