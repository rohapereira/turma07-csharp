using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
5) Crie um programa orientado a objetos com as seguintes características:

-Crie uma classe AlbumDeFotos com uma propriedade numeroTotalDePaginas;
-Crie outra propriedade somente leitura chamada numeroTotalDeFotos baseada na propriedade numetoTotalDePaginas, sabendo que cada página pode conter no máximo 2 fotos;
-Crie uma terceira propriedade chamada numeroDeFotos, cujo método set deve mostrar uma mensagem de erro caso o usuário ultrapasse o numeroTotalDeFotos;
-Crie um programa para testar a classe AlbumDeFotos. Simule um exemplo em que atribuir um valor à propriedade numeroDeFotos mostra uma mensagem de erro, e outro exemplo em que não mostra.
*/

namespace Lista1Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio05--\n");

            AlbumDeFotos a;

            a = new AlbumDeFotos(80);

            Console.WriteLine("O exemplo abaixo não causa erro:");
            a.numeroDeFotos = 100;
            Console.WriteLine($"Número atual de fotos = {a.numeroDeFotos}");

            Console.WriteLine();

            Console.WriteLine("O exemplo abaixo causa erro:");
            a.numeroDeFotos = 200;
            Console.WriteLine($"Número atual de fotos = {a.numeroDeFotos}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
