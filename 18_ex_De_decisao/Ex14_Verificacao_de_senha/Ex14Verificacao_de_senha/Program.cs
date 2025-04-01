using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Verificação_de_senha
{
    internal class Program
    {
        static void Main(string[] args)
        // A senha de um sistema deve ter pelo menos 8 caracteres e conter pelo menos 1 número. Verifique se a senha inserida é válida.
        {
            String senhaUsuario = "aluno123";
            int tamanhoSenha;

                Console.Write("Digite a senha: ");
            senhaUsuario = Console.ReadLine();

            tamanhoSenha = senhaUsuario.Length;

           if (tamanhoSenha < 8 && tamanhoSenha > 8)
           {
                Console.WriteLine("Por favor a senha deve ter 8 caracteres, tente novamente !");
                Console.WriteLine(" Verifica se a senha contém pelo menos uma letra \n Verifica se a senha contém pelo menos um número");
           }
           else if (senhaUsuario.Any(char.IsLetter) && senhaUsuario.Any(char.IsDigit))
           {
                Console.Write("Senha válida");
           }
           else
           {
                Console.Write("Senha invalida");
           }
        }
    }
}

