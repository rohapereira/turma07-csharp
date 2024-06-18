using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
8) Deseja-se atualizar as contas correntes dos clientes de uma agência bancária. É dado o cadastro de N clientes, contendo para cada cliente o número de sua conta e o seu saldo; o cadastro está ordenado pelo número da conta. Em seguida, é dado o número de operações efetuadas no dia e, para cada operação, o número da conta, uma letra C ou D indicando se a operação é de crédito ou débito e o valor da operação. Emitir o cadastro de clientes atualizado.
*/

namespace Lista1Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio08--\n");

            List<Cliente> clientes = new List<Cliente>();
            int opcao;

            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Realizar Movimentação em Conta");
                Console.WriteLine("3 - Mostrar Movimentação da Conta");
                Console.WriteLine("4 - Mostrar o Saldo em Conta");
                Console.WriteLine("5 - Sair");
                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarConta(clientes);
                        break;

                    case 2:
                        RealizarMovimentacao(clientes);
                        break;

                    case 3:
                        MostrarMovimentacao(clientes);
                        break;

                    case 4:
                        MostrarSaldo(clientes);
                        break;

                    case 5:
                        Console.WriteLine("\nSaindo...");
                        Console.WriteLine("\n--Digite ENTER para sair--");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }

                //Console.Clear();

            } while (opcao != 5);
        }

        // Função para cadastrar contas
        static void CadastrarConta(List<Cliente> clientes)
        {
            Console.Write("\nDigite o número da conta do cliente: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o saldo do cliente: ");
            decimal saldo = decimal.Parse(Console.ReadLine());

            clientes.Add(new Cliente(numeroConta, saldo));
            Console.WriteLine("Conta cadastrada com sucesso!");

            Console.WriteLine();
        }

        // Função para realizar movimentações em conta
        static void RealizarMovimentacao(List<Cliente> clientes)
        {
            Console.Write("\nDigite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.NumeroConta == numeroConta);
            if (cliente != null)
            {
                Console.Write("Digite o tipo de operação (C para crédito, D para débito): ");
                char tipoOperacao = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Digite o valor da operação: ");
                decimal valorOperacao = decimal.Parse(Console.ReadLine());

                cliente.AtualizarSaldo(tipoOperacao, valorOperacao);
                Console.WriteLine("Movimentação realizada com sucesso!");

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"\nCliente com conta {numeroConta} não encontrado.");
            }
        }

        // Função para mostrar as movimentações em conta
        static void MostrarMovimentacao(List<Cliente> clientes)
        {
            Console.Write("\nDigite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.NumeroConta == numeroConta);
            if (cliente != null)
            {
                cliente.MostrarMovimentacoes();
            }
            else
            {
                Console.WriteLine($"\nCliente com conta {numeroConta} não encontrado.");
            }
        }

        // Função para mostrar saldo da conta atualizado
        static void MostrarSaldo(List<Cliente> clientes)
        {
            Console.Write("\nDigite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.NumeroConta == numeroConta);
            if (cliente != null)
            {
                Console.WriteLine(cliente);
            }
            else
            {
                Console.WriteLine($"\nCliente com conta {numeroConta} não encontrado.");
            }
        }
    }
}
