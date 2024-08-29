using System; //Importa a namespace System, que fornece as funcionalidade básicas do programa
using System.Collections.Generic;//Classes grnericas que suportam as coleções
using System.Linq;//Fornece as classes e interfaces para concuslta LINQ(Language-Integrate Query)
using System.Text;//Trabalhar com textos e carateres
using System.Threading.Tasks;//Trabalhar com tarefas

//namespace - Organiza / Define o escopo do programa
namespace Aula_464//Define o namespace do programa
{
    internal class Program// Define a classe principal
    {
        static void Main(string[] args)//Define o ponto de entrada
        {
            //Exibe a mensagem no console
            Console.WriteLine("Olá, mundo!");

            Console.WriteLine("\nEstou aprendendo \nC#");

            //Aguarda o usuário encerrar o programa
            Console.ReadLine();
        }
    }
}
