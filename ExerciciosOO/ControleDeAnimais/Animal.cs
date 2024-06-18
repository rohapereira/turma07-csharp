using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {
        // Dados privados
        private string nome;
        private string tipo;

        // Métodos de acesso para o nome
        public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

        // Métodos de acesso para o tipo
        public string Tipo
		{
			get { return tipo; }
            set
            {
                // Verifica se o tipo é válido; se não, define como "Peixe"
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
            }
        }

        // Construtor sem parâmetros
        public Animal()
        {
            nome = "Desconhecido";
            tipo = "Peixe";
        }

        // Construtor com parâmetros
        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.Tipo = tipo;
        }
    }
}
