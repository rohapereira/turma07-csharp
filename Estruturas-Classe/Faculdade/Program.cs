using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Faculdade--\n");

            Aluno a1 = new Aluno(1);

            Console.Write("Digite o nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.Write("Digite o curso do aluno: ");
            a1.Curso = Console.ReadLine();

            Console.WriteLine();

            a1.ImprimirAluno();

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
