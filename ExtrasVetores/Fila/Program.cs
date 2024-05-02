using System;
using System.Collections.Generic;

/*
3. **Filas**:
   -Criar uma fila de strings e enfileirar algumas strings.
   - Desenfileirar uma string e exibi-la.
   - Verificar se a fila está vazia.
   - Limpar a fila.
   - Verificar se a fila está vazia após a limpeza.
*/

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista--");

            Queue<string> fila = new Queue<string>();

            // Criar uma fila de string
            int resposta = 0;

            do
            {
                Console.Write("Digite um item: ");
                fila.Enqueue(Console.ReadLine());

                Console.Write("Quer digitar mais um item? 0-Não 1-Sim ");
                resposta = int.Parse(Console.ReadLine());

            } while (resposta == 1);

            // Exibir todos os elementos da pilha
            Console.WriteLine("\nFila de itens:");

            foreach (string item in fila)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Desenfileirar um item e exibi-lo
            if (fila.Count > 0)
            {
                string desenfileirado = fila.Dequeue();
                Console.WriteLine($"Caractere desempilhado: {desenfileirado}");
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }

            Console.WriteLine();

            // Exibir todos os elementos da fila depois de ter desenfileirado um item
            Console.WriteLine("Fila de caracteres:");
            foreach (string item in fila)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Verificar se a fila está vazia
            Console.WriteLine($"A fila está vazia? Se True = Vazia, se False = fila com itens: {fila.Count == 0}");

            Console.WriteLine();

            // Limpar a fila
            Console.WriteLine("Limpando a fila...");
            while (fila.Count > 0)
            {
                fila.Clear();
            }

            Console.WriteLine();

            // Verificar se a fila está vazia após a limpeza
            Console.WriteLine($"A fila está vazia após a limpeza? Se True = Vazia, se False = pilha com itens: {fila.Count == 0}");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
