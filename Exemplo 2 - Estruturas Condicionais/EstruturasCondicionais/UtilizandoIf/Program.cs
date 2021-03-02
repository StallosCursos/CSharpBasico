using System;

namespace UtilizandoIf
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();

            Console.WriteLine("Olá informe seu nome. ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine($"Muito bem {cliente.Nome} Informe agora sua data de nascimento");
            cliente.DataNacimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Muito bem {cliente.Nome} Informe seu cpf");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine($"Muito bem {cliente.Nome} deseja realizar um pagamento ? S - sim ou N - Não ");
            string realizarPagamento = Console.ReadLine();

            /*
                == - Igualdade
                != - Diferente
                !  - Inversão - Não
            */
            if (realizarPagamento.ToUpper() == "S")
            {
                if (cliente.MaiorIdade)
                {
                    cliente.Pagamento = new Pagamento();

                    Console.WriteLine($"Muito bem {cliente.Nome} informe a forma de pagamento");
                    Console.WriteLine("1 - Debito");
                    Console.WriteLine("2 - Credito");
                    Console.WriteLine("3 - Pix");
                    Console.WriteLine("4 - Dinheiro");
                    Console.WriteLine("5 - Transferencia");

                    int tipoPagamento = Convert.ToInt32(Console.ReadLine());

                    if (tipoPagamento == 1)
                        cliente.Pagamento.TipoPagamento = TipoPagamento.Debito;
                    else if (tipoPagamento == 2)
                        cliente.Pagamento.TipoPagamento = TipoPagamento.Credito;
                    else if (tipoPagamento == 3)
                        cliente.Pagamento.TipoPagamento = TipoPagamento.Pix;
                    else if (tipoPagamento == 4)
                        cliente.Pagamento.TipoPagamento = TipoPagamento.Dinheiro;
                    else if (tipoPagamento == 5)
                        cliente.Pagamento.TipoPagamento = TipoPagamento.Transferencia;
                    else
                        Console.WriteLine("Tipo de pagamento não registrado");

                    cliente.Pagamento.DataPagamento = DateTime.Now;

                    Console.WriteLine("Por favor digite o valor do pagamento ");
                    cliente.Pagamento.Valor = Convert.ToDecimal(Console.ReadLine());

                    /*
                        <= - Menor ou igual
                        >= - Maior ou igual
                        == - Igualdade
                        < - Menor
                        > - Maior
                     */
                    if (cliente.Pagamento.DataPagamento <= cliente.Pagamento.DataVencimento)
                    {
                        RealizarPagamento(cliente.Pagamento);
                    }
                    else
                        Console.WriteLine("Pagamento não pode ser realizado por estar vencido");
                }
                else
                    Console.WriteLine($"Muito bem {cliente.Nome} | Pagamento só pode ser realizado por clientes com mais de 18 anos");
            }
            else
                Console.WriteLine($"Muito bem {cliente.Nome} | CPF: {cliente.Cpf} | estamos fechando o programa");

            Console.ReadKey();
        }

        private static void RealizarPagamento(Pagamento pagamento)
        {
            Console.WriteLine($"Pagamento de {pagamento.Valor} realizado no dia {pagamento.DataPagamento} vencimento {pagamento.DataVencimento}");
        }
    }
}
