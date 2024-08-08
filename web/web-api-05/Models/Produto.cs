using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_api_05.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve conter de 3 a 100 caracteres.")]
        public string Nome { get; set; }
         
        [Required(ErrorMessage = "Estoque é obrigatório")]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        public decimal Preco {  get; set; }
    }
}