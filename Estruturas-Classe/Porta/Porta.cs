using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Projeto: Porta
Crie uma classe Porta e instancie um objeto que atenda aos requisitos abaixo:
Classe Porta
	Atributos privados: bool aberta e string cor.
	Método construtor sem parâmetros, inicializando o atributo aberta para falso e cor para branca.
	Métodos públicos:
	void fechar() Deve alterar o atributo aberta para falso.
	void pintar(string cor) Deve alterar o atributo cor para a nova cor passada no parâmetro cor.
Objeto
	Para testar a classe, crie um objeto porta, abra e feche a mesma, pinte-a com as cores amarelo, azul e vermelho. (Não é necessário ter interação com o usuário final. Assim, instancie o objeto porta e invoque os métodos na ordem solicitada).
*/

namespace Porta
{
    internal class Porta
    {
        private bool aberta; //Atributos
        private string cor;

        public double Area { get; set; }

        public Porta() //Método construtor
        {
            aberta = false;
            cor = "branca";
        }

        public void Abrir()
        {
            aberta = true;
        }

        public void Fechar()
        {
            aberta = false;
        }

        public void Pintar(string cor)
        {
            this.cor = cor;
        }
    }
}
