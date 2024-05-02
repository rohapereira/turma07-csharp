using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao nosso programa de senha--");
            Console.WriteLine();

            //Console.Write("Digite a senha de acesso ao sistema: ");
            //string senhaDigitada = Console.ReadLine();

            //if (senhaDigitada == "123456")
            //    Console.WriteLine("Bem vindo, você entrou no sistema: ");

            //Console.WriteLine("Aqui eu vou te provar que só lê uma linha se verdade");

            Console.Write("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());

            if (numero1 >= 10)
                Console.WriteLine("O número digitado é maior ou igual a 10");
            else
                Console.WriteLine("O número digitado é menor que 10");
            
            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
