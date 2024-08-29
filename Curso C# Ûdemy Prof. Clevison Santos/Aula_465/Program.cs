using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula_465
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir ao usuário para digitar seu nome
            Console.WriteLine("Digite seu nome:");

            //Cria uma variável chamada nome que vai ler o que o usuário digitar
            String nome = Console.ReadLine();

            //Exibe a mensagem de saudação
            Console.WriteLine("\nOlá, " + nome + "!");
            
            //Pedir para o usuário digitar a idade.
            Console.WriteLine("\nDigite sua idade: ");

            //Lê a entrada deo usuário e converte para um número inteiro
            int idade = Convert.ToInt32(Console.ReadLine());

            //Exibe a mensagem de saudação
            Console.WriteLine("\nOlá, " + nome + "! Você tem " + idade + " anos.");
            
            //Augarda o usuário pressionar uma tecla para sair
            Console.ReadKey();
        }
    }
}
