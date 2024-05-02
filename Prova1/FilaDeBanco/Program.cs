using System;
using System.Collections.Generic;

namespace FilaDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa FilaDeBanco--\n");

            const int COMUM = 1, PRIORITARIO = 2, CHAMAR = 3, ENCERRAR = 4, IMPRIMIR = 5;

            Queue<int> filaComum = new Queue<int>();
            Queue<int> filaPrioritaria = new Queue<int>();
            int proximaSenhaComum = 1;
            int proximaSenhaPrioritario = 1;

            int opcao;
            do
            {
                Console.WriteLine($"{COMUM} - Gerar senha para atendimento comum");
                Console.WriteLine($"{PRIORITARIO} - Gerar senha para atendimento prioritário");
                Console.WriteLine($"{CHAMAR} - Chamar próxima senha para atendimento");
                Console.WriteLine($"{ENCERRAR} - Encerrar o atendimento");
                Console.WriteLine($"{IMPRIMIR} - Imprimir a fila de atendimento");

                Console.Write("\nInforme uma opção do menu: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                    continue;
                }

                switch (opcao)
                {
                    case COMUM:
                        filaComum.Enqueue(proximaSenhaComum);
                        proximaSenhaComum++;
                        break;
                    case PRIORITARIO:
                        filaPrioritaria.Enqueue(proximaSenhaPrioritario);
                        proximaSenhaPrioritario++;
                        break;
                    case CHAMAR:
                        if (filaPrioritaria.Count > 0)
                            Console.WriteLine($"Próxima senha: P{filaPrioritaria.Dequeue()}");
                        else if (filaComum.Count > 0)
                            Console.WriteLine($"Próxima senha: C{filaComum.Dequeue()}");
                        else
                            Console.WriteLine("Não há mais senhas na fila de atendimento.");
                        break;
                    case ENCERRAR:
                        if (filaPrioritaria.Count == 0 && filaComum.Count == 0)
                            Console.WriteLine("Atendimento encerrado.");
                        else
                            Console.WriteLine("Atendimento não pode ser encerrado. Ainda existem pessoas na fila.");
                        break;
                    case IMPRIMIR:
                        if (filaPrioritaria.Count != 0 || filaComum.Count != 0)
                        {
                            Console.WriteLine("Fila de atendimento:");
                            Console.WriteLine("\nPrioritário:");
                            foreach (var senha in filaPrioritaria)
                            {
                                Console.WriteLine($"P{senha}");
                            }
                            Console.WriteLine("\nComum:");
                            foreach (var senha in filaComum)
                            {
                                Console.WriteLine($"C{senha}");
                            }
                        }
                        else
                            Console.WriteLine("Não há senhas na fila de atendimento.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != ENCERRAR || (filaPrioritaria.Count > 0 || filaComum.Count > 0));

            Console.WriteLine("Banco Fechou... Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
