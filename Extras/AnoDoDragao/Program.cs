using System;

//Escreva um programa que determine se um ano é um "ano do dragão" no calendário chinês.

namespace AnoDoDragao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Mostra se o ano é do dragão"
            //Console.WriteLine("--Bem vindo ao programa AnoDoDragao--\n");

            //Console.Write("Digite um ano: ");
            //int ano = int.Parse(Console.ReadLine());

            //if (ano % 12 == 8)
            //    Console.WriteLine($"O ano de {ano} é Ano do Dragão!");
            //else
            //    Console.WriteLine($"O ano de {ano} não é Ano do Dragão");

            //Console.WriteLine("\n--Digite ENTER para sair--\n");
            //Console.ReadLine();
            #endregion

            #region "Mostra zodíaco Chinês para o ano digitado"
            Console.WriteLine("--Bem vindo ao programa Zodíaco Chinês --\n");

            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            int resto = ano % 12;

            switch (resto)
            {
                case 0:
                    Console.WriteLine($"O ano de {ano} é Ano do Macaco!\n");
                    break;
                case 1:
                    Console.WriteLine($"O ano de {ano} é Ano do Galo!\n");
                    break;
                case 2:
                    Console.WriteLine($"O ano de {ano} é Ano do Cão!\n");
                    break;
                case 3:
                    Console.WriteLine($"O ano de {ano} é Ano do Porco!\n");
                    break;
                case 4:
                    Console.WriteLine($"O ano de {ano} é Ano do Rato!\n");
                    break;
                case 5:
                    Console.WriteLine($"O ano de {ano} é Ano do Boi!\n");
                    break;
                case 6:
                    Console.WriteLine($"O ano de {ano} é Ano do Tigre!\n");
                    break;
                case 7:
                    Console.WriteLine($"O ano de {ano} é Ano do Coelho!\n");
                    break;
                case 8:
                    Console.WriteLine($"O ano de {ano} é Ano do Dragão!\n");
                    break;
                case 9:
                    Console.WriteLine($"O ano de {ano} é Ano do Serpente!\n");
                    break;
                case 10:
                    Console.WriteLine($"O ano de {ano} é Ano do Cavalo!\n");
                    break;
                case 11:
                    Console.WriteLine($"O ano de {ano} é Ano do Carneiro!\n");
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
            #endregion
        }
    }
}
