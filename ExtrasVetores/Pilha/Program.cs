using System;
using System.Collections;
using System.Collections.Generic;

/*
2. **Pilhas**:
   -Criar uma pilha de caracteres e empilhar alguns caracteres.
   - Desempilhar um caractere e exibi-lo.
   - Verificar se a pilha está vazia.
   - Limpar a pilha.
   - Verificar se a pilha está vazia após a limpeza.
*/

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista--");

            Stack<char> pilha = new Stack<char>();

            // Criar uma pilha de caracteres
            int resposta = 0;

            do
            {
                Console.Write("Digite um caracter: ");
                pilha.Push(char.Parse(Console.ReadLine()));

                Console.Write("Quer digitar mais um caracter? 0-Não 1-Sim ");
                resposta = int.Parse(Console.ReadLine());

            } while (resposta == 1);

            // Exibir todos os elementos da pilha
            Console.WriteLine("\nPilha de caracteres:");

            foreach (char caracter in pilha)
            {
                Console.Write($"{caracter} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Desempilhar um caractere e exibi-lo
            if (pilha.Count > 0)
            {
                char desempilhado = pilha.Pop();
                Console.WriteLine($"Caractere desempilhado: {desempilhado}");
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }

            Console.WriteLine();

            // Exibir todos os elementos da pilha depois de ter desempilhado um caracter
            Console.WriteLine("Pilha de caracteres:");
            foreach (char caracter in pilha)
            {
                Console.Write($"{caracter} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Verificar se a pilha está vazia
            Console.WriteLine($"A pilha está vazia? Se True = Vazia, se False = pilha com itens: {pilha.Count == 0}");

            Console.WriteLine();

            // Limpar a pilha
            Console.WriteLine("Limpando a pilha...");
            while (pilha.Count > 0)
            {
                pilha.Pop();
            }

            Console.WriteLine();

            // Verificar se a pilha está vazia após a limpeza
            Console.WriteLine($"A pilha está vazia após a limpeza? Se True = Vazia, se False = pilha com itens: {pilha.Count == 0}");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
