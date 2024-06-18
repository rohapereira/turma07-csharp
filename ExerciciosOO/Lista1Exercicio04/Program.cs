using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4) Crie uma classe Ponto3D que representa um ponto em um espaço tridimensional, com coordenadas X, Y e Z. Deve conter os seguintes métodos:

-Mostrar, que mostrará as coordenadas do ponto, por exemplo "(3, 5, -2)";
-MoverPara, que mudará as coordenadas do ponto;
-Distancia(Ponto3D p2), que calculará a distância do ponto até outro ponto p2;

Use propriedades para resolver este exercício. Seu programa deve criar um array de N pontos e solicitar as coordenadas de todos eles ao usuário. Após isso, deve calcular e mostrar a distância entre o primeiro ponto e os demais pontos.
*/

namespace Lista1Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio04--\n");

            List<Ponto3D> vetor = new List<Ponto3D>();

            Console.Write("Quantos pontos serão criados? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Ponto3D p = new Ponto3D();

                Console.Write($"Digite o valor X do ponto {i}: ");
                p.x = int.Parse(Console.ReadLine());

                Console.Write($"Digite o valor Y do ponto {i}: ");
                p.y = int.Parse(Console.ReadLine());

                Console.Write($"Digite o valor Z do ponto {i}: ");
                p.z = int.Parse(Console.ReadLine());

                vetor.Add(p);

                Console.Write("O ponto que você digitou foi: ");
                vetor[i].Mostrar();

                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
                Console.WriteLine($"A distância entre o ponto 0 e o ponto {i} é {vetor[0].Distancia(vetor[i]):0.00}");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
