using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        // Crie  um sistema de menu em cada opção cadastre um item,
        //  Controlando o acesso do teclado
        {
            int opcao = 1;

            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
 ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
 ████╗░████║██╔════╝████╗░██║██║░░░██║
 ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
 ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
 ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
 ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();
                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine("1- Cadastro de CLiente");
                Console.WriteLine("2- Cadastro de Fornecedor");
                Console.WriteLine("3- Cadastro de Funcionários");
                Console.WriteLine("4- Cadastro de Cliente");
                Console.WriteLine("5- Cadastro do Pedido");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Escolha uma das opções: ");

                // A exclamação "!" transforma o conteúdo em falso, O TryParse serve para verificar se o conteúdo da variável é um texto.
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Inválida, Digite novamente");
                }
                switch (opcao)
                {
                    case 1:
                        cadastrarCliete();
                        break;

                    case 2:
                        cadastroDeFornecedor();
                        break;

                    case 3:
                        cadastroDeFuncionario();
                        break;

                    case 4:
                        cadastroDeProduto();
                        break;

                    case 5:
                        cadastroDoPedido();
                        break;

                    case 0:
                        sair();
                        break;

                    default:
                        opcaoInvalida();
                        break;
                }
                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        // Função para organizar o código, Ele busca o código em lugares separados, serve para deixar o seu código principal mais organizado.
        static void cadastrarCliete()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            // $"{variavel}" é um jeito mais prático de contatenar o valor da váriavel
            Console.WriteLine($"Cliente {nome} Cadastrado com sucesso!");
        }

        static void cadastroDeFornecedor()
        {
            Console.WriteLine("Cadastro de Fornecedor");
            Console.WriteLine("Digite o código do fornecedor");
            string codigoFornecedor = Console.ReadLine();
            Console.WriteLine($"Fornecedor {codigoFornecedor} Cadastrado com sucesso");
        }

        static void cadastroDeFuncionario()
        {
            Console.WriteLine("Cadastro de Funcionários");
            Console.WriteLine("Digite o nome do funcionário");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine($"Funcionário {nomeFuncionario} Cadastrado com sucesso!!");
        }

        static void cadastroDeProduto()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.WriteLine("Digite o nome do produto");
            int Produto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto {Produto} Cadastrado com sucesso!!");
        }

        static void cadastroDoPedido()
        {
            Console.WriteLine("\n Cadastro do Pedido");
            Console.WriteLine("Digite o código do Pedido");
            string codigoPedido = Console.ReadLine();
            Console.WriteLine($"Pedido {codigoPedido} Cadastrado com sucesso!!");
        }
        
        static void sair()
        {
            Console.WriteLine("Saindo...");
        }
        static void opcaoInvalida()
        {
            Console.WriteLine("Opção Inválida, digite novamente");
        }




    }
}
