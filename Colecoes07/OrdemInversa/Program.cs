using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*
usuário vai digitar => 10 90 -89 -2 50
o programa vai exibir => 50 -2 -89 90 10
usar Fila e Pilha
*/

namespace OrdemInversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Programa Ordem Inversa");

            #region "Nossa solução"
            //Queue<int> fila = new Queue<int>();
            //Stack<int> stack = new Stack<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Digite um numero: ");
            //    fila.Enqueue(int.Parse(Console.ReadLine()));

            //}

            //foreach (var numero in fila)
            //{
            //    Console.Write($"{numero} - ");

            //    stack.Push(numero);
            //}

            //Console.WriteLine();

            //foreach (var numero in stack)
            //{
            //    Console.Write($"{numero} - ");
            //}
            #endregion

            #region "Solução do Professor"
            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();

            int resposta = 0;

            do
            {
                Console.Write("Informe um número: ");
                fila.Enqueue(int.Parse(Console.ReadLine()));

                Console.Write("Quer digitar mais um número? 0-Não 1-Sim ");
                resposta = int.Parse(Console.ReadLine());

            } while (resposta == 1);

            Console.WriteLine();
            Console.WriteLine("Os números informados foram: ");

            foreach (var numerosDigitados in fila)
            {
                Console.Write($"{numerosDigitados} - ");
                pilha.Push(numerosDigitados);
            }

            Console.WriteLine();
            Console.WriteLine("\nOs números na forma inversa são: ");

            foreach (var numerosDigitados in pilha)
            {
                Console.Write($"{numerosDigitados} - ");
            }

            Console.WriteLine();
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
