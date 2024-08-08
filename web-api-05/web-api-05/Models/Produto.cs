using System.ComponentModel.DataAnnotations;

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
    }
}