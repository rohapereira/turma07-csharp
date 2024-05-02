using System;
using System.Collections.Generic;

//Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
//• "Telefonou para a vítima?"
//• "Esteve no local do crime?"
//• "Mora perto da vítima?"
//• "Devia para a vítima?"
//• "Já trabalhou com a vitima?"
//O programa deve no final, emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino".
//Caso contrário, ele será classificado como "Inocente".

namespace Detetive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Detetive--\n");

            #region "Nossa solução"
            //int respostaPositiva = 0;
            //List<char> respostas = new List<char>(5);

            //Console.Write("Responda as perguntas com S para Sim ou N para Não\n");

            //Console.WriteLine("\nTelefonou para a vítima?");
            //respostas.Add(char.Parse(Console.ReadLine().ToUpper()));

            //Console.WriteLine("Esteve no local do crime?");
            //respostas.Add(char.Parse(Console.ReadLine().ToUpper()));

            //Console.WriteLine("Mora perto da vítima?");
            //respostas.Add(char.Parse(Console.ReadLine().ToUpper()));

            //Console.WriteLine("Devia para a vítima?");
            //respostas.Add(char.Parse(Console.ReadLine().ToUpper()));

            //Console.WriteLine("Já trabalhou com a vitima?");
            //respostas.Add(char.Parse(Console.ReadLine().ToUpper()));

            //for (int i = 0; i < respostas.Count; i++)
            //{
            //    if (respostas[i] == 'S')
            //    {
            //        respostaPositiva++;
            //    }
            //}

            //switch (respostaPositiva)
            //{
            //    case 2:
            //        Console.WriteLine("\nSuspeita");
            //        break;

            //    case 3:
            //    case 4:
            //        Console.WriteLine("\nCumplice");
            //        break;

            //    case 5:
            //        Console.WriteLine("\nAssasino");
            //        break;

            //    default:
            //        Console.WriteLine("\nInocente");
            //        break;
            //}
            #endregion

            #region "Solução do Professor"
            string[] perguntinhas = {
                "Telefonou para a vítima? | SIM = 1 NÃO = 0: ",
                "Esteve no local do crime? | SIM = 1 NÃO = 0: ",
                "Mora perto da vítima? | SIM = 1 NÃO = 0: ",
                "Devia para a vítima? | SIM = 1 NÃO = 0: ",
                "Já trabalhou com a vítima? | SIM = 1 NÃO = 0: "
            };

            string[] veredicto = {
                "Inocente",
                "Inocente",
                "Suspeito",
                "Cumplice",
                "Cumplice",
                "Assasino"
            };

            int contadorRespostas = 0;

            for (int i = 0; i < perguntinhas.Length; i++)
            {
                Console.Write($"{perguntinhas[i]}");
                contadorRespostas += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n{veredicto[contadorRespostas]}");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
