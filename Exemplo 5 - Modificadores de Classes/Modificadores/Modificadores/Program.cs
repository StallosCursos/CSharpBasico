using Biblioteca;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Modificadores
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Comandos comandos = new Comandos(false);
            
            IDictionary<int, string> listaComandos = new Dictionary<int, string>();
            listaComandos.Add(1, "Inserir nome");
            listaComandos.Add(2, "Atualizar nome");
            listaComandos.Add(3, "Remover nome");
            listaComandos.Add(4, "Listar todos os nomes");

            bool executarPrograma = true;

            while(executarPrograma)
            {
                Console.Clear();
                Console.WriteLine("Olá qual comando gostaria de executar ?");

                foreach (var label in listaComandos)
                    Console.WriteLine($"{ label.Key } - { label.Value } ");

                TipoComando Opcao = (TipoComando)Int32.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case TipoComando.Inserir:
                        InserirNome(comandos);
                        break;
                    case TipoComando.Atualizar:
                        AtualizarNome(comandos);
                        break;
                    case TipoComando.Remover:
                        RemoverNome(comandos);
                        break;
                    case TipoComando.ListarTodos:
                        ListarTodosNomes(comandos);
                        break;
                    default:
                        Console.WriteLine("Comando não conhecido");
                        break;
                }

                Console.WriteLine("Deseja executar outro comando S - sim ou N - não");
                if (Console.ReadLine() == "N")
                    executarPrograma = false;
            }
        }

        private static void RemoverNome(Comandos comandos)
        {
            Console.WriteLine("Digite a chave do registro que deseja remover");
            Guid chave = Guid.Parse(Console.ReadLine());
            comandos.Delete(chave);
            Console.WriteLine("Registro removido com sucesso");
        }

        private static void AtualizarNome(Comandos comandos)
        {
            Console.WriteLine("Digite a chave do registro que deseja atualizar");
            Guid chave = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo valor para atualizar");
            string valorAtualizado = Console.ReadLine();

            comandos.Update(chave, valorAtualizado);
        }

        private static void ListarTodosNomes(Comandos comandos)
        {
            var Valores = comandos.Select();
            foreach (var item in Valores)
            {
                Console.WriteLine($"{item.Key.ToString()} | {item.Value}");
            }
        }

        private static void InserirNome(Comandos comandos)
        {
            Console.WriteLine("Digite o nome que deseja salvar ");
            comandos.Insert(Console.ReadLine());
            Console.WriteLine("Nome Salvo com sucesso");
        }
    }
}
