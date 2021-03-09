using System;
using System.Collections.Generic;
using System.Linq;

namespace EstruturasLaco
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilizandoWhile();
            UtilizandoDoWhile();
            UtilizandoFor();
            UtilizandoForeach();
            UtilizandoYield();
        }

        private static void UtilizandoYield()
        {
            Console.WriteLine("Informe um numero de 0 a 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            foreach (var texto in Tabuada(numero))
                Console.WriteLine(texto);
        }

        private static void UtilizandoForeach()
        {
            string[] Produtos = new string[] { "Produto 1", "Produto 2", "Produto 3", "Produto 4", "Produto 5" };

            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto);
            }
        }

        private static void UtilizandoDoWhile()
        {
            int i = 0;
            Random random = new Random();
            do
            {
                i = random.Next(0, 6);
                Console.WriteLine($"Numero: {i}");
            }
            while (i != 5);
        }

        private static void UtilizandoFor()
        {
            IEnumerable<int> alfabeto = Enumerable.Range(65, 26);
            for (int i = 0; i < alfabeto.Count(); i++)
            {
                var chardecimal = alfabeto.ElementAt(i);
                var character = (char)chardecimal;

                Console.WriteLine($"{chardecimal} | {character}");
            }
        }

        private static void UtilizandoWhile()
        {
            int maxIteracoes = 10;
            int i = 1;

            Console.WriteLine("Digite um numero de 0 a 10");

            int n = Convert.ToInt32(Console.ReadLine());

            while (i <= maxIteracoes)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i++;
            }
        }

        public static IEnumerable<string> Tabuada(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return $"{numero} X {i} = {numero * i}";
            }
        }
    }
}
