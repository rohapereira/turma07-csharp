using System;

//Escreva uma aplicação que leia dois vetores, nome de 10 estudantes e sua respectiva idade. Ordene os vetores e informe qual é o estudante mais velho e o mais novo.

namespace Estudantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Solução da internet"
            //const int QTDDENUMEROS = 5; //10
            //String[] estudantes = new String[QTDDENUMEROS];
            //int[] idade = new int[QTDDENUMEROS];
            //String[] lista = new String[10];

            //Console.WriteLine("--Bem vindo ao programa Estudantes--");

            //Console.WriteLine($"Digite o nome de {QTDDENUMEROS} estudantes e sua respectiva idade (Pressione Enter)");

            //for (int i = 0; i < QTDDENUMEROS; i++)
            //{
            //    Console.WriteLine("Estudante: ");
            //    estudantes[i] = Console.ReadLine();

            //    Console.WriteLine("Idade: ");
            //    idade[i] = int.Parse(Console.ReadLine());

            //    if (idade[i] < QTDDENUMEROS)
            //    {
            //        lista[i] = "0" + idade[i] + " " + estudantes[i];
            //    }
            //    else
            //    {
            //        lista[i] = idade[i] + " " + estudantes[i];
            //    }
            //}

            //Array.Sort(lista);
            //foreach (String i in lista)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine($"O estudante mais novo é o {lista[0]}");
            //Console.WriteLine($"O estudante mais velho é o {lista[4]}");
            #endregion

            #region "Solução 2"

            const int TAMANHO = 5;
            string[] nomes = new string[TAMANHO];
            int[] idades = new int[TAMANHO];

            Console.WriteLine("--Bem vindo ao programa Estudantes--");

            for (int i = 0; i < TAMANHO; i++)
            {
                Console.Write($"Digite o nome do {i+1}º estudante: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a idade do {i+1}º estudante: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            // Ordenando os vetores de acordo com as idades
            OrdenarVetores(nomes, idades);

            Console.WriteLine($"\nO estudante mais novo é: {nomes[0]} com {idades[0]} anos.");
            Console.WriteLine($"O estudante mais velho é: {nomes[TAMANHO - 1]} com {idades[TAMANHO - 1]} anos.");

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }

        // Método para ordenar os vetores de acordo com as idades
        static void OrdenarVetores(string[] nomes, int[] idades)
        {
            for (int i = 0; i < idades.Length - 1; i++)
            {
                for (int j = i + 1; j < idades.Length; j++)
                {
                    if (idades[i] > idades[j])
                    {
                        // Troca de idades
                        int tempIdade = idades[i];
                        idades[i] = idades[j];
                        idades[j] = tempIdade;

                        // Troca de nomes correspondentes
                        string tempNome = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = tempNome;
                    }
                }
            }
        }
        #endregion
    }
}
