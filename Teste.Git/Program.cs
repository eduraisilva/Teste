using System;

namespace Teste.Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            if (nome == "Eduardo") {
                nome = "Eduardo lindo e Maravilhoso";
            }

            Console.WriteLine($"Welcome {nome}! Nice to meet you!!!");
        }
    }
}
