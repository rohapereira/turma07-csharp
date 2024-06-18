using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
-Crie uma classe AlbumDeFotos com uma propriedade numeroTotalDePaginas;
-Crie outra propriedade somente leitura chamada numeroTotalDeFotos baseada na propriedade numetoTotalDePaginas, sabendo que cada página pode conter no máximo 2 fotos;
-Crie uma terceira propriedade chamada numeroDeFotos, cujo método set deve mostrar uma mensagem de erro caso o usuário ultrapasse o numeroTotalDeFotos;
*/

namespace Lista1Exercicio05
{
    public class AlbumDeFotos
    {
        // Propriedades
        public int numeroTotalDePaginas { get; set; }

        public int numeroTotalDeFotos // ready only
        {
            get
            {
                return this.numeroTotalDePaginas * 2;
            }
        }

        private int _numeroDeFotos;

        public int numeroDeFotos
        {
            get
            {
                return this._numeroDeFotos;
            }
            set
            {
                if (value > this.numeroTotalDeFotos)
                    Console.WriteLine($"ERRO: O número de fotos não deve exceder {this.numeroTotalDeFotos}.");
                else
                    this._numeroDeFotos = value;
            }
        }

        // Construtor com parâmetros
        public AlbumDeFotos(int numeroTotalDePaginas)
        {
            this.numeroTotalDePaginas = numeroTotalDePaginas;
        }
    }
}
