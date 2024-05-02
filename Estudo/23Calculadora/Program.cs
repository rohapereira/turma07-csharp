using System;
using System.Collections.Generic;

/*
Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
1 – Adição 
2 – Subtração 
3 – Multiplicação 
4 – Divisão
*/

namespace _23Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Calculadora--");

            const int ADICAO = 1, SUBTRACAO = 2, MULTIPLICACAO = 3, DIVISAO = 4, SAIR = 5;

            double resultado = 0.00;
            int opcao;
            do
            {
                Console.Write("\nDigite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine($"{ADICAO} - Adição");
                Console.WriteLine($"{SUBTRACAO} - Subtração");
                Console.WriteLine($"{MULTIPLICACAO} - Multiplicação");
                Console.WriteLine($"{DIVISAO} - Divisão");
                Console.WriteLine($"{SAIR} - Sair");

                Console.Write("\nInforme uma opção do menu: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                    continue;
                }

                switch (opcao)
                {
                    case ADICAO:
                        resultado = numero1 + numero2;
                        Console.WriteLine($"{numero1} + {numero2} = {resultado}");
                        break;
                    case SUBTRACAO:
                        resultado = numero1 - numero2;
                        Console.WriteLine($"{numero1} - {numero2} = {resultado}");
                        break;
                    case MULTIPLICACAO:
                        resultado = numero1 * numero2;
                        Console.WriteLine($"{numero1} * {numero2} = {resultado}");
                        break;
                    case DIVISAO:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"{numero1} / {numero2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                            continue;
                        }
                        break;
                    case SAIR:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != SAIR);

            Console.WriteLine("Pressione ENTER para fechar Calculadora");
            Console.ReadLine();
        }
    }
}
