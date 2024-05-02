using System;
using System.Collections.Generic;

//Projeto ArrayValores
//Faça um programa que construa um vetor (array) de 8 posições de números inteiros armazenando em sua primeira posição o valor de 10, na segunda posição o dobro do valor da primeira posição (20), na terceira posição o dobro do valor da segunda posição (40), e assim por diante. Ao final, mostre o valor armazenado na oitava posição e a soma de todos os valores armazenados do vetor.

namespace ArrayValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Solução com Array"

            //const int POSICOESVETOR = 8;

            //int[] numeros = new int[POSICOESVETOR];
            //int soma = numeros[0];

            //Console.WriteLine("--Bem vindo ao programa ArrayValores--\n");

            //numeros[0] = 10;

            //for (int i = 1; i < POSICOESVETOR; i++)
            //{
            //    numeros[i] = numeros[i - 1] * 2;
            //    soma = soma + numeros[i];
            //}

            ////int iDo = 1;
            ////do
            ////{
            ////    numeros[i] = numeros[i - 1] * 2;
            ////    soma = soma + numeros[i];
            ////    iDo++;
            ////} while (iDo > POSICOESVETOR);

            //Console.WriteLine($"A {POSICOESVETOR}º posição do vetor é {numeros[POSICOESVETOR - 1]}");
            //Console.WriteLine($"A soma de todos os valores do vetor é {soma}");

            #endregion

            #region "Solução com List"

            const int POSICOESVETOR = 8;

            List<int> numeros = new List<int>(POSICOESVETOR);
            int soma = 0;

            Console.WriteLine("--Bem vindo ao programa List--\n");

            numeros.Add(10);

            for (int i = 1; i < POSICOESVETOR; i++)
            {
                numeros.Add(numeros[i - 1] * 2);
            }

            foreach (int valor in numeros)
            {
                soma += valor;
            }

            Console.WriteLine($"A {POSICOESVETOR}º posição do vetor é {numeros[POSICOESVETOR - 1]}");
            Console.WriteLine($"A soma de todos os valores do vetor é {soma}");

            #endregion

            #region "Leitura de tras para frente"
            //int y = 1;
            //int z = y;


            //int[] numerosC = new int[POSICOESVETOR];
            //int j = POSICOESVETOR - 1;
            //for (int i = 0; i < POSICOESVETOR; i++)
            //{
            //    numerosC[i] = numeros[j];
            //    j--;
            //}

            //numerosC[0] = 59;

            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
