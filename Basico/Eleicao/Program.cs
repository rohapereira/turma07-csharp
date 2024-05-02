using System;

//        Projeto: Eleicao
//Em uma eleição presidencial, existem quatro candidatos.Os votos são informados
//através de codigos.
//-1,2,3,4 votos para os respectivos candidatos
//-5 voto nulo
//-6 voto em branco.
//Assim, escreva um programa para receber um único voto e imprima

//    -Se o usuário votou em um candidato: "Voto contabilizado com sucesso."
//    - Se o usuario votou nulo: "Voto nulo contabilizado."
//    - Se votou em branco: "Voto Branco contabilizado."


namespace Eleicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Eleicao--");
            Console.WriteLine();

            Console.Write("Digite seu voto: ");
            int voto = int.Parse(Console.ReadLine());

            #region "Estrutura de Decisao Simples"
            //if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
            //    Console.WriteLine("Voto contabilizado com sucesso.");
            //if (voto == 5)
            //    Console.WriteLine("Voto nulo contabilizado.");
            //if (voto == 6)
            //    Console.WriteLine("Voto branco contabilizado.");
            #endregion

            #region "Estrutura de Decisao Composta e Aninhada"
            //if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
            //    Console.WriteLine("Voto contabilizado com sucesso.");
            //else
            //    if (voto == 5)
            //        Console.WriteLine("Voto nulo contabilizado.");
            //    else
            //        if (voto == 6)
            //            Console.WriteLine("Voto branco contabilizado.");
            //        else
            //            Console.WriteLine("Voto invalido.");
            #endregion

            #region "Estrutura de Decisao Encadeada"
            if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso.");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado.");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado.");
            else
                Console.WriteLine("Voto invalido.");
            #endregion

            #region "Switch Case"
            //switch (voto)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Voto contabilizado com sucesso.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Voto nulo contabilizado.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Voto branco contabilizado.");
            //        break;
            //    default:
            //        Console.WriteLine("Voto inválido.");
            //        break;
            //}
            #endregion

            Console.WriteLine();
            Console.WriteLine("--Digite ENTER para sair--");
            Console.ReadLine();
        }
    }
}
