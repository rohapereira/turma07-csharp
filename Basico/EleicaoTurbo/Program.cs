using System;

//Projeto: EleicaoTurbo
//refatorar o programa do voto. colocar ele em loop. e ele tem que pedir obrigatoriamente a primeira vez o voto e depois perguntar se o usuário quer digitar mais um voto. E no final, caso o usuário não quiser mais digitar nenhum voto, o programa tem que mostrar a quantidade de votos foram registrados com sucesso, quantos foram nulos, quantos foram brancos e quantos foram digitados valores que não existiam.

namespace EleicaoTurbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa EleicaoTurbo--\n");

            #region "Minha solução"
            //int votosValidos = 0, votosNulos = 0, votosBrancos = 0, votosInvalidos = 0;

            //while (true)
            //{
            //    Console.Write("Digite o código do candidato (1, 2, 3, 4), 5 para voto nulo ou 6 para voto em branco: ");
            //    int voto = int.Parse(Console.ReadLine());

            //    switch (voto)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //            Console.WriteLine("Voto contabilizado com sucesso.");
            //            votosValidos++;
            //            break;
            //        case 5:
            //            Console.WriteLine("Voto nulo contabilizado.");
            //            votosNulos++;
            //            break;
            //        case 6:
            //            Console.WriteLine("Voto branco contabilizado.");
            //            votosBrancos++;
            //            break;
            //        default:
            //            Console.WriteLine("Voto inválido.");
            //            votosInvalidos++;
            //            break;
            //    }

            //    Console.Write("Deseja digitar mais um voto? (s/n): ");
            //    string continuar = Console.ReadLine();

            //    Console.Clear();

            //    if (continuar.ToLower() != "s")
            //        break;
            //}

            //Console.WriteLine("\nTotal de votos válidos: " + votosValidos);
            //Console.WriteLine("Total de votos nulos: " + votosNulos);
            //Console.WriteLine("Total de votos em branco: " + votosBrancos);
            //Console.WriteLine("Total de votos inválidos: " + votosInvalidos);
            #endregion

            #region "Solução do Professor"
            int votosValidos = 0, votosNulos = 0, votosBrancos = 0, votosInvalidos = 0;
            int decisaoUsuario = 0;
            string votos = "";

            do
            {
                Console.Write("Digite o código do candidato (1, 2, 3, 4), 5 para voto nulo ou 6 para voto em branco: ");
                int voto = int.Parse(Console.ReadLine());
                votos += voto;

                switch (voto)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Voto contabilizado com sucesso.");
                        votosValidos++;
                        break;
                    case 5:
                        Console.WriteLine("Voto nulo contabilizado.");
                        votosNulos++;
                        break;
                    case 6:
                        Console.WriteLine("Voto branco contabilizado.");
                        votosBrancos++;
                        break;
                    default:
                        Console.WriteLine("Voto inválido.");
                        votosInvalidos++;
                        break;
                }

                Console.Write("Deseja digitar mais um voto? Digite 1-Sim ou 2-Não: ");
                decisaoUsuario = int.Parse(Console.ReadLine());

                Console.Clear();
            }
            while (decisaoUsuario == 1);

            for (int i = 0; i < votos.Length; i++)
            {
                Console.WriteLine(votos[i]);
            }

            Console.WriteLine("Total das eleições.");
            Console.WriteLine("\nTotal de votos válidos: " + votosValidos);
            Console.WriteLine("Total de votos nulos: " + votosNulos);
            Console.WriteLine("Total de votos em branco: " + votosBrancos);
            Console.WriteLine("Total de votos inválidos: " + votosInvalidos);
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
