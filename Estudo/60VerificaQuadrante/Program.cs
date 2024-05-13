using System;

/*
Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y. 
 Quadrantes 
              x | 
                | 
             2º | 1º
                |               
y ------------------------------ 
                | 
                | 
             3º | 4º
                | 

*/

namespace _60VerificaQuadrante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa VerificaQuadrante--");

            Console.Write("\nDigite o valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine());

            int quadrante = VerificaQuadrante(x, y);

            if (quadrante == 1 || quadrante == 2 || quadrante ==3 || quadrante == 4)
                Console.WriteLine($"\nO ponto ({x}, {y}) está no quadrante {quadrante}");
            else
                Console.WriteLine($"\nUm dos valores de x, y digitados ({x}, {y}) está no ponto de origem 0.");

            Console.WriteLine("\n--Digite ENTER para sair--");
            Console.ReadLine();
        }

        static int VerificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                // Se x ou y for zero, retornar 0 indicando ponto na origem.
                return 0;
            }
        }
    }
}
