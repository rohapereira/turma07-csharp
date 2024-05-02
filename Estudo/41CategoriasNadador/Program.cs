using System;

/*
Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias: 
- Infantil A = 5 a 7 anos 
- Infantil B = 8 a 11 anos 
- Juvenil A = 12 a 13 anos 
- Juvenil B = 14 a 17 anos 
- Adultos = Maiores de 18 anos
*/

namespace _41CategoriasNadador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa CategoriasNadador--");

            Console.Write("\nDigite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 4 && idade < 8)
                Console.WriteLine("\nCategoria: Infantil A");
            else if (idade > 7 && idade < 12)
                Console.WriteLine("\nCategoria: Infantil B");
            else if (idade > 11 && idade < 14)
                Console.WriteLine("\nCategoria: Juvenil A");
            else if (idade > 13 && idade < 18)
                Console.WriteLine("\nCategoria: Juvenil B");
            else if (idade >= 18)
                Console.WriteLine("\nCategoria: Adultos");
            else
                Console.WriteLine("\nIdade não permitido para natação!");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
