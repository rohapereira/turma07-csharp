using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
6) Crie um catálogo para armazenar informações sobre arquivos de músicas e filmes.

-Para cada item, deve armazenar o código, nome, categoria e tamanho hipotético do arquivo em disco;
-Para filmes deve ter também o nome do diretor, nome do ator principal e nome da atriz principal;
-Para arquivos de música também deve ter o artista e o tamanho em segundos;
-Arquivos de filme e música devem ter um método Play (ainda não implementado) e também um método RetrieveInformation, que vai (em uma futura versão) conectar com um servidor na Internet para buscar informações sobre a música ou o filme;
-Use herança se necessário. Na função Main, crie arrays para cada tipo de objeto, e os alimente com pelo menos 3 arquivos de cada tipo.
*/

/*
7) Altere o exercício anterior para mostrar ao usuário um menu em modo texto, que permita entrar com novas informações e também mostrar os dados armazenados em arrays.
*/

namespace Lista1Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Lista1Exercicio06--\n");

            List<Filmes> filmes = new List<Filmes>();
            List<Musicas> musicas = new List<Musicas>();

            int opcao;
            do
            {
                Console.WriteLine("Menu do Catálogo de Mídia:\n");
                Console.WriteLine("1. Adicionar Filme");
                Console.WriteLine("2. Adicionar Música");
                Console.WriteLine("3. Mostrar Filmes");
                Console.WriteLine("4. Mostrar Músicas");
                Console.WriteLine("5. Sair");
                Console.Write("\nSelecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        filmes.Add(AdicionarFilme());
                        break;
                    case 2:
                        musicas.Add(AdicionarMusica());
                        break;
                    case 3:
                        MostrarFilmes(filmes);
                        Console.ReadKey();
                        break;
                    case 4:
                        MostrarMusicas(musicas);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\nSaindo...");
                        Console.WriteLine("\n--Digite ENTER para sair--");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, por favor digite ENTER tente novamente.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();

            } while (opcao != 5);
        }

        // Função para adicionar filmes
        static Filmes AdicionarFilme()
        {
            Filmes filme = new Filmes();
            Console.Write("\nDigite o código: ");
            filme.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            filme.Nome = Console.ReadLine();
            Console.Write("Digite a categoria: ");
            filme.Categoria = Console.ReadLine();
            Console.Write("Digite o tamanho do arquivo (MB): ");
            filme.TamanhoArquivo = double.Parse(Console.ReadLine());
            Console.Write("Digite o diretor: ");
            filme.Diretor = Console.ReadLine();
            Console.Write("Digite o ator principal: ");
            filme.AtorPrincipal = Console.ReadLine();
            Console.Write("Digite a atriz principal: ");
            filme.AtrizPrincipal = Console.ReadLine();
            return filme;
        }

        // Função para adicionar músicas
        static Musicas AdicionarMusica()
        {
            Musicas musica = new Musicas();
            Console.Write("\nDigite o código: ");
            musica.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome: ");
            musica.Nome = Console.ReadLine();
            Console.Write("Digite a categoria: ");
            musica.Categoria = Console.ReadLine();
            Console.Write("Digite o tamanho do arquivo (MB): ");
            musica.TamanhoArquivo = double.Parse(Console.ReadLine());
            Console.Write("Digite o artista: ");
            musica.Artista = Console.ReadLine();
            Console.Write("Digite a duração (segundos): ");
            musica.DuracaoEmSegundos = int.Parse(Console.ReadLine());
            return musica;
        }

        // Função para mostrar os filmes
        static void MostrarFilmes(List<Filmes> filmes)
        {
            Console.WriteLine("\nFilmes:\n");
            foreach (var filme in filmes)
            {
                Console.WriteLine($"Código: {filme.Codigo} \nNome: {filme.Nome} \nCategoria: {filme.Categoria} \nTamanho: {filme.TamanhoArquivo}MB \nDiretor: {filme.Diretor} \nAtor Principal: {filme.AtorPrincipal} \nAtriz Principal: {filme.AtrizPrincipal}");
                filme.Reproduzir();
                filme.RecuperarInformacao();
                Console.WriteLine();
            }
        }

        // Função para mostrar as músicas
        static void MostrarMusicas(List<Musicas> musicas)
        {
            Console.WriteLine("\nMúsicas:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Código: {musica.Codigo} \nNome: {musica.Nome} \nCategoria: {musica.Categoria} \nTamanho: {musica.TamanhoArquivo}MB \nArtista: {musica.Artista} \nDuração: {musica.DuracaoEmSegundos} segundos");
                musica.Reproduzir();
                musica.RecuperarInformacao();
                Console.WriteLine();
            }
        }
    }
}
