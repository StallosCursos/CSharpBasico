using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilizandoArray();
            Divisor();

            UtilizandoListas();
            Divisor();
            
            UtilizandoDicionarios();
            Divisor();

            UtilizandoEnumeradores();
            Divisor();
 
            UtilizandoListaAutoOrdenada();
            Divisor();

            UtilizandoFilasPilhas();
            Divisor();
        }

        private static void Divisor()
        {
            string[] divisor = Enumerable.Range(0, 30).Select(t => "-").ToArray();
            Console.WriteLine(string.Join("", divisor));
        }

        private static void UtilizandoFilasPilhas()
        {
            Console.WriteLine("Exemplo 7 - Utilizando Pilhas e Filas");

            Queue<int> Fila = new Queue<int>();
            Fila.Enqueue(1);
            Fila.Enqueue(2);
            Fila.Enqueue(3);
            Fila.Enqueue(4);

            Console.WriteLine(Fila.Dequeue());
            Console.WriteLine(Fila.Dequeue());
            Console.WriteLine(Fila.Dequeue());
            Console.WriteLine(Fila.Dequeue());

            Stack<int> Pilha = new Stack<int>();
            Pilha.Push(1);
            Pilha.Push(2);
            Pilha.Push(3);
            Pilha.Push(4);

            Console.WriteLine(Pilha.Pop());
            Console.WriteLine(Pilha.Pop());
            Console.WriteLine(Pilha.Pop());
            Console.WriteLine(Pilha.Pop());
        }

        private static void UtilizandoListaAutoOrdenada()
        {
            Console.WriteLine("Exemplo 6 - Utilizando listas auto ordenadas");

            SortedList<string, string> ListaOrdenada = new SortedList<string, string>();

            ListaOrdenada.Add("A", "Letra a");
            ListaOrdenada.Add("C", "Letra c");
            ListaOrdenada.Add("B", "Letra b");

            ShowAlphabeto(ListaOrdenada.Keys.ToList());
        }

        private static void UtilizandoEnumeradores()
        {
            Console.WriteLine("Exemplo 4 - Utilizando Enumeradores");

            IEnumerable<int> Alphabeto = Enumerable.Range(65, 26);
            foreach (var i in Alphabeto)
            {
                string representacaoDecimal = Convert.ToString(i);
                string representacaoChar = Convert.ToString((char)i);
                string representacaoHexa = i.ToString("X");

                Console.WriteLine($"{representacaoDecimal} | {representacaoChar} | {representacaoHexa}");
            }
        }

        private static void UtilizandoDicionarios()
        {
            Console.WriteLine("Exemplo 3 - Utilizando Dicionarios");

            Dictionary<string, string> Mensagens = new Dictionary<string, string>();

            Mensagens.Add("MSG0001", "Teste de Mensagens 1");
            Mensagens.Add("MSG0002", "Teste de Mensagens 2");
            Mensagens.Add("MSG0003", "Teste de Mensagens 3");
            Mensagens.Add("MSG0004", "Teste de Mensagens 4");
            Mensagens.Add("MSG0005", "Teste de Mensagens 5");

            Console.WriteLine($"Mensagen: {Mensagens["MSG0001"]}");
            Console.WriteLine($"Mensagen: {Mensagens["MSG0002"]}");
            Console.WriteLine($"Mensagen: {Mensagens["MSG0003"]}");
            Console.WriteLine($"Mensagen: {Mensagens["MSG0004"]}");
            Console.WriteLine($"Mensagen: {Mensagens["MSG0005"]}");

            if (Mensagens.ContainsKey("MSG0002"))
                Mensagens.Remove("MSG0002");

            //Console.WriteLine($"Mensagen: {Mensagens["MSG0002"]}");

            string stringOut = "";
            Mensagens.TryGetValue("MSG0002", out stringOut);
            Console.WriteLine(stringOut);

            Mensagens.TryGetValue("MSG0003", out stringOut);
            Console.WriteLine(stringOut);
        }

        private static void UtilizandoListas()
        {
            Console.WriteLine("Exemplo 2 - Utilizando Listas");

            List<string> alphabeto = new List<string>();

            alphabeto.Add("A");
            alphabeto.Add("B");
            alphabeto.Add("C");
            alphabeto.Add("D");
            alphabeto.Add("E");
            alphabeto.Add("F");
            alphabeto.Add("G");
            alphabeto.Add("H");
            alphabeto.Add("I");
            alphabeto.Add("J");
            alphabeto.Add("K");
            alphabeto.Add("L");
            alphabeto.Add("M");
            alphabeto.Add("N");
            alphabeto.Add("O");
            alphabeto.Add("P");
            alphabeto.Add("Q");
            alphabeto.Add("R");
            alphabeto.Add("S");
            alphabeto.Add("T");
            alphabeto.Add("U");
            alphabeto.Add("V");
            alphabeto.Add("X");
            alphabeto.Add("W");
            alphabeto.Add("Y");
            alphabeto.Add("Z");

            Console.WriteLine($"A lista tem { alphabeto.Count } elementos");

            alphabeto.Reverse();
            ShowAlphabeto(alphabeto);

            alphabeto.Sort();
            ShowAlphabeto(alphabeto);

            alphabeto.Remove("A");
            ShowAlphabeto(alphabeto);

            alphabeto.AddRange(new[] { "a", "b", "c", "d" });
            ShowAlphabeto(alphabeto);

            alphabeto.Insert(0, "A");
            ShowAlphabeto(alphabeto);
        }

        private static void ShowAlphabeto(List<string> alphabeto)
        {
            Console.WriteLine(string.Join("-", alphabeto.ToArray()));
        }

        private static void UtilizandoArray()
        {
            Console.WriteLine("Exemplo 1 - Utilizando Arrays");

            string[] textos = new string[3];
            textos[0] = "Olá ";
            textos[1] = "Sr(a). ";

            Console.WriteLine("Digite o nome por favor");
            textos[2] = Console.ReadLine();

            Console.WriteLine(string.Concat(textos));
        }
    }
}
