using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Quais as características de um array
            - conjunto de valores adjacentes em memória
            - tamanho fixo (alocação estática)
            - stack armazena um endereço (não um valor)
            - acesso por índice (deslocamento de endereço)
            - armazenamento é de um único tipo de dado mediante a sua declaração.
            ------------------------------------------------------------------------
            * Se eu precisar de mais itens além dos que foram alocados inicialmente?
            *      Criar um conjunto novo e recuperar os dados do conjunto anterior
            * Se eu não utilizar todos itens (posições) alocadas em memoria?
            *      Desperdício de memória.
            */

            ArrayList fruteira = new ArrayList();

            /* List => Alocação dinâmica do ponto de vista (programador)
             *          Parece dinâmica, mas eu vou provar que não é.
             * ArrayList => pode armazenar tipos de dados diferentes :( (boxing - unboxing)
             * Qual o tipo de dado de um ArrayList ? Qualquer tipo... C# qualquer tipo (Object)
             // ex: 1 => int => adicionar no ArrayList => Add(1) => 1 inteiro é convertido para objeto. 
		            Agora tipo objeto e se ele é um objeto, ele vai ser armazenando na stack ou na heap? 
		            Pq agora já não é valor, agora é um objeto que pode ser qualquer coisa então vc vai ter um endereço para a heap. Você começa a trabalhar com a heap sendo que vc poderia trabalhar somente com endereçãmento de stacks, mas ai a vc começa a trabalhar com difeços endereçamentos. E esse é o ponto. Você passa a trabalhar valores que eram valores e agora vc começa a referenciar esses valores por meio de endereços. Então por exemplo. Você tem lá
	         // 10.0 => double => adicionar no ArrayList => Add(10.0) => o 10 double é convertido para objeto. (agora minha pergunta.)
	         // essa conversão de tipo por valor => tipo por referencia. e falar de referencia é falar do que? (endereço) Essa conversão de tipo por valor para tipo por referencia, como ela se chama? BOXING, toda vez que você esta pegando um tipo por valor ao invez de vc trabalhar com o valor vc trabalha com o endereço que ele está relacionado. Isso é extremamente custoso. Pq vai usando cada vez mais endereços de memoria e tudo isso é feito de forma o que (implicita) o que é mais perigoso.
             */

            Console.WriteLine("Quantos valores vc quer digitar?");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDigitado; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero: ");
                fruteira.Add(int.Parse(Console.ReadLine()));
            }

            //fruteira.Add(10);
            fruteira.Add(14.74);
            //fruteira.Add("Vamos ver o que acontece?");
            //fruteira.Add('c');
            //fruteira.Add(10);
            //fruteira.Add(14.74);
            //fruteira.Add("Vamos ver o que acontece?");
            //fruteira.Add('c');
            //fruteira.Add(10);

            double numero = (double)fruteira[3];
        }
    }
}
