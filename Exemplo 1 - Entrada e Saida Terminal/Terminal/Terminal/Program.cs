using System;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de escrita no terminal
            Console.WriteLine("Digite seu nome!");

            // Recebe a linha digitada no terminal
            string Nome = Console.ReadLine();

            // Imprime a variavel recebida
            Console.WriteLine("Olá: " + Nome);
        }
    }
}
