using System;

namespace Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao nosso programa de senha--");
            Console.WriteLine();

            Console.Write("Digite a senha de acesso ao sistema: ");
            int senhaDigitada = int.Parse(Console.ReadLine());

            if (senhaDigitada == 904087)
                Console.WriteLine("Acesso permitido!");
            else
                Console.WriteLine("Você não tem acesso ao sistema!");

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
