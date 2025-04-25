using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parte da Pokedex, aonde defini 10 pokemons com as seguintes atribuições: nome, tipo, tamanho, peso.
            string[] nomePokemon = { "pikachu   ","bulbasaur ", "Eevee     ", "Lugia     ", "Gimmighoul", "Dugtrio   ", "Charizard ", "Mewtwo    ", "Rayquaza  ", "Giratina  " };
            string[] tipoPokemon = { "Elétrico ", "Planta   ", "Normal   ", "Psíquico ", "Fantasma " , "Terra/Aço", "Fogo     ", "Psíquico ", "Dragão   ", "Fantasma " };
            double[] tamanhoPokemon = { 0.4, 0.7, 0.3, 5.2, 0.3, 0.7, 1.7, 2.0, 6.9, 7.0};
            double[] pesoPokemon = {6.0, 6.9, 6.3, 216.0, 0.1, 68.0, 90.5, 122.0, 650.0, 206.5};

            // Exibindo os pokemons e suas caracteristicas.

            Console.WriteLine("POKEMONS EM SUA POKEDEX");
            Console.WriteLine("ID\tNome\t\t\tTipo\t\t\tTamanho\t\tPeso");
            for (int i = 0; i < nomePokemon.Length; i++)
            {
                Console.Write(i);
                Console.Write("\t");
                Console.Write(nomePokemon[i]);
                Console.Write("\t\t");
                Console.Write(tipoPokemon[i]);
                Console.Write("\t\t");
                Console.Write(tamanhoPokemon[i]);
                Console.Write("\t\t");
                Console.WriteLine(pesoPokemon[i]);
            }

            // Função para cadastro
            string cadastrar;
            Console.WriteLine("\nCadastrar Novos pokemons, Digite 1");
            cadastrar = Console.ReadLine();
            while (cadastrar != "0")
            {
            if (cadastrar == "1")
            {
                     Cadastrarpokemon.pokemons();
                     Console.Clear();
            }
            else if (cadastrar == "0")
            {

            }

                else if (cadastrar != "1")
            {
                    Console.WriteLine("\n Pressione 1 para cadastrar");
                    cadastrar = Console.ReadLine(); 
            }
                Console.WriteLine("Pressione qualquer tecla para voltar");
                Console.ReadKey();

                
            }

            Console.Clear();

            if (cadastrar == "1")
            {
                for (int i = 0; i < nomePokemon.Length; i++)
                {
                    Console.Write(i);
                    Console.Write("\t");
                    Console.Write(nomePokemon[i]);
                    Console.Write("\t\t");
                    Console.Write(tipoPokemon[i]);
                    Console.Write("\t\t");
                    Console.Write(tamanhoPokemon[i]);
                    Console.Write("\t\t");
                    Console.WriteLine(pesoPokemon[i]);
                }
            }
        }
     }
}

