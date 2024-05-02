using System;

//Projeto: Inteiros
//Faça um programa que receba, um a um, uma sequencia de inteiros pelo teclado e, ao final, mostre o maior deles. Para encerrar a entrada de dados, o usuário digitará 0. O programa deve mostrar uma mensagem de erro toda vez que receber um número negativo. Se alguem lhe apresentasse, um a um, os números: 17 - 15 - 23 - 94 - 10 - 112 - 4 - 45 - 97 - 0.Como você faria para, ao final, ser capaz de responder: 112 ?

namespace Inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Inteiros--\n");

            #region "Minha solução"
            //int maior = int.MinValue;

            //Console.WriteLine("Digite uma sequência de inteiros (digite 0 para encerrar):");

            //while (true)
            //{
            //    bool sucesso = int.TryParse(Console.ReadLine(),out int numero);
            //    if (sucesso)
            //    {
            //        if (numero == 0)
            //            break;

            //        if (numero < 0)
            //        {
            //            Console.WriteLine("Erro: Números negativos não são permitidos.");
            //            continue;
            //        }

            //        if (numero > maior)
            //            maior = numero;
            //    }
            //    else
            //        Console.WriteLine("Entrada incorreta!");
            //}

            //Console.WriteLine($"O maior número digitado foi: {maior}");
            #endregion

            #region "Solução do Professor"
            int maiorNumero = 0;

            do {
                Console.WriteLine("Digite um número ou 0 para sair");
                int numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado == 0)
                    break;

                if (numeroDigitado < 0)
                    Console.WriteLine("Informe somente números positivos por favor");

                if (numeroDigitado > maiorNumero)
                    maiorNumero = numeroDigitado;
            } while (true);

            if (maiorNumero > 0)
                Console.WriteLine($"O maior número digitado é {maiorNumero}");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
