using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavajato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lavajato lavajato = new Lavajato();
            bool sair = false;

            do
            {
                Console.WriteLine("--Bem vindo ao Programa LavaJato--");
                Console.WriteLine("1 - Adicionar carro na fila.");
                Console.WriteLine("2 - Lavar o carro.");
                Console.WriteLine("3 - Retirar o carro.");
                Console.WriteLine("4 - Sair do programa.");

                Console.Write("\nQual a opção desejada? ");
                int escolhaUser = int.Parse(Console.ReadLine());

                switch (escolhaUser)
                {
                    case 1:
                        Console.Write("\nInforme o seu nome: ");
                        string nomeCliente = Console.ReadLine();
                        if (string.IsNullOrEmpty(nomeCliente))
                        {
                            Carro carro = new Carro();
                            lavajato.addCarroFila(carro);
                        }
                        else
                        {
                            Carro carro = new Carro(nomeCliente);
                            lavajato.addCarroFila(carro);
                        }
                        break;
                    case 2:
                        lavajato.movCarroPatio();
                        break;
                    case 3:
                        Console.Write("\nInforme o Id do Carro: ");
                        int idInformado = int.Parse(Console.ReadLine());
                        lavajato.retiradaCarroPatio(idInformado);
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção selecionada Inválida");
                        break;
                }

                Console.WriteLine("--Pressione ENTER para continuar--");
                Console.ReadLine();
                Console.Clear();

            } while (!sair);
        }
    }
}
