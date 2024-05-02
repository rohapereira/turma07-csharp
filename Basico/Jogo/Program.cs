using System;

//Projeto Jogo
//Faça um programa que receba um golpe que um personagem deve executar. O programa deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. Para identificar os golpes, utilize e teclas: c(chute), s(soco) e m(magia), onde chute vale 2 pontos, soco 4 pontos e magia 10 pontos. No final, o programa deve exibir para o usuário o número e a pontuação obtida por cada tipo de golpe, bem como a pontuação total do usuário.

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Inteiros--\n");

            #region "Minha resolução"
            //const int PONTOSCHUTE = 2;
            //const int PONTOSSOCO = 4;
            //const int PONTOSMAGIA = 10;

            //int chute = 0, soco = 0, magia = 0;

            //while (true)
            //{
            //    Console.WriteLine("Digite o golpe a ser executado (c - chute, s - soco, m - magia), ou digite 'n' para parar:");
            //    char golpe = char.Parse(Console.ReadLine().ToUpper());

            //    if (golpe == 'N')
            //        break;

            //    switch (golpe)
            //    {
            //        case 'C':
            //            chute++;
            //            break;
            //        case 'S':
            //            soco++;
            //            break;
            //        case 'M':
            //            magia++;
            //            break;
            //        default:
            //            Console.WriteLine("Golpe inválido!");
            //            break;
            //    }
            //}

            //Console.WriteLine($"Número de chutes: {chute}, Pontuação total: {chute * PONTOSCHUTE}");
            //Console.WriteLine($"Número de socos: {soco}, Pontuação total: {soco * PONTOSSOCO}");
            //Console.WriteLine($"Número de magias: {magia}, Pontuação total: {magia * PONTOSMAGIA}");
            //Console.WriteLine($"Pontuação total do usuário: {(chute * PONTOSCHUTE) + (soco * PONTOSSOCO) + (magia * PONTOSMAGIA)}");
            #endregion

            #region "Solução do Professor"
            const int PONTOSPORCADACHUTE = 2, PONTOSPORCADASOCO = 4, PONTOSPORCADAMAGIA = 10;
            const string CHUTE = "c", SOCO = "s", MAGIA = "m";
            int pontosPorChute = 0, pontosPorSoco = 0, pontosPorMagia = 0;

            string respostaUsuario = "";

            do
            {
                Console.Write($"Informe o golpe ({CHUTE}-chute {SOCO}-soco {MAGIA}-magia): ");
                string golpe = Console.ReadLine().ToLower();

                switch (golpe)
                {
                    case CHUTE:
                        pontosPorChute += PONTOSPORCADACHUTE;
                        break;
                    case SOCO:
                        pontosPorSoco += PONTOSPORCADASOCO;
                        break;
                    case MAGIA:
                        pontosPorMagia += PONTOSPORCADAMAGIA;
                        break;
                    default:
                        break;
                }

                Console.Write("Deseja entrar com mais um golpe (s-sim n-não)? ");
                respostaUsuario = Console.ReadLine().ToLower();

            } while (respostaUsuario == "s");

            Console.WriteLine($"\nNúmero de chutes: {pontosPorChute / PONTOSPORCADACHUTE}");
            Console.WriteLine($"Pontos por chutes: {pontosPorChute}\n");

            Console.WriteLine($"Número de socos: {pontosPorSoco / PONTOSPORCADASOCO}");
            Console.WriteLine($"Pontos por socos: {pontosPorSoco}\n");

            Console.WriteLine($"Número de magia: {pontosPorMagia / PONTOSPORCADAMAGIA}");
            Console.WriteLine($"Pontos por magia: {pontosPorMagia}\n");

            Console.WriteLine($"Pontuação total: {pontosPorChute + pontosPorSoco + pontosPorMagia}");
            #endregion

            Console.Write("\n--Digite ENTER para sair--\n");
            Console.ReadLine();
        }
    }
}
