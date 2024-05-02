using System;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double notaUm, notaDois, notaTres, notaQuatro, media;

            Console.WriteLine("--Bem vindo ao programa Media--");
            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            //notaUm = double.Parse(Console.ReadLine());
            double notaUm = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            //notaDois = double.Parse(Console.ReadLine());
            double notaDois = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            //notaTres = double.Parse(Console.ReadLine());
            double notaTres = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            //notaQuatro = double.Parse(Console.ReadLine());
            double notaQuatro = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //media = (notaUm + notaDois + notaTres + notaQuatro) / 4;
            Console.WriteLine($"A média das notas é: {(notaUm + notaDois + notaTres + notaQuatro) / 4}");

            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
