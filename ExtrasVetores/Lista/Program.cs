using System;
using System.Collections.Generic;

/*
1. **Listas**:
   -Criar uma lista de números inteiros e exibir todos os elementos.
   - Adicionar um número inteiro ao final da lista.
   - Remover o primeiro elemento da lista.
   - Verificar se um determinado número inteiro está presente na lista.
   - Ordenar a lista em ordem crescente.
*/

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista--");

            List<int> lista = new List<int>();

            // Criar uma lista de números inteiros
            int resposta = 0;

            do
            {
                Console.Write("Digite um número inteiro: ");
                lista.Add(int.Parse(Console.ReadLine()));

                Console.Write("Quer digitar mais um número? 0-Não 1-Sim ");
                resposta = int.Parse(Console.ReadLine());

            } while (resposta == 1);

            // Exibir todos os elementos da lista
            Console.WriteLine("\nLista de números inteiros digitados:");

            foreach (int num in lista)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Adicionar um número inteiro ao final da lista
            Console.WriteLine("Adicionando um número inteiro ao final da lista: ");
            lista.Add(int.Parse(Console.ReadLine()));

            // Exibir todos os elementos da lista após adicionar
            foreach (int num in lista)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Remover o primeiro elemento da lista
            Console.WriteLine("Digite posição 0 para remover o primeiro elemento da lista...");
            if (lista.Count > 0)
            {
                lista.RemoveAt(int.Parse(Console.ReadLine()));
            }

            // Exibir todos os elementos da lista após remover o primeiro elemento
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // Verificar se um determinado número inteiro está presente na lista
            Console.Write("Digite um número para verificar se ele exite na lista: ");
            int numeroProcurado = int.Parse(Console.ReadLine());

            bool presente = lista.Contains(numeroProcurado);
            Console.WriteLine($"O número {numeroProcurado} está presente na lista? (True para SIM ou False para NÃO -> {presente}");

            Console.WriteLine();

            // Ordenar a lista em ordem crescente
            lista.Sort();
            Console.WriteLine("Lista ordenada em ordem crescente:");

            // Exibir todos os elementos da lista após ordenar
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
