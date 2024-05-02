using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/*
* Projeto: Fila de banco
* Fila de banco sem prioridade (por ordem de chegada)
* Receber os nomes dos clientes.
* Chamar os clientes por ordem de chegada.
*/

namespace FilaDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa FilaDeBanco--\n");

            #region "Minha solução"
            //Queue<string> fila = new Queue<string>();
            //bool sair = false;

            //while (!sair)
            //{
            //    Console.WriteLine("Escolha uma opção:");
            //    Console.WriteLine("1 - Adicionar o nome do cliente");
            //    Console.WriteLine("2 - Chamar o nome do cliente");
            //    Console.WriteLine("3 - Imprimir a fila");
            //    Console.WriteLine("4 - Sair do programa");

            //    string opcao = Console.ReadLine();

            //    switch (opcao)
            //    {
            //        case "1":
            //            Console.WriteLine("\nDigite o nome do cliente:");
            //            string nome = Console.ReadLine();
            //            fila.Enqueue(nome);
            //            Console.WriteLine($"\nCliente {nome} adicionado à fila.\n");
            //            break;
            //        case "2":
            //            if (fila.Count > 0)
            //            {
            //                string clienteChamado = fila.Dequeue();
            //                Console.WriteLine($"\nCliente {clienteChamado} chamado.\n");
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nNão há clientes na fila.\n");
            //            }
            //            break;
            //        case "3":
            //            if (fila.Count > 0)
            //            {
            //                Console.WriteLine("\nClientes na fila:");
            //                foreach (string cliente in fila)
            //                {
            //                    Console.WriteLine(cliente);
            //                }
            //                Console.WriteLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine("\nNão há clientes na fila.\n");
            //            }
            //            break;
            //        case "4":
            //            sair = true;
            //            break;
            //        default:
            //            Console.WriteLine("\nOpção inválida. Tente novamente.\n");
            //            break;
            //    }
            //}
            #endregion

            #region "Solução do Professor"
            const int ADICIONAR = 1, CHAMAR = 2, IMPRIMIR = 3, SAIR = 4, OPCAOINVALIDA = int.MinValue;

            Queue<string> fila = new Queue<string>();
            int opcao;

            do
            {
                Console.WriteLine($"{ADICIONAR} - Adicionar o nome do cliente");
                Console.WriteLine($"{CHAMAR} - Chamar o nome do cliente");
                Console.WriteLine($"{IMPRIMIR} - Imprimir a fila");
                Console.WriteLine($"{SAIR} - Sair do programa");

                Console.Write("\nInforme uma opção do menu: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case ADICIONAR:
                        Console.Write("Informe o nome do cliente: ");
                        fila.Enqueue(Console.ReadLine());
                        break;
                    case CHAMAR:
                        if (fila.Count > 0)
                            Console.WriteLine($"Próximo cliente: {fila.Dequeue()}");
                        else
                            Console.WriteLine("Fila Vazia");
                        break;
                    case IMPRIMIR:
                        if (fila.Count > 0)
                            foreach (var nomeCliente in fila)
                            {
                                Console.WriteLine($"-{nomeCliente}");
                            }
                        else
                            Console.WriteLine("Fila Vazia");
                        break;
                    case SAIR:
                        if (fila.Count == 0)
                            Console.WriteLine("Saindo do programa");
                        else
                        {
                            Console.WriteLine("Programa não pode ser encerrado, pois existem clientes na fila");
                            opcao = OPCAOINVALIDA;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != SAIR);
            #endregion

            Console.WriteLine("Banco Fechou... Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
