using System;

/*
Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as seguintes opções: 
1 – Adição 
2 – Subtração 
3 – Multiplicação 
4 – Divisão 
Informe a opção: 
A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o programa.
*/

namespace _37CalculadoraVersao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CalculadoraVersao2--\n");

            const int ADICAO = 1, SUBTRACAO = 2, MULTIPLICACAO = 3, DIVISAO = 4;

            double resultado = 0.00, numero1 = 0.00, numero2 = 0.00;
            int opcao;
            char decisao = 'S';

            do
            {
                Console.WriteLine($"{ADICAO} - Adição");
                Console.WriteLine($"{SUBTRACAO} - Subtração");
                Console.WriteLine($"{MULTIPLICACAO} - Multiplicação");
                Console.WriteLine($"{DIVISAO} - Divisão");

                Console.Write("\nInforme uma opção do menu: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case ADICAO:
                        Console.Write("\nDigite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        resultado = numero1 + numero2;
                        Console.WriteLine($"{numero1} + {numero2} = {resultado}");

                        Console.Write("\nDeseja voltar ao menu principal? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;
                    case SUBTRACAO:
                        Console.Write("\nDigite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        resultado = numero1 - numero2;
                        Console.WriteLine($"{numero1} - {numero2} = {resultado}");

                        Console.Write("\nDeseja voltar ao menu principal? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;
                    case MULTIPLICACAO:
                        Console.Write("\nDigite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

                        resultado = numero1 * numero2;
                        Console.WriteLine($"{numero1} * {numero2} = {resultado}");

                        Console.Write("\nDeseja voltar ao menu principal? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;
                    case DIVISAO:
                        Console.Write("\nDigite o primeiro número: ");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        numero2 = double.Parse(Console.ReadLine());

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

                        Console.Write("\nDeseja voltar ao menu principal? Digite 'S' para sim ou 'N' para não: ");
                        decisao = char.Parse(Console.ReadLine().ToUpper());
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, informe um número correspondente às opções do menu.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (decisao != 'N');

            Console.WriteLine("\n--Pressione ENTER para fechar Calculadora--");
            Console.ReadLine();
        }
    }
}
